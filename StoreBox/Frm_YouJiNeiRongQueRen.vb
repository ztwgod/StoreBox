Public Class Frm_YouJiNeiRongQueRen
    Dim iCount As Integer = 30

    Private Sub Frm_YouJiNeiRongQueRen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Nothing, Nothing, Lbl_Timer, Lab_DaoJiShi, lbl_S, Nothing)
        SetCommonInfo(Me)
        With struInputInfo
            TxtB_ShouJianRenShouJi.Text = .ShouJianRenTel
            TxtB_JiJianRenShouJi.Text = .JiJianRenTel
            TxtB_KuaiDiDanHao.Text = .SaoMiaoDanHao
        End With
        If TxtB_ShouJianRenShouJi.Text = "" Then
            TxtB_ShouJianRenShouJi.Visible = False
            Lbl_Shoujian.Visible = False
        End If
        If TxtB_KuaiDiDanHao.Text = "" Then
            TxtB_KuaiDiDanHao.Visible = False
            Lbl_KuaiDi.Visible = False
        End If
        If TxtB_JiJianRenShouJi.Text = "" Then
            TxtB_JiJianRenShouJi.Visible = False
            Lbl_JiJian.Visible = False
        End If
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

    Private Sub Btn_ShangYiBu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ShangYiBu.Click
        Select Case struInputInfo.SelType
            Case 3
                Frm_JiJianRenShouJi.Show()
            Case Else
                Frm_KuaiDiDanSaoMiao.Show()
        End Select
        Me.Close()
    End Sub

    Private Sub Btn_XiaYiBu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_XiaYiBu.Click
        Select Case struInputInfo.SelType
            Case 1
                struInputInfo.TouBiJinE = 5
                Frm_AllFuFeiTouBiTiShi.Show()
            Case 3
                struInputInfo.TouBiJinE = 2
                Frm_AllFuFeiTouBiTiShi.Show()
            Case 4
                Frm_WuXiangQueRen.Show()
            Case Else
                struInputInfo.TouBiJinE = 5
                Frm_AllFuFeiTouBiTiShi.Show()
        End Select
        Me.Close()
    End Sub
End Class