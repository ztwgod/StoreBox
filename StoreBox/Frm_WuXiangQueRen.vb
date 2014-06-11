Imports System.Data.SqlClient
Imports XB.API.Client
Imports XB.API.Domain
Imports XB.API.Client.Request
Imports Microsoft.VisualBasic

Public Class Frm_WuXiangQueRen
    Private iCount As Integer = 60
    Private bSMSFirstSend As Boolean
    Private bChkStoreBoxOpenState As Boolean
    Private bChkStoreBoxCloseState As Boolean
    Private sErrInfo As String
    Private iKaiXiangRND8 As Integer

    Private Sub Frm_WuXiangQueRen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case struInputInfo.SelType
            Case 1
                Lbl_Head.Text = "物箱确认"
                Lbl_ShuoMing.Text = "请将您的物品投放至如下箱子并关好箱门："
                Lbl_ShuoMing.Left = (Screen.PrimaryScreen.Bounds.Width - Lbl_ShuoMing.Width) / 2
                Lbl_Head.Left = (Screen.PrimaryScreen.Bounds.Width - Lbl_Head.Width) / 2
            Case 2
                Lbl_Head.Text = "开箱业务选择"
                Lbl_ShuoMing.Text = "请取走如下箱子的物品并关好箱门："
                Lbl_ShuoMing.Left = (Screen.PrimaryScreen.Bounds.Width - Lbl_ShuoMing.Width) / 2
                Lbl_Head.Text = "物箱确认"
                Lbl_ShuoMing.Text = "请将您的物品投放至如下箱子并关好箱门："
                Lbl_Head.Left = (Screen.PrimaryScreen.Bounds.Width - Lbl_Head.Width) / 2
            Case 4
                If struInputInfo.ShouJianPaiJian = "收件" Then
                    Lbl_Head.Text = "开箱业务选择"
                    Lbl_ShuoMing.Text = "请取走如下箱子的物品并关好箱门："
                    Lbl_ShuoMing.Left = (Screen.PrimaryScreen.Bounds.Width - Lbl_ShuoMing.Width) / 2
                    Lbl_Head.Left = (Screen.PrimaryScreen.Bounds.Width - Lbl_Head.Width) / 2
                Else
                    Lbl_Head.Text = "物箱确认"
                    Lbl_ShuoMing.Text = "请将您的物品投放至如下箱子并关好箱门："
                    Lbl_ShuoMing.Left = (Screen.PrimaryScreen.Bounds.Width - Lbl_ShuoMing.Width) / 2
                    Lbl_Head.Left = (Screen.PrimaryScreen.Bounds.Width - Lbl_Head.Width) / 2
                End If
            Case 5
                Lbl_Head.Text = "物箱确认"
                Lbl_ShuoMing.Text = "如下箱子开："
                Lbl_ShuoMing.Left = (Screen.PrimaryScreen.Bounds.Width - Lbl_ShuoMing.Width) / 2
                Lbl_Head.Left = (Screen.PrimaryScreen.Bounds.Width - Lbl_Head.Width) / 2
        End Select
        SetCommonHead(Lbl_Head, Nothing, Nothing, Lbl_Timer, Lab_DaoJiShi, Lbl_S, Nothing)
        SetCommonInfo(Me)
        Lab_DaoJiShi.Text = iCount
        With struInputInfo
            If .SelWuXiangNo < 10 Then
                Lbl_StoreBoxNo1.Text = "0"
                Lbl_StoreBoxNo2.Text = .SelWuXiangNo
            Else
                Lbl_StoreBoxNo1.Text = Strings.Left(.SelWuXiangNo.ToString, 1)
                Lbl_StoreBoxNo2.Text = Strings.Right(.SelWuXiangNo.ToString, 1)
            End If
        End With
        bChkStoreBoxOpenState = False
        bChkStoreBoxCloseState = False
        bSMSFirstSend = False
        sErrInfo = ""
        Lab_DaoJiShi.Left = 45
        Lab_DaoJiShi.Top = 1
    End Sub



    Private Sub Frm_WuXiangQueRen_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        With StruStoreBoxGroup(struInputInfo.StoreBoxGroupNo - 1).Lbl_BoxNumber(struInputInfo.StoreBoxNo - 1)
            If .bYellow = 0 Then
                If .bRed = 0 Then
                Else
                    sErrInfo = "该箱已经处于打开状态！"
                End If
            Else
                sErrInfo = "故障箱，不能打开！"
            End If
        End With
        If sErrInfo = "" Then
            FrmMain.SetCtrlOpen = struInputInfo.StoreBoxGroupNo & "," & struInputInfo.StoreBoxNo
            Timer_Ctrl_Wait.Start()
        End If

    End Sub



    Private Sub Timer_DaoJiShi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DaoJiShi.Tick
        iCount -= 1
        Lab_DaoJiShi.Text = iCount
        If sErrInfo <> "" Then
            Timer_DaoJiShi.Stop()
            MessageBox.Show(sErrInfo, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With struInputInfo
                WriteRiZhi("故障", "", "", .SelWuXiangNo, sErrInfo)
            End With
            '不知何用
            If struInputInfo.SelType = 5 Then
                Frm_WeiHuYeWu.Close()
                Frm_WeiHuYeWuXuanZe.Close()
            End If
            Frm_ShouYe.Show()
            FrmMain.SetCtrlStartStop = True
            Me.Close()
        End If

        If iCount = 0 Then
            With struInputInfo
                WriteRiZhi("关箱", "", "", .SelWuXiangNo, "超时！")
            End With
            Frm_ShouYe.Show()
            If struInputInfo.SelType = 5 Then
                Frm_WeiHuYeWu.Close()
                Frm_WeiHuYeWuXuanZe.Close()
            End If
            FrmMain.SetCtrlStartStop = True
            Me.Close()
        Else
            '不知何意
            If Not (bChkStoreBoxOpenState AndAlso bChkStoreBoxCloseState) Then
                Exit Sub
            End If
            With StruStoreBoxGroup(struInputInfo.StoreBoxGroupNo - 1).Lbl_BoxNumber(struInputInfo.StoreBoxNo - 1)
                If .bYellow = 0 AndAlso .bRed = 0 Then
                    Randomize()
                    iKaiXiangRND8 = Int((99999999 - 10000000 + 1) * Rnd() + 10000000)
                    SaveInfo()
                    Select Case struInputInfo.SelType
                        Case 1
                            Frm_YeWuWanChengTiShi.Show()
                            With struInputInfo
                                WriteRiZhi("寄件", .JiJianRenTel, .SaoMiaoDanHao, .SelWuXiangNo, "成功！")
                            End With
                            Me.Close()
                        Case 2
                            Frm_YeWuBanLi.Show()
                            With struInputInfo
                                WriteRiZhi("收件", .ShouJianRenTel, .KaiXiangMima, .SelWuXiangNo, "成功！")
                            End With
                            Me.Close()
                        Case 3  '没有日志
                            If bSMSFirstSend = False Then
                                bSMSFirstSend = True
                                SMS_Send()
                            End If
                            Frm_YeWuBanLi.Show()
                            Me.Close()
                        Case 4
                            If struInputInfo.ShouJianPaiJian = "收件" Then
                                Frm_KaiXiangYeWuXuanZe.Show()
                                With struInputInfo
                                    WriteRiZhi("快递员收件", .CardRenName, .sICCardNo, .SelWuXiangNo, "成功！")
                                End With
                                Me.Close()
                            Else
                                If bSMSFirstSend = False Then
                                    bSMSFirstSend = True
                                    SMS_Send()
                                End If
                                Frm_XuanZeWuXiang.Show()
                                Me.Close()
                            End If
                        Case 5
                            With struInputInfo
                                WriteRiZhi("管理员开箱", .CardRenName, "", .SelWuXiangNo, "成功！")
                            End With
                            Me.Close()
                            Frm_WeiHuYeWu.Close()
                            Frm_WeiHuYeWuXuanZe.Focus()
                    End Select
                End If
            End With
        End If

    End Sub

    Private Sub Timer_Ctrl_Wait_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer_Ctrl_Wait.Tick
        Timer_Ctrl_Wait.Stop()
        sErrInfo = "开门故障！"
    End Sub



    Private Sub SMS_Send()
        FrmMain.SetSMSSend = struInputInfo.ShouJianRenTel & "开箱密码：" & iKaiXiangRND8
    End Sub




    Private Function SaveInfo() As Boolean
        Dim sInsert As String = ""
        Dim sUpdate As String = ""

        Dim keyId As String = Guid.NewGuid().ToString("N")

        sInsert = "INSERT INTO CunQuJianXinXi( KEY_ID," & _
                                            "KuaiDiGongSi," & _
                                            "YunDanHao," & _
                                            "ShouJianDianHua," & _
                                            "JiJianDianHua," & _
                                            "BaoCunWeiZhi," & _
                                            "BaoCunXiangHao," & _
                                            "BaoCunShiJian," & _
                                            "QuJianShiJian," & _
                                            "QuJianMiMa," & _
                                            "FuFeiE," & _
                                            "YuQiShouFei," & _
                                            "YeWuLeiXing," & _
                                            "ShouJianRen," & _
                                            "JiJianRen)" & _
                                   "VALUES(" & _
                                          "'" & keyId & "'," & _
                                          "'" & struInputInfo.KuaiDi & "'," & _
                                          "'" & struInputInfo.SaoMiaoDanHao & "'," & _
                                          "'" & struInputInfo.ShouJianRenTel & "'," & _
                                          "'" & struInputInfo.JiJianRenTel & "'," & _
                                          "'" & struStoreBoxPeiZhi.StroeBoxID & "'," & _
                                          struInputInfo.SelWuXiangNo & ","
        Select Case struInputInfo.SelType

            Case 1      ' 寄件人寄件
                sInsert &= "'" & Now & "'," & _
                           "''," & _
                           "'" & iKaiXiangRND8 & "'," & _
                           struInputInfo.TouBiJinE & "," & _
                           0 & "," & _
                           struInputInfo.SelType & "," & _
                           "''," & _
                           "'')"

            Case 2      ' 收件人收件
                ' 找到Key_ID 用做平台通讯用
                Dim dr As SqlDataReader
                sqlExe.GetRecordData("Select * From CunQuJianXinXi Where  BaoCunXiangHao = " & struInputInfo.SelWuXiangNo & " And " & _
                                                    "ShouJianDianHua = '" & struInputInfo.ShouJianRenTel & "' And " & _
                                                    "QuJianMiMa = '" & struInputInfo.KaiXiangMima & "'", dr)
                If dr.Read() Then
                    keyId = dr("Key_ID")
                End If
                sUpdate = "Update CunQuJianXinXi Set QuJianShiJian = '" & Now & "', " & _
                                                    "ShouJianRen = '本人' " & _
                                              "Where BaoCunXiangHao = " & struInputInfo.SelWuXiangNo & " And " & _
                                                    "ShouJianDianHua = '" & struInputInfo.ShouJianRenTel & "' And " & _
                                                    "QuJianMiMa = '" & struInputInfo.KaiXiangMima & "'"
            Case 3      ' 寄存
                sInsert &= "'" & Now & "'," & _
                           "''," & _
                           "'" & iKaiXiangRND8 & "'," & _
                           struInputInfo.TouBiJinE & "," & _
                           0 & "," & _
                           struInputInfo.SelType & "," & _
                           "''," & _
                           "'')"
            Case 4
                If struInputInfo.ShouJianPaiJian = "收件" Then
                    ' 找到Key_ID 用做平台通讯用
                    Dim dr As SqlDataReader
                    sqlExe.GetRecordData("Select * From CunQuJianXinXi Where BaoCunXiangHao = " & struInputInfo.SelWuXiangNo & " And " & _
                                                        "QuJianMiMa = '" & struInputInfo.KaiXiangMima & "' And " & _
                                                        "JiJianDianHua = '" & struInputInfo.JiJianRenTel & "'", dr)
                    If dr.Read() Then
                        keyId = dr("Key_ID")
                    End If
                    sUpdate = "Update CunQuJianXinXi Set QuJianShiJian = '" & Now & "', " & _
                                                        "ShouJianRen = '" & struInputInfo.CardRenName & "' " & _
                                                  "Where BaoCunXiangHao = " & struInputInfo.SelWuXiangNo & " And " & _
                                                        "QuJianMiMa = '" & struInputInfo.KaiXiangMima & "' And " & _
                                                        "JiJianDianHua = '" & struInputInfo.JiJianRenTel & "'"
                Else
                    sInsert &= "'" & Now & "'," & _
                               "''," & _
                               "'" & iKaiXiangRND8 & "'," & _
                               struInputInfo.TouBiJinE & "," & _
                               0 & "," & _
                               struInputInfo.SelType & "," & _
                               "''," & _
                               "'" & struInputInfo.CardRenName & "')"
                End If
            Case 5
                sInsert &= "'" & Now & "'," & _
                           "''," & _
                           "''," & _
                           0 & "," & _
                           0 & "," & _
                           struInputInfo.SelType & "," & _
                           "'" & struInputInfo.CardRenName & "'," & _
                           "'')"

        End Select
        If sUpdate <> "" Then
            sqlExe.AddUpdateDelOpe(sUpdate)
        ElseIf sInsert <> "" Then
            sqlExe.AddUpdateDelOpe(sInsert)
        End If

        If struInputInfo.SelType = 1 _
            Or struInputInfo.SelType = 2 _
            Or struInputInfo.SelType = 3 _
            Or struInputInfo.SelType = 4 Then
            TransactionSync(keyId, struStoreBoxPeiZhi.StroeBoxID)
        End If

    End Function


    Public WriteOnly Property SetStoreBoxNumberState() As String
        Set(ByVal value As String)
            Timer_Ctrl_Wait.Stop()
            If value = "1" Then
                SaveStoreBoxOpenState(struInputInfo.StoreBoxGroupNo, struInputInfo.StoreBoxNo)
                bChkStoreBoxOpenState = True
            Else
                sErrInfo = "第" & struInputInfo.StoreBoxGroupNo & "组第" & struInputInfo.StoreBoxNo & "号控制器故障！"
            End If
            FrmMain.SetCtrlStartStop = True
        End Set
    End Property

    Public WriteOnly Property SetStoreBoxState() As Integer
        Set(ByVal value As Integer)
            With StruStoreBoxGroup(value).Lbl_BoxNumber(struInputInfo.StoreBoxNo - 1)
                If .bRed = 0 Then
                    bChkStoreBoxCloseState = True
                End If
            End With
        End Set
    End Property


    Private Sub SaveStoreBoxOpenState(ByVal iStoreBoxNumber As Integer, ByVal iStoreBoxNo As Integer)
        Dim sSQL As String
        Dim sHead, sEnd, sSet As String
        Dim iSetIndex, iByteIndex As Integer

        Select Case iStoreBoxNo
            Case 1 To 4
                iSetIndex = 2
                iByteIndex = iStoreBoxNo - 1
            Case 5 To 8
                iSetIndex = 1
                iByteIndex = iStoreBoxNo - 5
            Case 9 To 12
                iSetIndex = 4
                iByteIndex = iStoreBoxNo - 9
            Case 13 To 16
                iSetIndex = 3
                iByteIndex = iStoreBoxNo - 13
            Case 17 To 20
                iSetIndex = 6
                iByteIndex = iStoreBoxNo - 17
        End Select
        sHead = Strings.Left(sStoreBoxState(iStoreBoxNumber - 1), iSetIndex - 1)
        sEnd = Mid(sStoreBoxState(iStoreBoxNumber - 1), iSetIndex + 1)
        sSet = Mid(sStoreBoxState(iStoreBoxNumber - 1), iSetIndex, 1)
        sSet = Hex(CLng("&H" & sSet) Or 2 ^ iByteIndex)
        sStoreBoxState(iStoreBoxNumber - 1) = sHead & sSet & sEnd

        With StruStoreBoxGroup(iStoreBoxNumber - 1).Lbl_BoxNumber(iStoreBoxNo - 1)
            .bRed = 1
            .bRedDispFlag = True
            .Lbl_Red.ForeColor = Color.Silver
            sSQL = "Update WuXiangZhuangTai " & _
                          "Set KaiGuanZhuangTai = 1" & _
                       " Where GroupNo = " & iStoreBoxNumber & " And BianHao = " & iStoreBoxNo
            sqlExe.AddUpdateDelOpe(sSQL)
        End With

    End Sub
End Class