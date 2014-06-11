Imports System.IO.Ports
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Xml.Serialization
Imports System.IO

Public Class FrmMain

    Private sRetDate As String
    Private bSendCommandFlag As Boolean
    Private iStoreBoxID As Integer
    Private iSendStoreBoxID As Integer

    Private Sub FrmMain_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        CurSMS.SMS_Close(SerialPortArraylist)
        sqlExe.DBClose()
        Application.Exit()
    End Sub


    Private Sub FrmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dtStart As Date = Now
        InitSerialPortArraylist()
        CurSMS.SMS_Open(SerialPortArraylist)
        ReadPeiZhiInfo()
        StoreBoxGroupStateInit()

        If SerialPort4.PortName.ToUpper = "COM4" Then
            sRNDStr = Int((999999 - 100000 + 1) * Rnd() + 100000)
            If bCom4WriteFlag Then
                CurSMS.SMS_Write(SerialPort4, sRNDStr)
                iRndCount = 0
                Timer_Rnd.Start()
            End If
        End If

        If SerialPort5.PortName.ToUpper = "COM5" Then
            SerialPort5.ReadTimeout = 500
            SerialPort5.ReceivedBytesThreshold = 28
            SetStart()
        End If

        Try
            ' 读取配置信息
            Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(StoreBox.Config.StoreBoxConfig))
            storeboxConfig = xmlSerializer.Deserialize(New FileStream("device.xml", FileMode.Open))
        Catch ex As Exception
            MsgBox(ex)
        End Try

        ' 长连接启动
        Dim d1 As Thread = New Thread(AddressOf WebSyncThread)
        d1.IsBackground = True
        d1.Start()

        Frm_ShouYe.Show()

    End Sub

    Private Sub FrmMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Hide()
    End Sub



    Private Sub SerialPort3_DataReceived(ByVal sender As Object, _
                                         ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) _
                                         Handles SerialPort3.DataReceived, _
                                                 SerialPort4.DataReceived, _
                                                 SerialPort5.DataReceived, _
                                                 SerialPort6.DataReceived, _
                                                 SerialPort7.DataReceived, _
                                                 SerialPort11.DataReceived
        Dim iIndex As Int32

        curSerialPort = DirectCast(sender, SerialPort)
        For iIndex = 0 To UBound(sComNuber)
            If curSerialPort.PortName.ToUpper = sComNuber(iIndex) Then Exit For
        Next
        If bStartReceive(iIndex) Then
            Try
                sRetDate = CurSMS.SMS_Read(curSerialPort, iCommandType)
            Catch ex As Exception
                ' TODO: 要查一下原因，长时间运行时这里出错了
            End Try
        Else
            curSerialPort.DiscardInBuffer()
        End If

        If sRetDate = "" Then Exit Sub
        Try
            Invoke(New EventHandler(AddressOf DateDisp))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "提示！")
        End Try

    End Sub

    Private Sub DateDisp(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Select Case curSerialPort.PortName.ToUpper
            Case "COM3"
                Frm_KuaiDiDanSaoMiao.SetSymbol = sRetDate
            Case "COM4"
            Case "COM5"
                Select Case iCommandType
                    Case 0
                        If Len(sRetDate) = 10 Then
                            If sStoreBoxState(iSendStoreBoxID) <> sRetDate Then
                                SaveStoreBoxState(iSendStoreBoxID, sRetDate)
                                sStoreBoxState(iSendStoreBoxID) = sRetDate
                                If Application.OpenForms.Item("Frm_WuXiangQueRen") IsNot Nothing Then
                                    Frm_WuXiangQueRen.SetStoreBoxState = iSendStoreBoxID
                                End If
                            End If
                        End If
                    Case 1
                        Try
                            Frm_WuXiangQueRen.SetStoreBoxNumberState = sRetDate
                        Catch ex As Exception
                        End Try
                End Select
            Case "COM7"
                If sRetDate = "True" Then
                    Frm_AllFuFeiTouBi.SetCoin = True
                End If
            Case "COM11"
                If sRetDate <> "" Then
                    If struInputInfo.SelType = 4 Then
                        If Application.OpenForms.Item("Frm_ShuaKaQueRenShenFen") IsNot Nothing Then
                            Frm_ShuaKaQueRenShenFen.SetReaderNo = sRetDate
                        Else
                            Frm_ShuaKaKaiXiangQueRenShenFen.SetReaderNo = sRetDate
                        End If
                    Else
                        Frm_ShuaKaQueRenShenFen.SetReaderNo = sRetDate
                    End If
                End If
        End Select

    End Sub


    Private Sub InitSerialPortArraylist()

        SerialPortArraylist.Add(SerialPort3)
        SerialPortArraylist.Add(SerialPort4)
        SerialPortArraylist.Add(SerialPort5)
        SerialPortArraylist.Add(SerialPort6)
        SerialPortArraylist.Add(SerialPort7)
        SerialPortArraylist.Add(SerialPort11)

        bCom4WriteFlag = True
        bCom5WriteFlag = False
        bCom6WriteFlag = False

    End Sub

    Private Sub SetStop()
        If Timer_Loop.Enabled Then
            bSendCommandFlag = False
            Timer_Loop.Stop()
            SerialPort5.DiscardInBuffer()
            Threading.Thread.Sleep(1000)      '添加的延时
        End If
    End Sub

    Private Sub SetStart()
        Try
            If Not Timer_Loop.Enabled Then
                iCommandType = 0
                iStoreBoxID = -1
                bSendCommandFlag = True
                Timer_Loop.Start()
                CtrlSendOptoin()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub



    Private Sub Timer_Loop_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Loop.Tick
        CtrlSendOptoin()
    End Sub


    Private Sub Timer_Rnd_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Rnd.Tick
        iRndCount += 1
        If iRndCount = 5 Then
            sRNDStr = Int((999999 - 100000 + 1) * Rnd() + 100000)
            If bCom4WriteFlag Then
                CurSMS.SMS_Write(SerialPort4, sRNDStr)
                iRndCount = 0
            End If
        End If
    End Sub


    Private Sub CtrlSendOptoin()
        Try
            If bSendCommandFlag = True Then
                iStoreBoxID += 1
                If iStoreBoxID = iCurStoreBoxGroupCount Then
                    iStoreBoxID = 0
                End If
                bStartReceive(2) = True
                iCommandType = 0
                iSendStoreBoxID = iStoreBoxID
                CurSMS.SMS_Write(SerialPort5, iStoreBoxID + 1, 0)
            Else
                Timer_Loop.Stop()
                SerialPort5.DiscardInBuffer()
                Threading.Thread.Sleep(20)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.OkOnly, "Timer_Loop_Tick")
        End Try
    End Sub

    Private Sub SaveStoreBoxState(ByVal iStoreBoxNumber As Integer, ByVal sRevInfor As String)
        Dim i, j As Integer
        Dim iPrevBit0 As Integer
        Dim iPrevBit1 As Integer
        Dim iCompBit0, iCompBit1 As Integer
        Dim iRetBit0 As Integer
        Dim iRetBit1 As Integer
        Dim iBit0, iBit1 As Integer
        Try

            With StruStoreBoxGroup(iStoreBoxNumber)
                For j = 0 To 1
                    iPrevBit0 = CLng("&H" & Mid(sStoreBoxState(iStoreBoxNumber), j * 2 + 1, 2))
                    iPrevBit1 = CLng("&H" & Mid(sStoreBoxState(iStoreBoxNumber), (j + 3) * 2 + 1, 2))
                    iRetBit0 = CLng("&H" & Mid(sRevInfor, j * 2 + 1, 2))
                    iRetBit1 = CLng("&H" & Mid(sRevInfor, (j + 3) * 2 + 1, 2))
                    For i = 0 To 7
                        iCompBit0 = IIf((iPrevBit0 And 2 ^ i) = 0, 0, 1)
                        iCompBit1 = IIf((iPrevBit1 And 2 ^ i) = 0, 0, 1)
                        iBit0 = IIf((iRetBit0 And 2 ^ i) = 0, 0, 1)
                        iBit1 = IIf((iRetBit1 And 2 ^ i) = 0, 0, 1)
                        If .Lbl_BoxNumber(j * 8 + i).bYellow = 0 Then
                            CompSaveStoreBoxState(iStoreBoxNumber, j * 8 + i, iCompBit0, iBit0, iCompBit1, iBit1)
                        End If
                    Next i
                Next j
                iPrevBit0 = CLng("&H" & Mid(sStoreBoxState(iStoreBoxNumber), 5, 1))
                iPrevBit1 = CLng("&H" & Mid(sStoreBoxState(iStoreBoxNumber), 6, 1))
                iRetBit0 = CLng("&H" & Mid(sRevInfor, 6, 1))
                iRetBit1 = CLng("&H" & Mid(sRevInfor, 5, 1))
                For i = 0 To 3
                    iCompBit0 = IIf((iPrevBit0 And 2 ^ i) = 0, 0, 1)
                    iCompBit1 = IIf((iPrevBit1 And 2 ^ i) = 0, 0, 1)
                    iBit0 = IIf((iRetBit0 And 2 ^ i) = 0, 0, 1)
                    iBit1 = IIf((iRetBit1 And 2 ^ i) = 0, 0, 1)
                    If .Lbl_BoxNumber(16 + i).bYellow = 0 Then
                        CompSaveStoreBoxState(iStoreBoxNumber, 16 + i, iCompBit0, iBit0, iCompBit1, iBit1)
                    End If
                Next i
            End With
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.OkOnly, "SaveStoreBoxState")
        End Try


    End Sub

    Private Sub CompSaveStoreBoxState(ByRef iStoreBoxNumber As Integer, _
                                      ByVal iBoxIndex As Integer, _
                                      ByVal iCompBit0 As Integer, _
                                      ByVal iBit0 As Integer, _
                                      ByVal iCompBit1 As Integer, _
                                      ByVal iBit1 As Integer)
        Dim sSQL As String
        Dim bUpdateFlag As Boolean = False
        Try

            With StruStoreBoxGroup(iStoreBoxNumber).Lbl_BoxNumber(iBoxIndex)
                If iCompBit0 <> iBit0 Then
                    bUpdateFlag = True
                    .bRed = iBit0
                    .bRedDispFlag = True
                    If .bRed = 0 Then
                        .Lbl_Red.ForeColor = Color.Red
                    Else
                        .Lbl_Red.ForeColor = Color.Silver
                    End If
                End If
                If iCompBit1 <> iBit1 Then
                    bUpdateFlag = True
                    .bGreen = iBit1
                    .bGreenDispFlag = True
                    If .bGreen = 1 Then
                        .Lbl_Green.ForeColor = Color.Lime
                    Else
                        .Lbl_Green.ForeColor = Color.Silver
                    End If
                End If
                If bUpdateFlag Then
                    sSQL = "Update WuXiangZhuangTai " & _
                              "Set KaiGuanZhuangTai = " & iBit0 & "," & _
                                  "YouWuZhuangTai = " & iBit1 & _
                           " Where GroupNo = " & iStoreBoxNumber + 1 & " And BianHao = " & iBoxIndex + 1
                    sqlExe.AddUpdateDelOpe(sSQL)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.OkOnly, "CompSaveStoreBoxState")
        End Try

    End Sub



    Public WriteOnly Property SetCtrlStartStop() As Boolean
        Set(ByVal value As Boolean)
            If value Then
                SetStart()
            Else
                SetStop()
            End If
        End Set
    End Property

    Public WriteOnly Property SetCtrlOpen() As String
        Set(ByVal value As String)
            SetStop()
            bStartReceive(2) = True
            iCommandType = 1
            CurSMS.SMS_Write(SerialPort5, value, 1)
        End Set
    End Property


    Public WriteOnly Property SetSMSSend() As String
        Set(ByVal value As String)
            bStartReceive(3) = True
            CurSMS.SMS_Write(SerialPort6, value)
        End Set
    End Property

    ' 定时收集物箱状态信息，并上传到平台端
    Private Sub Timer_S3_Tick(sender As Object, e As EventArgs) Handles Timer_S3.Tick
        StorageStatusSync()
    End Sub

    Private Sub Timer_BoxCommand_Tick(sender As Object, e As EventArgs) Handles Timer_BoxCommand.Tick
        ' 定时器根据OpenBoxNum变量值进行开箱
        If OpenBoxNum IsNot Nothing AndAlso OpenBoxNum <> "" Then
            Try
                Me.SetCtrlOpen = OpenBoxNum
            Catch
                ' do nothing
            End Try
            ' 无论开箱是否成功均清空变量
            ' OpenBoxNum = ""
            OpenBoxNum = Nothing
        End If
    End Sub
End Class
