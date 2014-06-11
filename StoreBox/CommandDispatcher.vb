Imports XB.API.Log
Imports XB.API.Client.Request
Imports XB.API
Imports Newtonsoft.Json
Imports XB.API.Client

Public Class CommandDispatcher : Implements ICommandDispatcher

    Public Sub DispatchMessage(ByVal logId As String, ByVal type As String, ByVal message As String) Implements ICommandDispatcher.DispatchMessage
        If type.EndsWith("DepositUnpackInfoWarpper") Then
            ' 开箱操作


            Dim cmd = JsonConvert.DeserializeObject(Of DepositUnpackInfoWarpper)(message)
            Dim shortBoxCode = Right(cmd.BoxCode, 5)

            Dim g = CInt(Left(shortBoxCode, 2))     ' 柜号
            Dim b = CInt(Right(shortBoxCode, 3))    ' 箱号

            If g > 2 Then
                g = g - 1
            End If

            Dim request As New DepositUnpackInfoResult
            Dim client As New DefaultClient

            ' TODO: 增加手机号码验证功能
            If Len(cmd.UserMobilePhone) <> 11 Then

                request.GuiSequenceNumber = cmd.GuiSequenceNumber
                request.ResultStatus = 0
                request.ErrorMsg = "手机号码不正确"
                client.Execute(request)
                Exit Sub

            End If

            OpenBoxNum = g & "," & b
            request.GuiSequenceNumber = cmd.GuiSequenceNumber
            request.ResultStatus = 1
            request.ErrorMsg = "ok"
            client.Execute(request)
            Exit Sub
        End If

        If type.EndsWith("RemoteUnpackeInfoWarpper") Then
            ' TODO: App开箱操作，返回错误代码
            Dim cmd = JsonConvert.DeserializeObject(Of RemoteUnpackeInfoWarpper)(message)

            Dim shortBoxCode = Right(cmd.BoxCode, 5)

            Dim g = CInt(Left(shortBoxCode, 2))     ' 柜号
            Dim b = CInt(Right(shortBoxCode, 3))    ' 箱号

            If g > 2 Then
                g = g - 1
            End If
            OpenBoxNum = g & "," & b

            Dim request As New DepositUnpackInfoResult
            Dim client As New DefaultClient
            request.GuiSequenceNumber = cmd.GuiSequenceNumber
            request.ResultStatus = 1
            request.ErrorMsg = "error"
            client.Execute(request)
        End If

        If type.EndsWith("ConfigureCommandWarpper") Then
            Dim cmd = JsonConvert.DeserializeObject(Of ConfigureCommandWarpper)(message)
            ' Switch cmd.GuiOperationType
            Select Case cmd.GuiOperationType
                Case 1
                    ' 物箱信息同步
                    StorageStatusSync(cmd.GuiSequenceNumber)
                Case 6, 7, 8
                    StorageStatusSync(cmd.GuiSequenceNumber)
                Case 4, 5
                    CourierSync(cmd.GuiSequenceNumber)
                Case Else
                    ' do nothing
            End Select



        End If
    End Sub
End Class
