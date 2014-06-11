Public Class Frm_MiMaShuRu
    Dim iCount As Integer = 30
    Dim iInputCount As Integer = 0


    Private Sub Frm_MiMaShuRu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Btn_Prev, Nothing, Lbl_Timer, Lab_DaoJiShi, Lbl_S, Nothing)
        SetCommonInfo(Me)
        With struInputInfo
            .CardRenName = ""
            .InputMiMa = ""
        End With
        TxtB_Mima.Text = ""
        TxtB_Mima.Focus()
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


    Private Sub Btn_QueDing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_queding.Click
        '增加判断密码是否输入正确，连续输入5次错误密码返回待机界面
        Dim sRetName As String = ""

        If TxtB_Mima.Text <> "" Then
            sRetName = chkMiMa(TxtB_Mima.Text)
        End If
        If sRetName <> "" Then
            With struInputInfo
                .CardRenName = sRetName
                .InputMiMa = TxtB_Mima.Text
            End With
            If struInputInfo.SelType = 4 Then
                Frm_KuaiDiYuanYeWuXuanZe.Show()
            ElseIf struInputInfo.SelType = 5 Then
                Frm_GuanLiYuanYeWuXuanZe.Show()
            End If
            Me.Close()
        Else
            iInputCount += 1
            If iInputCount = 5 Then
                Frm_ShouYe.Show()
                Me.Close()
            End If
            TxtB_Mima.Text = ""
        End If
    End Sub

    Private Sub Btn_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Prev.Click
        Frm_ShuaKaQueRenShenFen.Show()
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
        SetTelInfo(Mid(CType(sender, Button).Name, 5), TxtB_Mima)
    End Sub

    Private Sub TxtB_Mima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtB_Mima.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Dim sRetName As String = ""

            If TxtB_Mima.Text <> "" Then
                sRetName = chkMiMa(TxtB_Mima.Text)
            End If
            If sRetName <> "" Then
                With struInputInfo
                    .CardRenName = sRetName
                    .InputMiMa = TxtB_Mima.Text
                End With
                If struInputInfo.SelType = 4 Then
                    Frm_KuaiDiYuanYeWuXuanZe.Show()
                ElseIf struInputInfo.SelType = 5 Then
                    Frm_GuanLiYuanYeWuXuanZe.Show()
                End If
                Me.Close()
            Else
                iInputCount += 1
                If iInputCount = 5 Then
                    Frm_ShouYe.Show()
                    Me.Close()
                End If
                TxtB_Mima.Text = ""
            End If
        End If
    End Sub
End Class