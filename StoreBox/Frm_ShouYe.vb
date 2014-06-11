Imports System.Data.SqlClient
Imports System.Linq
Imports System.IO.Ports
Imports System.IO
Imports Newtonsoft.Json
Imports XB.API.Client
Imports XB.API.Client.Request

Public Class Frm_ShouYe

    Private Sub Bttn_YeWuBanLi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_YeWuBanLi.Click
        Frm_YeWuBanLi.Show()
        Me.Close()
    End Sub

    Private Sub Frm_ShouYe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Lbl_Head
            .Top = HUAMIANTOP
            .Left = (Screen.PrimaryScreen.Bounds.Width - .Width) / 2
        End With
        SetCommonInfo(Me)
    End Sub
End Class
