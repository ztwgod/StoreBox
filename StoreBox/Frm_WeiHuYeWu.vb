
Public Class Frm_WeiHuYeWu
    Private iCount As Integer = 100

    Private Sub Frm_WeiHuYeWuXuanZe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Nothing, Nothing, Lbl_Timer, Lab_DaoJiShi, lbl_S, Nothing)
        SetCommonInfo(Me)
        Dim number As Integer = Int32.Parse(sSelKaiXiangNo)
        If sSelKaiXiangNo < 9 Then
            Lbl_StoreBoxNo1.Text = "0"
            Lbl_StoreBoxNo2.Text = Strings.Right(sSelKaiXiangNo, 1)
        Else
            Lbl_StoreBoxNo1.Text = Strings.Left(sSelKaiXiangNo, 1)
            Lbl_StoreBoxNo2.Text = Strings.Right(sSelKaiXiangNo, 1)
        End If
        Lab_DaoJiShi.Left = 45
        Lab_DaoJiShi.Top = 1
        Select Case SelStoreBoxNoLabel.BackColor
            Case Color.White
                Btn_JinYong.Enabled = True
                Btn_QiYong.Enabled = False
                Btn_KaiXiang.Enabled = True
            Case Color.Gold
                Btn_JinYong.Enabled = False
                Btn_QiYong.Enabled = True
                Btn_KaiXiang.Enabled = False
        End Select
        Lab_DaoJiShi.Text = iCount
    End Sub

    Private Sub Timer_DaoJiShi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DaoJiShi.Tick
        iCount -= 1
        Lab_DaoJiShi.Text = iCount
        If iCount = 0 Then
            Frm_ShouYe.Show()
            Me.Close()
            Frm_WeiHuYeWuXuanZe.Close()
        End If
    End Sub


    Private Sub Btn_JinYong_Click(ByVal sender As System.Object, _
                                  ByVal e As System.EventArgs) _
                                  Handles Btn_JinYong.Click, _
                                          Btn_KaiXiang.Click, _
                                          Btn_QiYong.Click
        Select Case CType(sender, Button).Name
            Case "Btn_JinYong"
                sSetStoreBoxState = "禁用"
                UpdateStoreBoxState(sSelKaiXiangNo, 1)
                With struInputInfo
                    WriteRiZhi("管理员操作", .CardRenName, .sICCardNo, .SelWuXiangNo, "禁用！")
                End With
                With struInputInfo
                    .SelWuXiangNo = sSelKaiXiangNo
                    .StoreBoxGroupNo = Int((.SelWuXiangNo - 1) / 20) + 1
                    .StoreBoxNo = .SelWuXiangNo - (.StoreBoxGroupNo - 1) * 20
                End With
                With StruStoreBoxGroup(struInputInfo.StoreBoxGroupNo - 1).Lbl_BoxNumber(struInputInfo.StoreBoxNo - 1)
                    .bYellow = 1
                End With
                Me.Close()
                Frm_WeiHuYeWuXuanZe.Focus()
            Case "Btn_QiYong"
                UpdateStoreBoxState(sSelKaiXiangNo, 0)
                With struInputInfo
                    WriteRiZhi("管理员操作", .CardRenName, .sICCardNo, .SelWuXiangNo, "启用！")
                End With
                With struInputInfo
                    .SelWuXiangNo = sSelKaiXiangNo
                    .StoreBoxGroupNo = Int((.SelWuXiangNo - 1) / 20) + 1
                    .StoreBoxNo = .SelWuXiangNo - (.StoreBoxGroupNo - 1) * 20
                End With
                With StruStoreBoxGroup(struInputInfo.StoreBoxGroupNo - 1).Lbl_BoxNumber(struInputInfo.StoreBoxNo - 1)
                    .bYellow = 0
                End With
                sSetStoreBoxState = "启用"
                Frm_WeiHuYeWuXuanZe.Focus()
                Me.Close()
            Case "Btn_KaiXiang"
                With struInputInfo
                    WriteRiZhi("管理员操作", .CardRenName, .sICCardNo, .SelWuXiangNo, "开箱！")
                End With
                sSetStoreBoxState = "开箱"
                With struInputInfo
                    .SelWuXiangNo = sSelKaiXiangNo
                    .StoreBoxGroupNo = Int((.SelWuXiangNo - 1) / 20) + 1
                    .StoreBoxNo = .SelWuXiangNo - (.StoreBoxGroupNo - 1) * 20
                End With
                Frm_WuXiangQueRen.ShowDialog()
        End Select
    End Sub


    Private Sub UpdateStoreBoxState(ByVal iStoreBoxNo As Integer, _
                                    ByVal iState As Integer)
        Dim iGroupNo As Integer = Int((iStoreBoxNo - 1) / 20) + 1
        Dim iCurStoreBoxNo As Integer = iStoreBoxNo - (iGroupNo - 1) * 20
        Dim sSQL As String

        sSQL = "Update WuXiangZhuangTai " & _
                  "Set ZhengChangZhuangTai = " & iState & _
               " Where GroupNo = " & iGroupNo & " And BianHao = " & iCurStoreBoxNo
        sqlExe.AddUpdateDelOpe(sSQL)
        With StruStoreBoxGroupGuZhang(iGroupNo - 1).Lbl_BoxNumber(iCurStoreBoxNo - 1)
            .bYellow = iState
        End With
    End Sub
End Class