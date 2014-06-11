Public Class Frm_KuaiDiDanSaoMiao
    Dim iCount As Integer = 30

    Private Sub Frm_KuaiDiDanSaoMiao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Nothing, Nothing, Lbl_Timer, Lab_DaoJiShi, lbl_s, Nothing)
        SetCommonInfo(Me)
        TxtB_KuaiDiDanHao.Text = struInputInfo.SaoMiaoDanHao
        Lab_DaoJiShi.Text = iCount
        '不知是何用
        bStartReceive(0) = True
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


    Private Sub Btn_ShangYiBu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frm_JiJianRenShouJi.Show()
        Me.Close()
    End Sub


    Private Sub Btn_XiaYiBu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_XiaYiBu.Click
        If TxtB_KuaiDiDanHao.Text <> "" Then
            '不知是何用
            bStartReceive(0) = False
            struInputInfo.SaoMiaoDanHao = TxtB_KuaiDiDanHao.Text
            Frm_YouJiNeiRongQueRen.Show()
            Me.Close()
        Else
            MessageBox.Show("请扫描快递单或手工输入快递单号！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub


    Private Sub Btn_ShouGongShuRu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ShouGongShuRu.Click
        Frm_KuaiDiDanHaoShuRu.Show()
        Me.Close()
    End Sub

    Public WriteOnly Property SetSymbol() As String
        Set(ByVal value As String)
            If value <> "" Then
                TxtB_KuaiDiDanHao.Text = value
            End If
        End Set
    End Property

    Private Sub Btn_ShangYiBu_Click_1(sender As Object, e As EventArgs) Handles Btn_ShangYiBu.Click
        Frm_JiJianRenShouJi.Show()
        Me.Close()
    End Sub
End Class