Public Class Frm_GuanLiYuanYeWuXuanZe
    Dim iCount As Integer = 30


    Private Sub Frm_MiMaShuRu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Btn_prev, Nothing, Lbl_Timer, Lab_DaoJiShi, Lbl_S, Nothing)
        SetCommonInfo(Me)
        Lab_DaoJiShi.Left = 45
        Lab_DaoJiShi.Top = 1
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


    Private Sub Btn_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_prev.Click
        Frm_MiMaShuRu.Show()
        Me.Close()
    End Sub

    Private Sub Btn_WeiHu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_WeiHu.Click
        sSetStoreBoxState = ""
        Frm_WeiHuYeWuXuanZe.Show()
        Me.Close()
    End Sub

    Private Sub Btn_PeiZhi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_PeiZhi.Click
        Frm_PeiZhiYeWu.Show()
        Me.Close()
    End Sub


    Private Sub btn_TongBuWuXiang_Click(sender As Object, e As EventArgs) Handles btn_TongBuWuXiang.Click
        StorageRegSync(2)
    End Sub

    Private Sub btn_GengXinKuaiDi_Click(sender As Object, e As EventArgs) Handles btn_GengXinKuaiDi.Click
        CourierSync()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
        FrmMain.Close()
    End Sub
End Class