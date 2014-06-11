Public Class Frm_JiJianRenShouJi
    Dim iCount As Integer = 30


    Private Sub Frm_JiJianRenShouJi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Nothing, Nothing, Nothing, Nothing, Nothing, Lbl_TiShi)
        SetCommonInfo(Me)
        TxtB_ShouJiHao.Text = struInputInfo.JiJianRenTel
        TxtB_ShouJiHao.Focus()
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


    Private Sub Btn_1_Click(ByVal sender As System.Object, _
                              ByVal e As System.EventArgs) _
                              Handles Btn_1.Click, _
                                      Btn_2.Click, _
                                      Btn_3.Click, _
                                      Btn_4.Click, _
                                      Btn_5.Click, _
                                      Btn_6.Click, _
                                      Btn_7.Click, _
                                      Btn_8.Click, _
                                      Btn_9.Click, _
                                      Btn_0.Click, _
                                      Btn_BK.Click
        SetTelInfo(Mid(CType(sender, Button).Name, 5), TxtB_ShouJiHao)
    End Sub

    Private Sub Btn_ShangYiBu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ShangYiBu.Click
        Frm_ShouJianRenShouJi.Show()
        Me.Close()
    End Sub


    Private Sub Btn_XiaYiBu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_XiaYiBu.Click
        Dim sRet As String = ChkTel(Trim(TxtB_ShouJiHao.Text))
        If sRet = "" Then
            struInputInfo.JiJianRenTel = TxtB_ShouJiHao.Text
            If struInputInfo.SelType = 3 Then
                Frm_YouJiNeiRongQueRen.Show()
            Else
                Frm_KuaiDiDanSaoMiao.Show()
            End If
            Me.Close()
        Else
            MessageBox.Show(sRet, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtB_ShouJiHao.Focus()
        End If
    End Sub

    Private Sub TxtB_ShouJiHao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtB_ShouJiHao.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Dim sRet As String = ChkTel(Trim(TxtB_ShouJiHao.Text))
            If sRet = "" Then
                struInputInfo.JiJianRenTel = TxtB_ShouJiHao.Text
                If struInputInfo.SelType = 3 Then
                    Frm_YouJiNeiRongQueRen.Show()
                Else
                    Frm_KuaiDiDanSaoMiao.Show()
                End If
                Me.Close()
            Else
                MessageBox.Show(sRet, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtB_ShouJiHao.Focus()
            End If
        End If
    End Sub
End Class