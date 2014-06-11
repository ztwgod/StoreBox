Public Class Frm_ShuaKaQueRenShenFen
    Dim iCount As Integer = 60


    Private Sub Frm_ShuaKaQueRenShenFen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Btn_Prev, Btn_FanHuiZhuYe, Nothing, Nothing, Nothing, Nothing)
        SetCommonInfo(Me)
        Lab_DaoJiShi.Text = iCount
        struInputInfo.sICCardNo = ""
        struInputInfo.KuaidiId = ""
        bStartReceive(5) = True
        Lab_DaoJiShi.Left = 45
        Lab_DaoJiShi.Width = 70
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
    Private Sub Btn_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Prev.Click
        '返回上一级
        Frm_YeWuBanLi.Show()
        Me.Close()
    End Sub
    Public WriteOnly Property SetReaderNo() As String
        Set(ByVal value As String)
            If value <> "" Then
                Dim kuaidiId As String = ""
                If chkICCard(value, kuaidiId) Then
                    struInputInfo.sICCardNo = value
                    If struInputInfo.SelType = 4 Then
                        struInputInfo.KuaidiId = kuaidiId
                    End If
                    bStartReceive(5) = False
                    Frm_MiMaShuRu.Show()
                    Me.Close()
                End If
            End If
        End Set
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '临时用      选择快递员业务后刷卡成功输入密码
        If struInputInfo.SelType = 4 Then
            struInputInfo.sICCardNo = "005055C744"
        ElseIf struInputInfo.SelType = 5 Then
            struInputInfo.sICCardNo = "0050663F94"
        End If
        Frm_MiMaShuRu.Show()
        Me.Close()
    End Sub
End Class