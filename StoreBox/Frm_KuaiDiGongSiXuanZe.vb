Public Class Frm_KuaiDiGongSiXuanZe
    Dim iCount As Integer = 20
    Private Sub Frm_KuaiDiGongSiXuanZe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Btn_Prev, Nothing, Nothing, Nothing, Nothing, Nothing)
        SetCommonInfo(Me)
    End Sub



    Private Sub Btn_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Prev.Click
        Frm_XuanZeWuXiang.Show()
        Me.Close()
    End Sub

    Private Sub Btn_YuanTong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_YuanTong.Click
        struInputInfo.KuaiDi = 0
        Frm_ShouJianRenShouJi.Show()
        Me.Close()
    End Sub
    Private Sub Timer_DaoJiShi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DaoJiShi.Tick
        iCount -= 1
        If iCount = 0 Then
            Frm_ShouYe.Show()
            Me.Close()
        End If
    End Sub



End Class