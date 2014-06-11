Public Class Frm_AllFuFeiTouBiTiShi
    Dim iCount As Integer = 30


    Private Sub Frm_AllFuFeiTouBiTiShi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        SetCommonInfo(Me)
        Lab_DaoJiShi.Left = 45
        Lab_DaoJiShi.Top = 1
        Lbl_JinE.Text = "" & struInputInfo.TouBiJinE
        Label6.Text = struInputInfo.TouBiJinE & " 元"
        Btn_QuXiao.Focus()
        Lab_DaoJiShi.Text = iCount
    End Sub

    Private Sub Timer_DaoJiShi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DaoJiShi.Tick
        iCount -= 1
        Lab_DaoJiShi.Text = iCount
        If iCount = 0 Then
            Frm_ShouYe.Show()
            Me.Close()
        End If
    End Sub


    Private Sub Btn_TouBi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_TouBi.Click
        Frm_AllFuFeiTouBi.Show()
        Me.Close()
    End Sub

    Private Sub Btn_QuXiao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_QuXiao.Click
        Frm_ShouYe.Show()
        Me.Close()
    End Sub
End Class