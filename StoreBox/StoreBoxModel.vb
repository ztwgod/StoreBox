Imports System.Data.SqlClient
Imports System.IO.Ports
Imports System.Management
Imports System.Environment
Imports System.IO
Imports StoreBox.Config

Module StoreBoxModel

    Public sqlExe As New CDBOperation
    Public SerialPortArraylist As New ArrayList
    Public CurSMS As New sms.Sms
    Public curSerialPort As SerialPort
    Public sComNuber() As String = {"COM3", "COM4", "COM5", "COM6", "COM7", "COM11"}
    Public bStartReceive() As Boolean = {False, False, True, False, False, False}
    Public bCom4WriteFlag, bCom5WriteFlag, bCom6WriteFlag
    Public iCommandType As Integer
    Public sRNDStr As String
    Public iRndCount As Integer
    Public Const CTRL_LOOP_TIME As Int32 = 250
    Public sStoreBoxState(3) As String

    Public PdFlag As Integer = 1
    Public PaiJianFlag As Boolean = False
    Public Const HUAMIANTOP As Int32 = 20

    'Public iSendCount As Long
    'Public iRevCount As Long



    Public Structure StoreBoxNumberCtrl_Stru
        Dim bRed As Integer
        Dim Lbl_Red As Label
        Dim bRedDispFlag As Boolean
        Dim bGreen As Integer
        Dim Lbl_Green As Label
        Dim bGreenDispFlag As Boolean
        Dim bYellow As Integer
        Dim bYellowDispFlag As Boolean
        Dim iDaXiaoZhuangTai As Integer
        Dim iShiYongZhuangTai As Integer
        Dim iYouWuLeiXing As Integer
    End Structure
    Public Structure StoreBoxGroup_Stru
        Dim Lbl_BoxNumber() As StoreBoxNumberCtrl_Stru
    End Structure
    Public StruStoreBoxGroup(3) As StoreBoxGroup_Stru

    Public Structure StoreBoxNumberGuZhang_Stru
        Dim bOldYellow As Integer
        Dim bYellow As Integer
        Dim Lbl_Red As Label
        Dim Lbl_Yellow As Label
    End Structure
    Public Structure StoreBoxGroupGuZhang_Stru
        Dim Lbl_BoxNumber() As StoreBoxNumberGuZhang_Stru
    End Structure
    Public StruStoreBoxGroupGuZhang(3) As StoreBoxGroupGuZhang_Stru

    Public StoreBoxGroupGuZhangState(3, 20) As Integer

    Public Structure StoreBoxGuZhangHuiFu_Stru
        Dim iStoreBoxGroupNumber As Integer
        Dim iStoreBoxNumber As Integer
        Dim iRetState As Integer
    End Structure
    Public StruStoreBoxGuZhangHuiFu() As StoreBoxGuZhangHuiFu_Stru

    Public iCurStoreBoxGroupCount As Integer

    Public Structure StoreBoxPeiZhi_Stru
        Dim StroeBoxID As String
        Dim Tel As String
        Dim StoreBoxSum As Integer
    End Structure
    Public struStoreBoxPeiZhi As StoreBoxPeiZhi_Stru

    Public Structure InputInfo_Stru
        Dim SelType As Integer          '业务类型
        Dim KuaiDi As Integer           '快递公司
        Dim SelWuXiangDaXiao As Integer '物箱大小
        Dim StoreBoxGroupNo As Integer  '组号
        Dim StoreBoxNo As Integer       '组编号（1-20）
        Dim SelWuXiangNo As Integer     '物箱编号（1-80）
        Dim ShouJianRenTel As String    '收件人手机
        Dim JiJianRenTel As String      '寄件人手机
        Dim SaoMiaoDanHao As String     '扫描单号
        Dim KuaiDiDanHao As String
        Dim FuFeiE As Integer           '付费金额
        Dim TouBiJinE As Integer        '要投币金额
        Dim sICCardNo As String
        Dim KuaidiId As String
        Dim ShouJianPaiJian As String
        Dim KaiXiangMima As String      '开箱密码
        Dim InputMiMa As String         '输入密码
        Dim CardRenName As String
    End Structure
    Public struInputInfo As InputInfo_Stru

    Public sSelKaiXiangNo As String
    Public sSetStoreBoxState As String
    Public SelStoreBoxNoLabel As New Label

    Public iNullStoreBoxNoCount(2) As Integer '空箱数量计算
    Public iNullStoreBoxNo(2, 47) As Integer
    Public storeboxConfig As StoreBoxConfig



    Public Sub Main()
        Try
            If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length() > 1 Then
                MsgBox("该程序已经运行了，请使用已经运行的程序！", vbOKOnly Or vbInformation, "提示信息")
                Application.Exit()
                Exit Sub
            End If
            Application.EnableVisualStyles()
            '连接数据库
            If sqlExe.DBConnect() = False Then
                Application.Exit()
                Exit Sub
            End If

            log4net.Config.XmlConfigurator.ConfigureAndWatch(New FileInfo(AppDomain.CurrentDomain.BaseDirectory + "\\log4net.config"))


            FrmMain.Show()
            Application.Run()

        Catch ex As Exception
            MsgBox(ex.Message.ToString, vbOKOnly Or vbInformation, "提示信息")
        End Try

    End Sub


    Public Sub ReadPeiZhiInfo()
        Dim sSQL As String
        Dim datread As SqlDataReader = Nothing           '用于存放记录集
        Dim bFlag As Boolean

        Try
            '读取配置信息
            sSQL = "Select * From PeiZhi"
            bFlag = sqlExe.GetRecordData(sSQL, datread)
            '输入错误
            If bFlag = False Then
                MessageBox.Show("数据库异常，请您联系系统维护人员解决后再执行本操作！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            datread.Read()
            With struStoreBoxPeiZhi
                .StroeBoxID = "" & datread("StoreBoxID").ToString
                .Tel = "" & datread("Tel").ToString
                .StoreBoxSum = Int32.Parse(datread("StoreBoxSum").ToString)
                datread.Close()
                iCurStoreBoxGroupCount = .StoreBoxSum
            End With
        Catch ex As Exception
            MessageBox.Show("数据库异常，请您联系系统维护人员解决后再执行本操作！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End Try
    End Sub


    Public Sub StoreBoxGroupStateInit()
        Dim sSQL As String
        Dim datread As SqlDataReader = Nothing            '用于存放记录集
        Dim bFlag As Boolean
        Dim i, j As Integer

        Try
            For i = 0 To UBound(StruStoreBoxGroup) 'struStoreBoxPeiZhi.StoreBoxSum - 1
                ReDim StruStoreBoxGroup(i).Lbl_BoxNumber(19)
                ReDim StruStoreBoxGroupGuZhang(i).Lbl_BoxNumber(19)
                For j = 0 To 19
                    With StruStoreBoxGroup(i).Lbl_BoxNumber(j)
                        .Lbl_Red = New Label
                        .Lbl_Green = New Label
                    End With

                    With StruStoreBoxGroupGuZhang(i).Lbl_BoxNumber(j)
                        .Lbl_Yellow = New Label
                    End With

                    StoreBoxGroupGuZhangState(i, j) = 0
                Next j
            Next i

            sSQL = "Select * From WuXiangZhuangTai Where GroupNo <= " & struStoreBoxPeiZhi.StoreBoxSum & " Order by Key_ID"
            bFlag = sqlExe.GetRecordData(sSQL, datread)

            While datread.Read()
                i = datread("GroupNo").ToString - 1
                j = datread("BianHao").ToString - 1
                With StruStoreBoxGroup(i).Lbl_BoxNumber(j)
                    .bRed = datread("KaiGuanZhuangTai").ToString
                    .bGreen = datread("YouWuZhuangTai").ToString
                    .bYellow = datread("ZhengChangZhuangTai").ToString
                    .iDaXiaoZhuangTai = datread("DaXiaoZhuangTai").ToString
                    .iYouWuLeiXing = datread("YouWuLeiXing").ToString
                    .bRedDispFlag = True
                    .bGreenDispFlag = True
                    .bYellowDispFlag = True
                    .iShiYongZhuangTai = IIf(.bYellow = 0 AndAlso .bRed = 0 AndAlso .bGreen = 1, 0, 1)
                End With

                With StruStoreBoxGroupGuZhang(i).Lbl_BoxNumber(j)
                    .bOldYellow = datread("ZhengChangZhuangTai").ToString
                    .bYellow = datread("ZhengChangZhuangTai").ToString
                End With
            End While
            datread.Close()

            FillStoreBoxGroupStateHex()

        Catch ex As Exception
            MessageBox.Show("数据库异常，请您联系系统维护人员解决后再执行本操作！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End Try

    End Sub


    Private Sub FillStoreBoxGroupStateHex()
        Dim i, j As Integer
        Dim iBit0, iBit1 As Integer
        Dim sMen(2), sWu(2) As String

        For iStoreBoxNumber = 0 To struStoreBoxPeiZhi.StoreBoxSum - 1
            With StruStoreBoxGroup(iStoreBoxNumber)
                For j = 0 To 1
                    iBit0 = 0 : iBit1 = 0
                    For i = 0 To 7
                        iBit0 += .Lbl_BoxNumber(j * 8 + i).bRed * 2 ^ i 'IIf((iRetBit0 And 2 ^ i) = 0, 0, 1)
                        iBit1 += .Lbl_BoxNumber(j * 8 + i).bGreen * 2 ^ i
                    Next i
                    sMen(j) = Hex(iBit0) : sWu(j) = Hex(iBit1)
                    If sMen(j).Length = 1 Then sMen(j) = "0" & sMen(j)
                    If sWu(j).Length = 1 Then sWu(j) = "0" & sWu(j)
                Next j
                iBit0 = 0 : iBit1 = 0
                For i = 0 To 3
                    iBit0 += .Lbl_BoxNumber(16 + i).bRed * 2 ^ i
                    iBit1 += .Lbl_BoxNumber(16 + i).bGreen * 2 ^ i
                Next i
                sMen(2) = Hex(iBit0) : sWu(2) = Hex(iBit1)
            End With
            sStoreBoxState(iStoreBoxNumber) = sMen(0) & sMen(1) & sWu(2) & sMen(2) & sWu(0) & sWu(1)
        Next iStoreBoxNumber

    End Sub


    '计算
    Public Sub GetNullCount()
        Dim sSQL As String
        Dim datread As SqlDataReader = Nothing            '用于存放记录集
        Dim datread2 As SqlDataReader = Nothing           '存放中间过程
        Dim iCurDaXiaoZhuangTai As Integer
        Dim bFlag As Boolean
        Dim i As Integer
        Dim j As Integer
        Dim box_number As Integer
        Dim iNotNullStoreBoxNo(2, 79) As Integer
        Dim temp As Integer

        Try
            For i = 0 To 2
                iNullStoreBoxNoCount(i) = 0
                For j = 0 To 79
                    iNotNullStoreBoxNo(i, j) = 0
                Next
            Next
            sSQL = "Select * From CunQuJianXinXi " & _
                                 "Where QuJianShiJian = '' And " & _
                                       "JiJianDianHua <> ''And " & _
                                       "ShouJianDianHua <> '' " & _
                              "Order by BaoCunXiangHao"
            bFlag = sqlExe.GetRecordData(sSQL, datread)
            While datread.Read()
                box_number = datread("BaoCunXiangHao")
                While (box_number > 20)
                    box_number = box_number - 20
                End While
                temp = (datread("BaoCunXiangHao") - 1) / 20 + 0.51
                sSQL = "Select * From WuXiangZhuangTai " & _
                "Where GroupNo = " & temp & " And " & _
                       "BianHao = " & box_number
                bFlag = sqlExe.GetRecordData(sSQL, datread2)
                datread2.Read()
                iCurDaXiaoZhuangTai = datread2("DaXiaoZhuangTai").ToString
                iNotNullStoreBoxNo(iCurDaXiaoZhuangTai, datread("BaoCunXiangHao") - 1) = 1
                datread2.Close()
            End While
            sSQL = "Select * From WuXiangZhuangTai " & _
                   "Where ZhengChangZhuangTai=0 And KaiGuanZhuangTai=0 And YouWuZhuangTai=1"
            bFlag = sqlExe.GetRecordData(sSQL, datread)
            While (datread.Read())
                If iNotNullStoreBoxNo(datread("DaXiaoZhuangTai"), datread("BianHao") + (datread("GroupNo") - 1) * 20 - 1) = 0 Then
                    iNotNullStoreBoxNo(datread("DaXiaoZhuangTai"), datread("BianHao") + (datread("GroupNo") - 1) * 20 - 1) = 2
                End If
            End While
            For i = 0 To 2
                temp = 0
                For j = 0 To 79
                    If iNotNullStoreBoxNo(i, j) = 2 Then
                        iNullStoreBoxNoCount(i) += 1
                        iNullStoreBoxNo(i, temp) = j + 1
                        temp = temp + 1
                    End If
                Next
            Next
            datread.Close()

        Catch ex As Exception
            MessageBox.Show("数据库异常，请您联系系统维护人员解决后再执行本操作！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End Try

    End Sub


    Public Function chkICCard(ByVal schkCardNo As String, ByRef kuaidiId As String) As Boolean
        Dim sDataBase() As String = {"KuaiDiYuan", "GuanLiYuan"}
        Dim sSQL As String
        Dim datread As SqlDataReader = Nothing            '用于存放记录集
        Dim bFlag As Boolean

        Try
            sSQL = "Select * From " & sDataBase(struInputInfo.SelType - 4) & _
                          " Where KaHao= '" & schkCardNo & "'"
            bFlag = sqlExe.GetRecordData(sSQL, datread)
            If datread.Read() Then
                kuaidiId = datread("id")
                chkICCard = True
            End If
            datread.Close()

        Catch ex As Exception
            MessageBox.Show("数据库异常，请您联系系统维护人员解决后再执行本操作！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End Try

    End Function

    Public Function chkMiMa(ByVal schkMiMa As String) As String
        Dim sDataBase() As String = {"KuaiDiYuan", "GuanLiYuan"}
        Dim sSQL As String
        Dim datread As SqlDataReader = Nothing            '用于存放记录集
        Dim bFlag As Boolean

        Try
            sSQL = "Select * From " & sDataBase(struInputInfo.SelType - 4) & _
                          " Where KaHao= '" & struInputInfo.sICCardNo & "' And MiMa= '" & schkMiMa & "'"
            bFlag = sqlExe.GetRecordData(sSQL, datread)

            chkMiMa = ""
            If datread.Read() Then
                chkMiMa = datread("XingMing").ToString
            End If
            datread.Close()

        Catch ex As Exception
            MessageBox.Show("数据库异常，请您联系系统维护人员解决后再执行本操作！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End Try

    End Function

    Public Function WriteRiZhi(ByVal CaoZuoLeiXing As String, _
                               ByVal CaoZuoRen As String, _
                               ByVal YunDanHao As String, _
                               ByVal XiangHao As String, _
                               ByVal NeiRong As String) As Boolean
        Dim sInsert As String

        sInsert = "INSERT INTO RiZhi( ShiJian," & _
                                     "YeWuLeiXing," & _
                                     "CaoZuoLeiXing," & _
                                     "CaoZuoRen," & _
                                     "YunDanHao," & _
                                     "XiangHao," & _
                                     "NeiRong)" & _
                             "VALUES(" & _
                                     "'" & Now & "'," & _
                                     "'" & struInputInfo.SelType & "'," & _
                                     "'" & CaoZuoLeiXing & "'," & _
                                     "'" & CaoZuoRen & "'," & _
                                     "'" & YunDanHao & "'," & _
                                     struInputInfo.SelWuXiangNo & "," & _
                                     "'" & NeiRong & "')"
        sqlExe.AddUpdateDelOpe(sInsert)
    End Function



    Public Sub SetCommonInfo(ByVal curForm As Form)

        Dim Lbl_Company As Label = New Label
        Dim Lbl_Tel As Label = New Label
        Dim Lbl_Tel_H As Label = New Label

        curForm.Hide()


        curForm.Controls.Add(Lbl_Company)
        With Lbl_Company
            .Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            .Left = 50
            .Top = 720
            .ForeColor = Color.Transparent
            .AutoSize = True
            .Text = "上海讯宝信息技术有限公司"
            .BackColor = Color.Transparent
        End With

        curForm.Controls.Add(Lbl_Tel)
        With Lbl_Tel
            .Name = "Lbl_Tel"
            .AutoSize = True
            .Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            .Text = struStoreBoxPeiZhi.Tel
            .Left = 800
            .Top = 720
            .ForeColor = Color.Transparent
            .Text = struStoreBoxPeiZhi.Tel
            .BackColor = Color.Transparent
        End With
        curForm.Controls.Add(Lbl_Tel_H)
        With Lbl_Tel_H
            .Name = "Lbl_Tel_H"
            .AutoSize = True
            .Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            .Text = "紧急服务电话:"
            .Left = Lbl_Tel.Left - .Width
            .Top = 720
            .ForeColor = Color.Transparent
            .BackColor = Color.Transparent
        End With
        Dim Lbl_ID As Label = New Label
        curForm.Controls.Add(Lbl_ID)
            With Lbl_ID
                .Name = "Lbl_ID"
                .Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
                .Left = 420
                .Top = 720
                .ForeColor = Color.Transparent
                .AutoSize = True
                .Text = "ID：" & struStoreBoxPeiZhi.StroeBoxID
                .BackColor = Color.Transparent
            End With
        curForm.BackColor = Color.SteelBlue
        curForm.Show()

    End Sub

    Public Sub SetCommonHead(ByRef lbl_Head As Label, _
                             ByRef btn_Prev As Button, _
                             ByRef btn_Ret As Button, _
                             ByRef lbl_Timer As Label, _
                             ByRef lbl_Sec As Label, _
                             ByRef lbl_S As Label, _
                             ByRef lbl_TiShi As Label)
        If lbl_Head IsNot Nothing Then
            With lbl_Head
                .Top = HUAMIANTOP
                .Left = (Screen.PrimaryScreen.Bounds.Width - .Width) / 2
            End With
        End If
        If btn_Ret IsNot Nothing Then
            With btn_Ret
                .Width = 80
                .Height = 70
                .Top = 8
                .Left = (Screen.PrimaryScreen.Bounds.Width - .Width) - 8
            End With
        End If
        If lbl_Timer IsNot Nothing Then
            With lbl_Timer
                .Top = HUAMIANTOP
                .Left = (Screen.PrimaryScreen.Bounds.Width - .Width) - HUAMIANTOP
            End With
        End If
        If lbl_Sec IsNot Nothing Then
            With lbl_Sec
                .Top = lbl_Timer.Top + lbl_Timer.Height + 6
                .Width = 70
                .Left = lbl_Timer.Left
            End With
        End If
        If lbl_S IsNot Nothing Then
            With lbl_S
                .AutoSize = False
                .Top = lbl_Sec.Top
                .Left = (lbl_Sec.Left + lbl_Sec.Width)
            End With
        End If
        If lbl_TiShi IsNot Nothing Then
            With lbl_TiShi
                .Left = (Screen.PrimaryScreen.Bounds.Width - .Width) / 2
            End With
        End If

    End Sub

    '处理键盘输入到电话号码text
    Public Sub SetTelInfo(ByVal sInsertChar As String, ByRef curTextBox As TextBox)
        With curTextBox
            If .TextLength = .MaxLength AndAlso sInsertChar <> "BK" Then Exit Sub
            Dim iInertPosi As Int32 = .SelectionStart
            If sInsertChar = "BK" Then
                If .SelectionStart > 0 Then
                    .Text = Strings.Left(.Text, .SelectionStart - 1) & Mid(.Text, .SelectionStart + 1)
                    .SelectionStart = iInertPosi - 1
                End If
            Else
                If sInsertChar = "HX" Then sInsertChar = "-"
                If .SelectionStart = 0 Then
                    .Text = sInsertChar & Mid(.Text, .SelectionStart + 1)
                    .SelectionStart = 1
                Else
                    .Text = Strings.Left(.Text, .SelectionStart) & sInsertChar & Mid(.Text, .SelectionStart + 1)
                    .SelectionStart = iInertPosi + 1
                End If
            End If
            .Focus()
        End With

    End Sub

    Public Sub DelTelInfo(ByRef curTextBox As TextBox)
        With curTextBox
            Dim iInertPosi As Int32 = .SelectionStart
            If .SelectionStart > 0 Then
                .Text = Strings.Left(.Text, .SelectionStart - 1) & Mid(.Text, .SelectionStart + 1)
                .SelectionStart = iInertPosi - 1
            End If
            .Focus()
        End With
    End Sub


    Public Function ChkTel(ByVal sShouJi As String) As String
        If Len(sShouJi) = 11 Then
            Dim sTelPrev2 As String = sShouJi.Substring(0, 2)
            Dim sTelPrev3 As String = sShouJi.Substring(0, 3)
            If Not (sTelPrev2 = "13" OrElse _
                    sTelPrev2 = "15" OrElse _
                    sTelPrev2 = "18" OrElse _
                    sTelPrev3 = "145" OrElse _
                    sTelPrev3 = "147") Then
                Return "该手机号无效！"
            Else
                Return ""
            End If
        Else
            Return "请输入11位手机号码！"
        End If
    End Function



End Module
