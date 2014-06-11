Public Class Frm_AllFuFeiTouBi
    Dim iCount As Integer = 120


    Private Sub Frm_AllYuQiFuFeiTouBi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        SetCommonInfo(Me)
        Lab_DaoJiShi.Left = 45
        Lab_DaoJiShi.Top = 1
        Lab_FuKuan.Text = 0
        Lbl_SumE.Text = struInputInfo.TouBiJinE & " 元"
        Lab_DaoJiShi.Text = iCount
        bStartReceive(4) = True
    End Sub

    Private Sub Timer_DaoJiShi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DaoJiShi.Tick
        iCount -= 1
        Lab_DaoJiShi.Text = iCount
        If iCount = 0 Then
            'Timer_DaoJiShi.Stop()
            'MessageBox.Show("操作超时，投币失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'bStartReceive(4) = False
            'With struInputInfo
            'WriteRiZhi("投币超时", .ShouJianRenTel, .JiJianRenTel, .SelWuXiangNo, "已投币" & Lab_FuKuan.Text)
            'End With
            Me.Close()
            Frm_ShouYe.Show()
        End If
    End Sub


    Public WriteOnly Property SetCoin() As Boolean
        Set(ByVal value As Boolean)
            If value Then
                Lab_FuKuan.Text = Int32.Parse(Lab_FuKuan.Text) + 1
                If Lab_FuKuan.Text >= struInputInfo.TouBiJinE Then
                    struInputInfo.FuFeiE = Lab_FuKuan.Text
                    '不知何用
                    bStartReceive(4) = False
                    Frm_WuXiangQueRen.Show()
                    Me.Close()
                End If
            End If
        End Set
    End Property



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SetCoin = True
    End Sub

    Private Sub Btn_QuXiao_Click(sender As Object, e As EventArgs) Handles Btn_QuXiao.Click
        Frm_AllFuFeiTouBiTiShi.Show()
        Me.Close()
    End Sub
End Class