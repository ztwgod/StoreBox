Imports System.Data.SqlClient

Public Class Frm_KaiXiangYeWuXuanZe
    Private iCount As Integer = 60
    Private StoreBoxArraylist As ArrayList


    Private Sub Frm_KaiXiangYeWuXuanZe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
        SetCommonHead(Lbl_Head, Btn_Prev, Nothing, Lbl_Timer, lab_daojishi, Lbl_S, Nothing)
        SetCommonInfo(Me)
        InitStoreBoxArraylist()
        ShouJianStateInit()
        lab_daojishi.Text = iCount
        lab_daojishi.Left = 45
        lab_daojishi.Top = 1
    End Sub

    Private Sub Timer_DaoJiShi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DaoJiShi.Tick
        iCount -= 1
        lab_daojishi.Text = iCount
        If iCount = 0 Then
            Frm_ShouYe.Show()
            Me.Close()
        End If
    End Sub


    Private Sub Btn_WanCheng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_WanCheng.Click
        '完成快递员操作，进入待机界面
        Frm_ShouYe.Show()
        Me.Close()
    End Sub
    Private Sub Lab_1_Click(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) _
                            Handles Lab_1.Click, Lab_2.Click, Lab_3.Click, Lab_4.Click, Lab_5.Click, Lab_6.Click, Lab_7.Click, Lab_8.Click, Lab_9.Click, Lab_10.Click, _
                                    Lab_11.Click, Lab_12.Click, Lab_13.Click, lab_14.Click, lab_15.Click, lab_16.Click, lab_17.Click, lab_18.Click, lab_19.Click, lab_20.Click, _
                                    lab_21.Click, lab_22.Click, lab_23.Click, lab_24.Click, lab_25.Click, lab_26.Click, lab_27.Click, lab_28.Click, lab_29.Click, lab_30.Click, _
                                    lab_31.Click, lab_32.Click, lab_33.Click, lab_34.Click, lab_35.Click, lab_36.Click, lab_37.Click, lab_38.Click, lab_39.Click, lab_40.Click, _
                                    lab_41.Click, lab_42.Click, lab_43.Click, lab_44.Click, lab_45.Click, lab_46.Click, lab_47.Click, lab_48.Click, lab_49.Click, lab_50.Click, _
                                    lab_51.Click, lab_52.Click, lab_53.Click, lab_54.Click, lab_55.Click, lab_56.Click, lab_57.Click, lab_58.Click, lab_59.Click, lab_60.Click, _
                                    lab_61.Click, lab_62.Click, lab_63.Click, lab_64.Click, lab_65.Click, lab_66.Click, lab_67.Click, lab_68.Click, lab_69.Click, lab_70.Click, _
                                    lab_71.Click, lab_72.Click, lab_73.Click, lab_74.Click, lab_75.Click, lab_76.Click, lab_77.Click, lab_78.Click, lab_79.Click, lab_80.Click
        Dim SelStoreBoxNo As Label = CType(sender, Label)
        Dim iStoreBoxNo As Integer = Int32.Parse(Mid(SelStoreBoxNo.Name, 5))

        With SelStoreBoxNo
            If .BackColor = Color.Lime Then
                sSelKaiXiangNo = .Text
                Dim sArray() As String = Split(.Tag, ",")
                With struInputInfo
                    .SelWuXiangNo = SelStoreBoxNo.Text
                    .StoreBoxGroupNo = Int((.SelWuXiangNo - 1) / 20) + 1
                    .StoreBoxNo = .SelWuXiangNo - (.StoreBoxGroupNo - 1) * 20
                    .JiJianRenTel = sArray(0)
                    .KaiXiangMima = sArray(1)
                End With
                Frm_ShuaKaKaiXiangQueRenShenFen.Show()
                Me.Close()
            End If
        End With

    End Sub

    Private Sub Btn_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Prev.Click
        Frm_KuaiDiYuanYeWuXuanZe.Show()
        Me.Close()
    End Sub



    'Private Sub Lab_1_MouseEnter(ByVal sender As Object, _
    ' ByVal e As System.EventArgs) _
    ' Handles Lab_1.MouseEnter, Lab_2.MouseEnter, Lab_3.MouseEnter, Lab_4.MouseEnter, Lab_5.MouseEnter, Lab_6.MouseEnter, Lab_7.MouseEnter, Lab_8.MouseEnter, Lab_9.MouseEnter, Lab_10.MouseEnter, _
    ' Lab_11.MouseEnter, Lab_12.MouseEnter, Lab_13.MouseEnter, lab_14.MouseEnter, lab_15.MouseEnter, lab_16.MouseEnter, lab_17.MouseEnter, lab_18.MouseEnter, lab_19.MouseEnter, lab_20.MouseEnter, _
    ' lab_21.MouseEnter, lab_22.MouseEnter, lab_23.MouseEnter, lab_24.MouseEnter, lab_25.MouseEnter, lab_26.MouseEnter, lab_27.MouseEnter, lab_28.MouseEnter, lab_28.MouseEnter, lab_29.MouseEnter, _
    ' lab_30.MouseEnter, lab_32.MouseEnter, lab_33.MouseEnter, lab_34.MouseEnter, lab_35.MouseEnter, lab_36.MouseEnter, lab_37.MouseEnter, lab_38.MouseEnter, lab_39.MouseEnter, lab_40.MouseEnter
    '  With CType(sender, Label)
    '  If .BackColor = Color.Lime Then
    '    .Cursor = Cursors.Hand
    ' Else
    '   .Cursor = Cursors.Default
    ' End If
    ' End With
    ' End Sub


    Public Sub ShouJianStateInit()
        Dim sSQL As String
        Dim datread As SqlDataReader = Nothing            '用于存放记录集
        Dim bFlag As Boolean
        Dim iStoreBox As Integer

        Try
            sSQL = "Select * From CunQuJianXinXi " & _
                                 "Where QuJianShiJian = '' And " & _
                                       "JiJianDianHua <> '' And " & _
                                       "ShouJianDianHua <> '' And " & _
                                       "YeWuLeiXing = 1 " & _
                              "Order by BaoCunXiangHao"
            bFlag = sqlExe.GetRecordData(sSQL, datread)

            While datread.Read()
                iStoreBox = datread("BaoCunXiangHao") - 1
                With CType(StoreBoxArraylist(iStoreBox), Label)
                    .Image = StoreBox.My.Resources.Resources._28_07
                    .BackColor = Color.Lime
                    .Tag = datread("JiJianDianHua").ToString & "," & datread("QuJianMiMa").ToString
                End With

            End While
            datread.Close()

            sSQL = "Select * From WuXiangZhuangTai " & _
                    "Where GroupNo <= " & struStoreBoxPeiZhi.StoreBoxSum & " And " & _
                          "ZhengChangZhuangTai = 0 And " & _
                          "KaiGuanZhuangTai = 0 And " & _
                          "YouWuZhuangTai = 1 " & _
                 "Order By DaXiaoZhuangTai, GroupNo, BianHao"
            bFlag = sqlExe.GetRecordData(sSQL, datread)

            'While datread.Read()
            'iStoreBox = (datread("GroupNo") - 1) * 20 + datread("BianHao") - 1
            'With CType(StoreBoxArraylist(iStoreBox), Label)
            '.BackColor = Color.White
            'End With
            'End While
            datread.Close()


        Catch ex As Exception
            MessageBox.Show("数据库异常，请您联系系统维护人员解决后再执行本操作！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End Try

    End Sub


    Private Sub InitStoreBoxArraylist()
        StoreBoxArraylist = New ArrayList
        StoreBoxArraylist.Add(Lab_1)
        StoreBoxArraylist.Add(Lab_2)
        StoreBoxArraylist.Add(Lab_3)
        StoreBoxArraylist.Add(Lab_4)
        StoreBoxArraylist.Add(Lab_5)
        StoreBoxArraylist.Add(Lab_6)
        StoreBoxArraylist.Add(Lab_7)
        StoreBoxArraylist.Add(Lab_8)
        StoreBoxArraylist.Add(Lab_9)
        StoreBoxArraylist.Add(Lab_10)
        StoreBoxArraylist.Add(Lab_11)
        StoreBoxArraylist.Add(Lab_12)
        StoreBoxArraylist.Add(Lab_13)
        StoreBoxArraylist.Add(lab_14)
        StoreBoxArraylist.Add(lab_15)
        StoreBoxArraylist.Add(lab_16)
        StoreBoxArraylist.Add(lab_17)
        StoreBoxArraylist.Add(lab_18)
        StoreBoxArraylist.Add(lab_19)
        StoreBoxArraylist.Add(lab_20)
        StoreBoxArraylist.Add(lab_21)
        StoreBoxArraylist.Add(lab_22)
        StoreBoxArraylist.Add(lab_23)
        StoreBoxArraylist.Add(lab_24)
        StoreBoxArraylist.Add(lab_25)
        StoreBoxArraylist.Add(lab_26)
        StoreBoxArraylist.Add(lab_27)
        StoreBoxArraylist.Add(lab_28)
        StoreBoxArraylist.Add(lab_28)
        StoreBoxArraylist.Add(lab_29)
        StoreBoxArraylist.Add(lab_30)
        StoreBoxArraylist.Add(lab_32)
        StoreBoxArraylist.Add(lab_33)
        StoreBoxArraylist.Add(lab_34)
        StoreBoxArraylist.Add(lab_35)
        StoreBoxArraylist.Add(lab_36)
        StoreBoxArraylist.Add(lab_37)
        StoreBoxArraylist.Add(lab_38)
        StoreBoxArraylist.Add(lab_39)
        StoreBoxArraylist.Add(lab_40)
        StoreBoxArraylist.Add(lab_41)
        StoreBoxArraylist.Add(lab_42)
        StoreBoxArraylist.Add(lab_43)
        StoreBoxArraylist.Add(lab_44)
        StoreBoxArraylist.Add(lab_45)
        StoreBoxArraylist.Add(lab_46)
        StoreBoxArraylist.Add(lab_47)
        StoreBoxArraylist.Add(lab_48)
        StoreBoxArraylist.Add(lab_49)
        StoreBoxArraylist.Add(lab_50)
        StoreBoxArraylist.Add(lab_51)
        StoreBoxArraylist.Add(lab_52)
        StoreBoxArraylist.Add(lab_53)
        StoreBoxArraylist.Add(lab_54)
        StoreBoxArraylist.Add(lab_55)
        StoreBoxArraylist.Add(lab_56)
        StoreBoxArraylist.Add(lab_57)
        StoreBoxArraylist.Add(lab_58)
        StoreBoxArraylist.Add(lab_59)
        StoreBoxArraylist.Add(lab_60)
        StoreBoxArraylist.Add(lab_61)
        StoreBoxArraylist.Add(lab_62)
        StoreBoxArraylist.Add(lab_63)
        StoreBoxArraylist.Add(lab_64)
        StoreBoxArraylist.Add(lab_65)
        StoreBoxArraylist.Add(lab_66)
        StoreBoxArraylist.Add(lab_67)
        StoreBoxArraylist.Add(lab_68)
        StoreBoxArraylist.Add(lab_69)
        StoreBoxArraylist.Add(lab_70)
        StoreBoxArraylist.Add(lab_71)
        StoreBoxArraylist.Add(lab_72)
        StoreBoxArraylist.Add(lab_73)
        StoreBoxArraylist.Add(lab_74)
        StoreBoxArraylist.Add(lab_75)
        StoreBoxArraylist.Add(lab_76)
        StoreBoxArraylist.Add(lab_77)
        StoreBoxArraylist.Add(lab_78)
        StoreBoxArraylist.Add(lab_79)
        StoreBoxArraylist.Add(lab_80)
    End Sub
    Private Sub Frm_KaiXiangYeWuXuanZe_shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Dim Myanel As New Panel
        Myanel.Dock = DockStyle.Fill
        Myanel.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Myanel.Controls.Add(Me.Lab_1)
        Myanel.Controls.Add(Me.Lab_2)
        Myanel.Controls.Add(Me.Lab_3)
        Myanel.Controls.Add(Me.Lab_4)
        Myanel.Controls.Add(Me.Lab_5)

        Myanel.Controls.Add(Me.Lab_6)
        Myanel.Controls.Add(Me.Lab_7)
        Myanel.Controls.Add(Me.Lab_8)
        Myanel.Controls.Add(Me.Lab_9)
        Myanel.Controls.Add(Me.Lab_10)
        Myanel.Controls.Add(Me.Lab_11)
        Myanel.Controls.Add(Me.Lab_12)
        Myanel.Controls.Add(Me.Lab_13)
        Myanel.Controls.Add(Me.lab_14)
        Myanel.Controls.Add(Me.lab_15)

        Myanel.Controls.Add(Me.lab_16)
        Myanel.Controls.Add(Me.lab_17)
        Myanel.Controls.Add(Me.lab_18)
        Myanel.Controls.Add(Me.lab_19)
        Myanel.Controls.Add(Me.lab_20)
        Myanel.Controls.Add(Me.lab_21)
        Myanel.Controls.Add(Me.lab_22)
        Myanel.Controls.Add(Me.lab_23)
        Myanel.Controls.Add(Me.lab_24)
        Myanel.Controls.Add(Me.lab_25)

        Myanel.Controls.Add(Me.lab_26)
        Myanel.Controls.Add(Me.lab_27)
        Myanel.Controls.Add(Me.lab_28)
        Myanel.Controls.Add(Me.lab_29)
        Myanel.Controls.Add(Me.lab_30)
        Myanel.Controls.Add(Me.lab_31)
        Myanel.Controls.Add(Me.lab_32)
        Myanel.Controls.Add(Me.lab_33)
        Myanel.Controls.Add(Me.lab_34)
        Myanel.Controls.Add(Me.lab_35)

        Myanel.Controls.Add(Me.lab_36)
        Myanel.Controls.Add(Me.lab_37)
        Myanel.Controls.Add(Me.lab_38)
        Myanel.Controls.Add(Me.lab_39)
        Myanel.Controls.Add(Me.lab_40)
        Myanel.Controls.Add(Me.lab_41)
        Myanel.Controls.Add(Me.lab_42)
        Myanel.Controls.Add(Me.lab_43)
        Myanel.Controls.Add(Me.lab_44)
        Myanel.Controls.Add(Me.lab_45)

        Myanel.Controls.Add(Me.lab_46)
        Myanel.Controls.Add(Me.lab_47)
        Myanel.Controls.Add(Me.lab_48)
        Myanel.Controls.Add(Me.lab_49)
        Myanel.Controls.Add(Me.lab_50)
        Myanel.Controls.Add(Me.lab_51)
        Myanel.Controls.Add(Me.lab_52)
        Myanel.Controls.Add(Me.lab_53)
        Myanel.Controls.Add(Me.lab_54)
        Myanel.Controls.Add(Me.lab_55)

        Myanel.Controls.Add(Me.lab_56)
        Myanel.Controls.Add(Me.lab_57)
        Myanel.Controls.Add(Me.lab_58)
        Myanel.Controls.Add(Me.lab_59)
        Myanel.Controls.Add(Me.lab_60)
        Myanel.Controls.Add(Me.lab_61)
        Myanel.Controls.Add(Me.lab_62)
        Myanel.Controls.Add(Me.lab_63)
        Myanel.Controls.Add(Me.lab_64)
        Myanel.Controls.Add(Me.lab_65)

        Myanel.Controls.Add(Me.lab_66)
        Myanel.Controls.Add(Me.lab_67)
        Myanel.Controls.Add(Me.lab_68)
        Myanel.Controls.Add(Me.lab_69)
        Myanel.Controls.Add(Me.lab_70)
        Myanel.Controls.Add(Me.lab_71)
        Myanel.Controls.Add(Me.lab_72)
        Myanel.Controls.Add(Me.lab_73)
        Myanel.Controls.Add(Me.lab_74)
        Myanel.Controls.Add(Me.lab_75)
        Myanel.Controls.Add(Me.lab_76)
        Myanel.Controls.Add(Me.lab_77)
        Myanel.Controls.Add(Me.lab_78)
        Myanel.Controls.Add(Me.lab_79)
        Myanel.Controls.Add(Me.lab_80)
        Me.Controls.Add(Myanel)
    End Sub
End Class