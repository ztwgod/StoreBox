Public Class Frm_YeWuBanLi

    Private iCount As Integer = 0

    Private Sub Frm_YeWuBanLi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Lbl_Head
            .Top = HUAMIANTOP
            .Left = (Screen.PrimaryScreen.Bounds.Width - .Width) / 2
        End With
        With Lbl_TiShi
            .Left = (Screen.PrimaryScreen.Bounds.Width - .Width) / 2
        End With

        SetCommonInfo(Me)
        '初始化struInput_info
        With struInputInfo
            .KuaiDi = 0
            .SelWuXiangDaXiao = -1
            .ShouJianRenTel = ""
            .SelWuXiangDaXiao = 0
            .StoreBoxGroupNo = 1
            .StoreBoxNo = 1
            .SelWuXiangNo = 0
            .SaoMiaoDanHao = ""
            .KuaiDiDanHao = ""
            .FuFeiE = 0
            .TouBiJinE = 0
            .sICCardNo = ""
            .KuaidiId = ""
            .ShouJianPaiJian = ""
            .KaiXiangMima = ""
            .InputMiMa = ""
            .CardRenName = ""
        End With

    End Sub

    Private Sub Timer_DaoJiShi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DaoJiShi.Tick
        iCount += 1
        If iCount = 20 Then
            Frm_ShouYe.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Btn_WoYaoJiJian_Click(ByVal sender As System.Object, _
                                      ByVal e As System.EventArgs) Handles _
                                      Btn_WoYaoJiJian.Click, _
                                      Btn_WoYaoJiCun.Click, _
                                      Btn_WoYaoShouJian.Click, _
                                      Btn_GuanLiYuanYeWu.Click, _
                                      Btn_KuaiDiYuanYeWu.Click
        Select Case CType(sender, Button).Name
            Case "Btn_WoYaoJiJian"
                struInputInfo.SelType = 1
                Frm_XuanZeWuXiang.Show()
            Case "Btn_WoYaoShouJian"
                struInputInfo.SelType = 2
                Frm_ShouJianRenShouJi.Show()
            Case "Btn_WoYaoJiCun"
                struInputInfo.SelType = 3
                Frm_XuanZeWuXiang.Show()
            Case "Btn_KuaiDiYuanYeWu"
                struInputInfo.SelType = 4
                Frm_ShuaKaQueRenShenFen.Show()
            Case "Btn_GuanLiYuanYeWu"
                struInputInfo.SelType = 5
                Frm_ShuaKaQueRenShenFen.Show()
        End Select
        Me.Close()

    End Sub

    Private Sub Btn_QuXiao_Click(sender As Object, e As EventArgs) Handles Btn_QuXiao.Click
        Frm_ShouYe.Show()
        Me.Close()
    End Sub
End Class