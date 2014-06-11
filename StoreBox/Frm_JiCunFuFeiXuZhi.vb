Public Class Frm_JiCunFuFeiXuZhi
    Dim iCount As Integer = 30

    Private Sub Frm_JiCunFuFeiXuZhi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Nothing, Nothing, Lbl_Timer, Lab_DaoJiShi, lbl_S, Nothing)
        SetCommonInfo(Me)
        Lab_DaoJiShi.Text = iCount
        Lab_DaoJiShi.Left = 45
        Lab_DaoJiShi.Top = 1
        Label3.Text = struInputInfo.TouBiJinE & "元"
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



    Private Sub Btn_QuXiaoJiCun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_QuXiaoJiCun.Click
        Frm_YeWuBanLi.Show()
        Me.Close()
    End Sub
End Class