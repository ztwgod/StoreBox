Public Class Frm_KuaiDiYuanYeWuXuanZe
    Dim iCount As Integer = 30


    Private Sub Frm_KuaiDiYuanYeWuXuanZe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Btn_Prev, Nothing, Lbl_Timer, Lab_daojishi, Lbl_S, Nothing)
        SetCommonInfo(Me)
        Btn_ShouJian.Focus()
        Lab_daojishi.Text = iCount
        Lab_daojishi.Left = 45
        Lab_daojishi.Top = 1
    End Sub

    Private Sub Timer_DaoJiShi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DaoJiShi.Tick
        iCount -= 1
        Lab_daojishi.Text = iCount
        If iCount = 0 Then
            Frm_ShouYe.Show()
            Me.Close()
        End If
    End Sub


    Private Sub Btn_ShouJian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ShouJian.Click
        struInputInfo.ShouJianPaiJian = "收件"
        Frm_KaiXiangYeWuXuanZe.Show()
        Me.Close()
    End Sub

    Private Sub Btn_PaiJian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_PaiJian.Click
        '选择快递派件，弹出返回空箱页标识
        struInputInfo.ShouJianPaiJian = "派件"
        Frm_XuanZeWuXiang.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Prev.Click
        Frm_YeWuBanLi.Show()
        Me.Close()
    End Sub
End Class