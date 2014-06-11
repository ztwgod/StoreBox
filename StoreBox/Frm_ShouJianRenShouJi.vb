Imports System.Data.SqlClient

Public Class Frm_ShouJianRenShouJi
    Dim iCount As Integer = 30


    Private Sub Frm_ShouJianRenShouJi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetCommonHead(Lbl_Head, Nothing, Nothing, Nothing, Nothing, Nothing, lbl_TiShi)
        SetCommonInfo(Me)
        TxtB_ShouJiHao.Text = struInputInfo.ShouJianRenTel
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
        Select Case struInputInfo.SelType
            Case 1
                Frm_KuaiDiGongSiXuanZe.Show()
            Case 2
                Frm_YeWuBanLi.Show()
            Case 3
                Frm_XuanZeWuXiang.Show()
            Case 4
                Frm_XuanZeWuXiang.Show()
        End Select
        Me.Close()
    End Sub


    Private Sub Btn_XiaYiBu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_XiaYiBu.Click
        Dim sRet As String = ChkTel(Trim(TxtB_ShouJiHao.Text))
        If sRet = "" Then
            struInputInfo.ShouJianRenTel = TxtB_ShouJiHao.Text
            Select Case struInputInfo.SelType
                Case 1, 3
                    Frm_JiJianRenShouJi.Show()
                Case 2
                    'If chkShouJianRenTel() Then
                    Frm_KaiXiangMiMa.Show()
                    ' Else
                    ' MessageBox.Show("此号码因为密码输入次数过多，已被禁用!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'TxtB_ShouJiHao.Focus()
                    'End If
                Case 4
                    Frm_KuaiDiDanSaoMiao.Show()
            End Select
            Me.Close()
        Else
            MessageBox.Show(sRet, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtB_ShouJiHao.Focus()
        End If
    End Sub


    Private Function chkShouJianRenTel() As Boolean
        Dim sSQL As String
        Dim datread As SqlDataReader = Nothing            '用于存放记录集
        Dim bFlag As Boolean
        Dim lSec As Long = 61
        Dim bEixst As Boolean = False

        Try
            sSQL = "Select * From XianZhi Where Tel= '" & TxtB_ShouJiHao.Text & "' Order by XianZhiTime Desc"
            bFlag = sqlExe.GetRecordData(sSQL, datread)
            chkShouJianRenTel = True
            If datread.Read() Then
                lSec = DateDiff("N", datread("XianZhiTime").ToString, Format(Now, "yyyy-MM-dd hh:mm:ss"))
                If lSec <= 60 Then
                    chkShouJianRenTel = False
                End If
                bEixst = True
            End If
            datread.Close()
            If bEixst AndAlso chkShouJianRenTel Then
                sqlExe.AddUpdateDelOpe("Delete From XianZhi Where Tel= '" & TxtB_ShouJiHao.Text & "'")
            End If

        Catch ex As Exception
            MessageBox.Show("数据库异常，请您联系系统维护人员解决后再执行本操作！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End Try

    End Function


    Private Sub Frm_ShouJianRenShouJi_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim sRet As String = ChkTel(Trim(TxtB_ShouJiHao.Text))
        If sRet = "" Then
            struInputInfo.ShouJianRenTel = TxtB_ShouJiHao.Text
            Select Case struInputInfo.SelType
                Case 1, 3
                    Frm_JiJianRenShouJi.Show()
                Case 2
                    'If chkShouJianRenTel() Then
                    Frm_KaiXiangMiMa.Show()
                    ' Else
                    ' MessageBox.Show("此号码因为密码输入次数过多，已被禁用!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'TxtB_ShouJiHao.Focus()
                    'End If
                Case 4
                    Frm_KuaiDiDanSaoMiao.Show()
            End Select
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
                struInputInfo.ShouJianRenTel = TxtB_ShouJiHao.Text
                Select Case struInputInfo.SelType
                    Case 1, 3
                        Frm_JiJianRenShouJi.Show()
                    Case 2
                        'If chkShouJianRenTel() Then
                        Frm_KaiXiangMiMa.Show()
                        ' Else
                        ' MessageBox.Show("此号码因为密码输入次数过多，已被禁用!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'TxtB_ShouJiHao.Focus()
                        'End If
                    Case 4
                        Frm_KuaiDiDanSaoMiao.Show()
                End Select
                Me.Close()
            Else
                MessageBox.Show(sRet, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtB_ShouJiHao.Focus()
            End If
        End If
    End Sub
End Class