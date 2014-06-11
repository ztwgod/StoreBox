Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class CDBOperation
    'Private Const sIP As String = "(local)\sqlexpress"
    'Private sConn As String = "server=" & sIP & ";database=StoreBox;Trusted_Connection=True;MultipleActiveResultSets=true"

    Private sConn As String

    Private myConnection As SqlConnection
    Public myCommand As SqlCommand
    Public tran As SqlTransaction

    Public Function DBConnect() As Boolean
        Try
            myConnection = New SqlConnection(sConn)
            myConnection.Open()
            Return True
        Catch ex As Exception
            Call MsgBox(ex.Message.ToString, vbOKOnly Or vbInformation, "提示信息")
            Return False
        End Try
    End Function

    Public Sub DBClose()
        If Not myCommand Is Nothing Then
            myCommand.Dispose()
            myCommand = Nothing
        End If
        If myConnection IsNot Nothing Then
            myConnection.Close()
            myConnection.Dispose()
            myConnection = Nothing
        End If
    End Sub

     Public Function AddUpdateDelOpe(ByVal sSql As String, Optional ByVal bMsgDisp As Boolean = True) As Boolean

        Dim myCommand As SqlCommand
        Try
            myCommand = New SqlCommand()
            myCommand.Connection = myConnection
            myCommand.CommandText = sSql
            myCommand.ExecuteNonQuery()
            myCommand.Dispose()
            myCommand = Nothing
            Return True
        Catch ex As Exception
            If bMsgDisp Then
                Call MsgBox(ex.Message.ToString(), vbOKOnly Or vbInformation, "提示信息")
            End If
            Return False
        End Try

    End Function


    Public Function GetRecordData(ByVal sSql As String, ByRef Record As SqlDataReader) As Boolean

        Dim myCommand As SqlCommand
        Try
            myCommand = New SqlCommand()
            myCommand.Connection = myConnection
            myCommand.CommandText = sSql
            Record = myCommand.ExecuteReader
            myCommand.Dispose()
            myCommand = Nothing
            Return True
        Catch ex As Exception
            Call MsgBox(ex.Message.ToString(), vbOKOnly Or vbInformation, "提示信息")
            Return False

        End Try

    End Function

    ''' <summary>
    ''' 执行sql,返回DataTable
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDataTable(ByVal sql As String) As DataTable
        Try
            
            Dim da = New SqlDataAdapter(sql, myConnection)
            Dim ds = New DataSet()
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub SaveCourier(ByVal id As String, _
                           ByVal xingming As String, _
                           ByVal dianhua As String, _
                           ByVal kahao As String, _
                           ByVal mima As String, _
                           ByVal gongsi As String)
        Dim dr As SqlDataReader
        GetRecordData("select * from kuaidiyuan where id='" + id + "'", dr)
        If dr.Read() Then
            Dim sql = "update kuaidiyuan set xingming='" & xingming & _
                "',dianhua='" & dianhua & _
                "',kahao='" & kahao & _
                "',mima='" & mima & _
                "',gongsi='" & gongsi & _
                "' where id= '" & id & _
                "'"
            AddUpdateDelOpe(sql, False)
        Else
            Dim sql = "insert into kuaidiyuan (id,xingming,dianhua,kahao,mima,gongsi) " & _
                "values('" & id & _
                "','" & xingming & _
                "','" & dianhua & _
                "','" & kahao & _
                "','" & mima & _
                "','" & gongsi & _
                "')"
            AddUpdateDelOpe(sql, False)
        End If
    End Sub
    Public Sub New()
        sConn = ConfigurationManager.AppSettings("conn")
    End Sub
End Class
