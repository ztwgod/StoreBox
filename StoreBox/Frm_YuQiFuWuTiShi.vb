Public Class Frm_YuQiFuWuTiShi
    Dim iCount As Integer = 60


    Private Sub Frm_YuQiFuWuTiShi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Btn_Prev, Nothing, Lbl_Timer, Lab_DaoJiShi, Lbl_S, Nothing)
        SetCommonInfo(Me)
        Lbl_JinE.Text = struInputInfo.TouBiJinE
        Btn_QuXiao.Focus()
        Lab_DaoJiShi.Text = iCount
        Lab_DaoJiShi.Left = 45
        Lab_DaoJiShi.Top = 1
    End Sub

    Private Sub Timer_DaoJiShi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DaoJiShi.Tick
        iCount -= 1
        Lab_DaoJiShi.Text = iCount
        If iCount = 0 Then
            Frm_ShouYe.Show()
            Me.Close()
        End If
    End Sub



    Private Sub Btn_WoYaoFuFei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_WoYaoFuFei.Click
        Frm_AllFuFeiTouBiTiShi.Show()
        Me.Close()
    End Sub

    Private Sub Btn_QuXiao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_QuXiao.Click
        Frm_ShouYe.Show()
        Me.Close()
    End Sub
End Class