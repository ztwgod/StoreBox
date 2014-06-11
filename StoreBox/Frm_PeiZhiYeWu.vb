Public Class Frm_PeiZhiYeWu
    Dim iCount As Integer = 30
    Dim curTextBox As TextBox

    Private Sub Frm_MiMaShuRu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, btn_prev, Nothing, Lbl_Timer, Lab_DaoJiShi, Lbl_S, Label1)
        SetCommonInfo(Me)
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

    Private Sub PicB_ShanChu_ID_Click(ByVal sender As System.Object, _
                                      ByVal e As System.EventArgs)

        '删除光标左边的字符
        DelTelInfo(curTextBox)
        iCount = 30
    End Sub


    Private Sub Btn_QueDing_Click(ByVal sender As System.Object, _
                                 ByVal e As System.EventArgs) _
                                 Handles _
                                         Btn_QueDing.Click
        Dim sSQL As String

        If CType(sender, Button).Name = "Btn_QueDing" Then
            If Txt_Tel.Text.Trim = "" Then
                MessageBox.Show("紧急服务电话不能为空！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Txt_Tel.Focus()
                Exit Sub
            End If
            sSQL = "Update PeiZhi " & _
                      "Set Tel = '" & Txt_Tel.Text & "'"
            sqlExe.AddUpdateDelOpe(sSQL)
            With struStoreBoxPeiZhi
                .Tel = Txt_Tel.Text
            End With
            struStoreBoxPeiZhi.Tel = Txt_Tel.Text
        End If
        Frm_ShouYe.Show()
        Me.Close()
    End Sub


    Private Sub Btn_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prev.Click
        Frm_GuanLiYuanYeWuXuanZe.Show()
        Me.Close()
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
        SetTelInfo(Mid(CType(sender, Button).Name, 5), Txt_Tel)
    End Sub
End Class