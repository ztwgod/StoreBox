Public Class Frm_YeWuWanChengTiShi
    Dim iCount As Integer = 10

    Private Sub Frm_YeWuWanChengTiShi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Nothing, Nothing, Nothing, Lbl_Timer, Lab_DaoJiShi, Lbl_S, Lbl_TiShi)
        SetCommonInfo(Me)
        Lab_Daojishi.Text = iCount
        Lab_Daojishi.Left = 45
        Lab_Daojishi.Top = 1
    End Sub

    Private Sub Timer_DaoJiShi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DaoJiShi.Tick
        iCount -= 1
        Lab_DaoJiShi.Text = iCount
        If iCount = 0 Then
            Frm_ShouYe.Show()
            Me.Close()
        End If
    End Sub


    Private Sub Btn_FanHuiZhuYe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_FanHuiZhuYe.Click
        Frm_ShouYe.Show()
        Me.Close()
    End Sub
End Class