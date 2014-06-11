Public Class Frm_XuanZeWuXiang
    Dim iCount As Integer = 20

    Private Sub Frm_XuanZeWuXiang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Btn_Prev, Nothing, Lbl_Timer, Lab_daojishi, Lbl_S, Lbl_TiShi)
        SetCommonInfo(Me)
        GetNullCount()
        Lbl_DaShu.Text = iNullStoreBoxNoCount(2)
        Lbl_ZhongShu.Text = iNullStoreBoxNoCount(1)
        Lbl_XiaoShu.Text = iNullStoreBoxNoCount(0)

        Btn_DaXiang.Enabled = Int32.Parse(Lbl_DaShu.Text) > 0
        Btn_ZhongXiang.Enabled = Int32.Parse(Lbl_ZhongShu.Text) > 0
        Btn_XiaoXiang.Enabled = Int32.Parse(Lbl_XiaoShu.Text) > 0


        If Not (Btn_DaXiang.Enabled OrElse Btn_ZhongXiang.Enabled OrElse Btn_XiaoXiang.Enabled) Then
            WriteRiZhi("提示", "", "", "", "满箱！")
        End If
        Lab_daojishi.Text = iCount
        Lab_daojishi.Left = 45
        Lab_daojishi.Top = 1

    End Sub

    Private Sub Timer_DaoJiShi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DaoJiShi.Tick
        iCount -= 1
        Lab_daojishi.Text = iCount
        If iCount = 0 Then
            Frm_ShouYe.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Btn_DaXiang_Click(ByVal sender As System.Object, _
                                  ByVal e As System.EventArgs) _
                                  Handles Btn_DaXiang.Click, _
                                          Btn_ZhongXiang.Click, _
                                          Btn_XiaoXiang.Click
        With struInputInfo
            Select Case CType(sender, Panel).Name
                Case "Btn_DaXiang"
                    .SelWuXiangDaXiao = 2
                    .SelWuXiangNo = iNullStoreBoxNo(2, 0)
                Case "Btn_ZhongXiang"
                    .SelWuXiangDaXiao = 1
                    .SelWuXiangNo = iNullStoreBoxNo(1, 0)
                Case "Btn_XiaoXiang"
                    .SelWuXiangDaXiao = 0
                    .SelWuXiangNo = iNullStoreBoxNo(0, 0)
            End Select
            .StoreBoxGroupNo = Int((.SelWuXiangNo - 1) / 20) + 1
            .StoreBoxNo = .SelWuXiangNo - (.StoreBoxGroupNo - 1) * 20
            .ShouJianRenTel = ""
            .JiJianRenTel = ""
            .KuaiDiDanHao = ""
            .SaoMiaoDanHao = ""

            Select Case .SelType
                Case 1
                    Frm_KuaiDiGongSiXuanZe.Show()
                Case 3
                    Frm_ShouJianRenShouJi.Show()
                Case 4
                    Frm_ShouJianRenShouJi.Show()
            End Select
            Me.Close()
        End With

    End Sub


    Private Sub Btn_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Prev.Click
        Frm_YeWuBanLi.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, _
                                          Label3.Click, _
                                          Label4.Click
        With struInputInfo
            Select Case CType(sender, Label).Name
                Case "Label2"
                    .SelWuXiangDaXiao = 2
                    .SelWuXiangNo = iNullStoreBoxNo(2, 0)
                Case "Label3"
                    .SelWuXiangDaXiao = 1
                    .SelWuXiangNo = iNullStoreBoxNo(1, 0)
                Case "Label4"
                    .SelWuXiangDaXiao = 0
                    .SelWuXiangNo = iNullStoreBoxNo(0, 0)
            End Select
            .StoreBoxGroupNo = Int((.SelWuXiangNo - 1) / 20) + 1
            .StoreBoxNo = .SelWuXiangNo - (.StoreBoxGroupNo - 1) * 20
            .ShouJianRenTel = ""
            .JiJianRenTel = ""
            .KuaiDiDanHao = ""
            .SaoMiaoDanHao = ""

            Select Case .SelType
                Case 1
                    Frm_KuaiDiGongSiXuanZe.Show()
                Case 3
                    Frm_ShouJianRenShouJi.Show()
                Case 4
                    Frm_ShouJianRenShouJi.Show()
            End Select
            Me.Close()
        End With

    End Sub
End Class