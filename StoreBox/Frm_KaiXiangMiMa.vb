Imports System.Data.SqlClient

Public Class Frm_KaiXiangMiMa
    Dim iCount As Integer = 60
    Dim iInputCount As Integer = 0


    Private Sub Frm_KaiXiangMiMa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Btn_ShangYiBu, Nothing, Lbl_Timer, Lab_DaoJiShi, Lbl_S, Nothing)
        SetCommonInfo(Me)
        TxtB_MiMa.Text = ""
        Lab_DaoJiShi.Text = iCount
        Btn_QueRen.Enabled = False
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


    Private Sub Btn_QueRen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_QueRen.Click
        '增加判断密码是否输入正确，连续输入5次错误密码返回待机界面
        Dim iRetYuQiE As Integer

        sSelKaiXiangNo = ""
        If TxtB_MiMa.Text <> "" Then
            '比较开箱手机及密码并取出箱号
            sSelKaiXiangNo = ReadKaiXiangNo(TxtB_MiMa.Text, iRetYuQiE)
        End If
        If sSelKaiXiangNo <> "" Then
            With struInputInfo
                If .SelType = 2 Then
                    .SelWuXiangNo = sSelKaiXiangNo
                    .StoreBoxGroupNo = Int((.SelWuXiangNo - 1) / 20) + 1
                    .StoreBoxNo = .SelWuXiangNo - (.StoreBoxGroupNo - 1) * 20
                    .KaiXiangMima = TxtB_MiMa.Text
                    If iRetYuQiE = 0 Then
                        .TouBiJinE = 0
                        Frm_WuXiangQueRen.Show()
                    Else
                        .TouBiJinE = iRetYuQiE
                        Frm_YuQiFuWuTiShi.Show()
                    End If
                    Me.Close()
                End If
            End With
        Else
            iInputCount += 1
            'If iInputCount = 5 Then
            'sqlExe.AddUpdateDelOpe("Delete From XianZhi Where Tel ='" & struInputInfo.ShouJianRenTel & "'")
            'sqlExe.AddUpdateDelOpe("Insert Into XianZhi " & _
            '"Values ( '" & struInputInfo.ShouJianRenTel & "'," & _
            ' "'" & Now & "')")
            Frm_KaiXiangBaoQianTiShi.Show()
            Me.Close()
        End If
        TxtB_MiMa.Text = ""
    End Sub

    Private Sub Btn_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ShangYiBu.Click
        Frm_ShouJianRenShouJi.Show()
        Me.Close()
    End Sub



    Private Function ReadKaiXiangNo(ByVal schkMiMa As String, ByRef iYuQiFei As Integer) As String
        Dim sSQL As String
        Dim datread As SqlDataReader = Nothing            '用于存放记录集
        Dim bFlag As Boolean
        Dim iSum As Long
        Try
            ReadKaiXiangNo = ""
            iYuQiFei = 0
            sSQL = "Select * From CunQuJianXinXi " & _
                          " Where ShouJianDianHua = '" & struInputInfo.ShouJianRenTel & "' And " & _
                                 "QuJianMiMa = '" & schkMiMa & "' And " & _
                                 "Year(QuJianShiJian) = 1900"
            bFlag = sqlExe.GetRecordData(sSQL, datread)
            If datread.Read() Then
                ReadKaiXiangNo = datread("BaoCunXiangHao").ToString.Trim
                If ReadKaiXiangNo.Length = 1 Then ReadKaiXiangNo = "0" & ReadKaiXiangNo
                iSum = DateDiff("N", datread("BaoCunShiJian").ToString, Format(Now, "yyyy-MM-dd hh:mm:ss"))
                If iSum <= 6 * 60 Then
                    iYuQiFei = 0
                ElseIf iSum <= 7 * 60 Then
                    iYuQiFei = 1
                ElseIf iSum <= 8 * 60 Then
                    iYuQiFei = 2
                ElseIf iSum <= 9 * 60 Then
                    iYuQiFei = 3
                ElseIf iSum <= 10 * 60 Then
                    iYuQiFei = 4
                ElseIf iSum <= 11 * 60 Then
                    iYuQiFei = 5
                ElseIf iSum <= 12 * 60 Then
                    iYuQiFei = 6
                ElseIf iSum <= 13 * 60 Then
                    iYuQiFei = 7
                ElseIf iSum <= 14 * 60 Then
                    iYuQiFei = 8
                ElseIf iSum <= 15 * 60 Then
                    iYuQiFei = 9
                Else
                    iYuQiFei = 10
                End If
            End If
            datread.Close()

        Catch ex As Exception
            MessageBox.Show("数据库异常，请您联系系统维护人员解决后再执行本操作！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End Try

    End Function


    Private Sub Frm_KaiXiangMiMa_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TxtB_MiMa.Focus()
    End Sub


    Private Sub TxtB_MiMa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtB_MiMa.TextChanged
        With TxtB_MiMa
            Btn_QueRen.Enabled = .Text.Length = .MaxLength
        End With
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
        SetTelInfo(Mid(CType(sender, Button).Name, 5), TxtB_MiMa)
    End Sub

    Private Sub TxtB_MiMa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtB_MiMa.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Dim iRetYuQiE As Integer

            sSelKaiXiangNo = ""
            If TxtB_MiMa.Text <> "" Then
                '比较开箱手机及密码并取出箱号
                sSelKaiXiangNo = ReadKaiXiangNo(TxtB_MiMa.Text, iRetYuQiE)
            End If
            If sSelKaiXiangNo <> "" Then
                With struInputInfo
                    If .SelType = 2 Then
                        .SelWuXiangNo = sSelKaiXiangNo
                        .StoreBoxGroupNo = Int((.SelWuXiangNo - 1) / 20) + 1
                        .StoreBoxNo = .SelWuXiangNo - (.StoreBoxGroupNo - 1) * 20
                        .KaiXiangMima = TxtB_MiMa.Text
                        If iRetYuQiE = 0 Then
                            .TouBiJinE = 0
                            Frm_WuXiangQueRen.Show()
                        Else
                            .TouBiJinE = iRetYuQiE
                            Frm_YuQiFuWuTiShi.Show()
                        End If
                        Me.Close()
                    End If
                End With
            Else
                iInputCount += 1
                'If iInputCount = 5 Then
                'sqlExe.AddUpdateDelOpe("Delete From XianZhi Where Tel ='" & struInputInfo.ShouJianRenTel & "'")
                'sqlExe.AddUpdateDelOpe("Insert Into XianZhi " & _
                '"Values ( '" & struInputInfo.ShouJianRenTel & "'," & _
                ' "'" & Now & "')")
                Frm_KaiXiangBaoQianTiShi.Show()
                Me.Close()
            End If
            TxtB_MiMa.Text = ""
        End If
    End Sub
End Class