Public Class Frm_ShuaKaKaiXiangQueRenShenFen
    Dim iCount As Integer = 60


    Private Sub Frm_ShuaKaKaiXiangQueRenShenFen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Btn_Prev, Nothing, Nothing, Nothing, Nothing, Nothing)
        SetCommonInfo(Me)
        lab_daojishi.Text = iCount
        struInputInfo.sICCardNo = ""
        struInputInfo.KuaidiId = ""
        bStartReceive(5) = True
        lab_daojishi.Left = 45
        lab_daojishi.Top = 1
        lab_daojishi.Width = 70
    End Sub

    Private Sub Timer_DaoJiShi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DaoJiShi.Tick
        iCount -= 1
        lab_daojishi.Text = iCount
        If iCount = 0 Then
            Frm_ShouYe.Show()
            Me.Close()
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '临时用    收件刷卡成功后进行开箱操作
        Frm_WuXiangQueRen.Show()
        Me.Close()
    End Sub


    Private Sub Btn_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Prev.Click
        '返回上一级
        Frm_KuaiDiYuanYeWuXuanZe.Show()
        Me.Close()
    End Sub


    Public WriteOnly Property SetReaderNo() As String
        Set(ByVal value As String)
            If value <> "" Then
                Dim kuaidiId As String = ""
                If chkICCard(value, kuaidiId) Then
                    struInputInfo.sICCardNo = value
                    struInputInfo.KuaidiId = kuaidiId
                    bStartReceive(5) = False
                    Frm_WuXiangQueRen.Show()
                    Me.Close()
                End If
            End If
        End Set
    End Property
End Class