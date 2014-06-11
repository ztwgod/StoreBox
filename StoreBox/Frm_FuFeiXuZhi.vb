Public Class Frm_FuFeiXuZhi
    Dim iCount As Integer = 60

    Private Sub Frm_KuaiDiDanHaoShuRu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Nothing, Nothing, Lbl_Timer, Lab_DaoJiShi, lbl_S, Nothing)
        SetCommonInfo(Me)
        Lab_DaoJiShi.Left = 45
        Lab_DaoJiShi.Top = 1
        Lab_DaoJiShi.Text = iCount

    End Sub

    Private Sub Timer_DaoJiShi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DaoJiShi.Tick
        iCount -= 1
        Lab_DaoJiShi.Text = iCount
        If iCount = 0 Then
            Frm_YeWuBanLi.Show()
            Me.Close()
        End If
    End Sub


    Private Sub Btn_WoYaoFuFei_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_WoYaoFuFei.Click
        struInputInfo.TouBiJinE = 5
        Frm_AllFuFeiTouBiTiShi.Show()
        Me.Close()
    End Sub

    Private Sub Btn_QuXiaoYouJi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_QuXiaoYouJi.Click
        Frm_YeWuBanLi.Show()
        Me.Close()
    End Sub

End Class