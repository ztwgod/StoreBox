Public Class Frm_KuaiDiDanHaoShuRu
    Dim iCount As Integer = 30

    Private Sub Frm_KuaiDiDanHaoShuRu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Nothing, Nothing, Lbl_Timer, Lab_DaoJiShi, lbl_S, lbl_TiShi)
        SetCommonInfo(Me)
        TxtB_KuaiDiDanHao.Text = struInputInfo.SaoMiaoDanHao
        Lab_DaoJiShi.Text = iCount
        Pnl_JianPan.Visible = True
        Lab_DaoJiShi.Left = 45
        Lab_DaoJiShi.Top = 1
    End Sub

    Private Sub Timer_DaoJiShi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DaoJiShi.Tick
        iCount -= 1
        Lab_DaoJiShi.Text = iCount
        If iCount = 0 Then
            Frm_KuaiDiDanSaoMiao.Show()
            Me.Close()
        End If
    End Sub



    Private Sub Btn_QuXiao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_QuXiao.Click
        Frm_KuaiDiDanSaoMiao.Show()
        Me.Close()
    End Sub

    Private Sub Btn_QueRen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_QueRen.Click
        struInputInfo.SaoMiaoDanHao = TxtB_KuaiDiDanHao.Text
        Frm_KuaiDiDanSaoMiao.Show()
        Me.Close()
    End Sub



    Private Sub Btn_1_Click(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) _
                            Handles Btn_1.Click, Btn_2.Click, Btn_3.Click, Btn_4.Click, Btn_5.Click, _
                                    Btn_6.Click, Btn_7.Click, Btn_8.Click, Btn_9.Click, Btn_0.Click, _
                                    Btn_BK.Click, _
                                    Btn_A.Click, Btn_B.Click, Btn_C.Click, Btn_D.Click, Btn_E.Click, _
                                    Btn_F.Click, Btn_G.Click, Btn_H.Click, Btn_I.Click, Btn_J.Click, _
                                    Btn_K.Click, Btn_L.Click, Btn_M.Click, Btn_N.Click, Btn_O.Click, _
                                    Btn_P.Click, Btn_Q.Click, Btn_R.Click, Btn_S.Click, Btn_T.Click, _
                                    Btn_U.Click, Btn_V.Click, Btn_W.Click, Btn_X.Click, Btn_Y.Click, _
                                    Btn_Z.Click
        SetTelInfo(Mid(CType(sender, Button).Name, 5), TxtB_KuaiDiDanHao)
    End Sub



End Class