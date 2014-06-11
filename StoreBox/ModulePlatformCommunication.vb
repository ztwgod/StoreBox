Imports System.Runtime.CompilerServices
Imports System.IO.Ports
Imports XB.API.Client.Response
Imports XB.API.Domain
Imports XB.API.Client.Request
Imports XB.API.Client

Module ModulePlatformCommunication

    Public OpenBoxNum As String

    Public Sub WebSyncThread()
        Dim dispatcher As CommandDispatcher = New CommandDispatcher()
        Dim webSyncClient As New WebSyncClient(dispatcher)
        webSyncClient.Connect(struStoreBoxPeiZhi.StroeBoxID)
    End Sub

    ''' <summary>
    ''' 物箱注册和同步
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function StorageRegSync(ByVal synchType As Integer) As Boolean
        Dim boxes = GetBoxStatus()
        Dim ccLocation As Integer = storeboxConfig.ControlCabinetLocation
        ' 可用箱子数量
        Dim avalableBox = boxes.Count(Function(x) x.IsEmpty And x.IsOk)
        Dim synchWrapper As New SynchWrapper
        Dim ssInfo As New StorageStationInfo
        Dim ccInfoList As New List(Of CabinetContainer)
        For i = 1 To struStoreBoxPeiZhi.StoreBoxSum
            Dim ccInfo As New CabinetContainer
            If i < ccLocation Then
                ccInfo.CabinetCode = struStoreBoxPeiZhi.StroeBoxID & Right("00" & i, 2)
            Else
                ccInfo.CabinetCode = struStoreBoxPeiZhi.StroeBoxID & Right("00" & i + 1, 2)
            End If
            ccInfo.CabinetIndex = Right("00" & i, 2)
            ccInfo.Type = 1
            ccInfo.CabinetWidth = 2
            ccInfo.CabinetHeight = 10
            ccInfo.BoxNumber = 20
            ccInfo.Status = 1

            If i < ccLocation Then
                ccInfo.CabinetIndex = i
            Else
                ccInfo.CabinetIndex = i + 1
            End If
            Dim boxInfoList As New List(Of BoxInfo)
            For j = 1 To 20
                Dim ci = i, cj = j
                Dim q = boxes.Where(Function(x) CInt(x.CCID) = ci And CInt(x.BoxID) = cj)
                If q.Count > 0 Then
                    Dim box = q.First
                    Dim boxInfo As New BoxInfo
                    With boxInfo
                        .BoxCode = ccInfo.CabinetCode & Right("000" & j, 3)
                        .BoxIndex = Right("000" & j, 3)
                        .BoxType = 4 - box.Size
                    End With
                    If Not box.IsEmpty Then
                        boxInfo.BoxLoadStatus = 2
                    Else
                        boxInfo.BoxLoadStatus = 1
                    End If
                    If Not box.IsOk Then
                        boxInfo.BoxRunStatus = 6
                    ElseIf box.IsOpened Then
                        boxInfo.BoxRunStatus = 5
                    ElseIf Not box.IsEmpty Then
                        boxInfo.BoxRunStatus = 2
                    Else
                        boxInfo.BoxRunStatus = 1
                    End If
                    boxInfoList.Add(boxInfo)
                End If
            Next
            ccInfo.BoxInfos = New BoxInfos(boxInfoList)
            ccInfoList.Add(ccInfo)
        Next

        Dim peripherals As New List(Of Peripheral)
        For Each peripheralConfig In storeboxConfig.Peripherals
            Dim peripharal As New Peripheral
            peripharal.RunStatus = 1
            peripharal.AssetSn = peripheralConfig.AssetSn
            peripharal.Type = peripheralConfig.Type
            peripharal.Version = peripheralConfig.Version
            peripharal.PeripheralAbbName = peripheralConfig.Name
            peripharal.PeripheralCode = peripheralConfig.Code
            peripherals.Add(peripharal)
        Next

        With ssInfo
            .StorageStationType = storeboxConfig.Type
            .StorageStationVersion = storeboxConfig.Version
            .AssetSn = storeboxConfig.AssetSn
            .DataCard = storeboxConfig.DataCard
            .IpAddress = storeboxConfig.IpAddress
            .Port = storeboxConfig.Port
            .StorageStationVersion = storeboxConfig.Version
            .PhyLinkType = storeboxConfig.PhyLinkType
            .StorageStationStatus = 1
            .ControlCabinetLocation = ccLocation
            .AvailableBoxNum = avalableBox
            .Peripherals = New Peripherals(peripherals)
            .CabinetContainers = New CabinetContainers(ccInfoList)
        End With

        With synchWrapper
            .SynchType = synchType
            .SequenceNumber = 0
            .GuiSequenceNumber = 0
            .StorageStationId = struStoreBoxPeiZhi.StroeBoxID

            .Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            .StorageStationInfo = ssInfo
        End With

        Dim client As New DefaultClient
        Dim result = client.Execute(synchWrapper)
        Return result.ResultStatus = 1
    End Function

    Public Function StorageStatusSync() As Boolean
        Return StorageStatusSync(String.Empty)
    End Function

    ''' <summary>
    ''' 物箱的状态信息同步
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function StorageStatusSync(ByVal guiSequenceNum As String) As Boolean
        Dim boxes = GetBoxStatus()

        ' 总的空箱数
        Dim ssEmptyCount = boxes.Count(Function(y) y.IsEmpty And y.IsOk)

        ' 柜子的状态
        Dim ccStatus = New List(Of DeviceStatus)
        For i = 1 To struStoreBoxPeiZhi.StoreBoxSum
            Dim deviceStatus = New DeviceStatus
            ' TODO: 目前控制台的编号是2，将来需要从配置文件中读取
            If i < 2 Then
                deviceStatus.DeviceCode = struStoreBoxPeiZhi.StroeBoxID & Microsoft.VisualBasic.Right("00" & i, 2)
            Else
                deviceStatus.DeviceCode = struStoreBoxPeiZhi.StroeBoxID & Microsoft.VisualBasic.Right("00" & i + 1, 2)
            End If
            Dim ccEmptyCount = boxes.Count(Function(x) x.CCID = deviceStatus.DeviceCode And x.IsEmpty And x.IsOk)
            If ccEmptyCount <= 0 Then       'TODO: 这里仅判断了柜子是否还有空箱
                deviceStatus.Status = 2
            Else
                deviceStatus.Status = 1
            End If
            ccStatus.Add(deviceStatus)
        Next

        ' 箱子存货状态
        Dim boxLoadStatus = New List(Of DeviceStatus)
        For Each box In boxes
            Dim deviceStatus = New DeviceStatus
            Dim ccid = box.CCID
            Dim bid = box.BoxID
            ' TODO: 目前控制台的编号是2，将来需要从配置文件中读取
            If ccid >= 2 Then
                ccid = ccid + 1
            End If
            deviceStatus.DeviceCode = struStoreBoxPeiZhi.StroeBoxID & _
                    Microsoft.VisualBasic.Right("00" & ccid, 2) & _
                    Microsoft.VisualBasic.Right("000" & bid, 3)
            If box.IsEmpty Then             'TODO: 仅判断了空闲和占用
                deviceStatus.Status = 1
            Else
                deviceStatus.Status = 2
            End If
            boxLoadStatus.Add(deviceStatus)
        Next

        ' 箱子的运行状态
        Dim boxRunStatus = New List(Of DeviceStatus)
        For Each box In boxes
            Dim deviceStatus = New DeviceStatus
            Dim ccid = box.CCID
            Dim bid = box.BoxID
            ' TODO: 目前控制台的编号是2，将来需要从配置文件中读取
            If ccid >= 2 Then
                ccid = ccid + 1
            End If
            deviceStatus.DeviceCode = struStoreBoxPeiZhi.StroeBoxID & _
                    Microsoft.VisualBasic.Right("00" & ccid, 2) & _
                    Microsoft.VisualBasic.Right("000" & bid, 3)
            If Not box.IsOk Then
                deviceStatus.Status = 6
            ElseIf box.IsOpened Then
                deviceStatus.Status = 5
            ElseIf Not box.IsEmpty Then
                deviceStatus.Status = 2
            Else
                deviceStatus.Status = 1
            End If
            boxRunStatus.Add(deviceStatus)
        Next

        Dim statusWrapper As New StorageStationStatusWrapper
        With statusWrapper
            .SequenceNumber = 0
            .GuiSequenceNumber = guiSequenceNum
            .StorageStationId = struStoreBoxPeiZhi.StroeBoxID

            If ssEmptyCount <= 0 Then      ' TODO: 这里仅做了是否还有空箱的判断，需加上系统忙、断线等状态判断
                .StorageStationStatus = 2
            Else
                .StorageStationStatus = 1
            End If
            .PeripheralRunStatus = Nothing  ' 无法取到外围设备状态
            .CabinetContainerStatus = New CabinetContainerStatus(ccStatus)
            .BoxLoadStatus = New BoxLoadStatus(boxLoadStatus)
            .BoxRunStatus = New BoxRunStatus(boxRunStatus)
            .ClientUploadTime = DateTime.Now
        End With

        Dim client As New DefaultClient
        Dim result = client.Execute(statusWrapper)

        Return result.ResultStatus = 1

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="transId">交易的唯一编号</param>
    ''' <param name="ssId">物箱的编号</param>
    ''' <remarks></remarks>
    Public Function TransactionSync(ByVal transId As String, ByVal ssId As String) As Boolean
        Dim client As New DefaultClient

        Dim transactionRequest As New TransactionWrapper
        Dim transactionInfo As New TransactionInfo
        Dim senderInfo As New SenderInfo
        Dim addresseeInfo As New AddresseeInfo
        Dim courierInfo As New CourierInfo

        With senderInfo
            .MobilePhone = struInputInfo.JiJianRenTel
        End With

        With addresseeInfo
            .MobilePhone = struInputInfo.ShouJianRenTel
        End With

        With courierInfo
            '.CourierId = struInputInfo.sICCardNo  ' 快递员卡号做为ID
            .CourierId = struInputInfo.KuaidiId
        End With
        Dim gid = struInputInfo.StoreBoxGroupNo
        Dim sid = struInputInfo.StoreBoxNo
        ' TODO: 控制台位置的处理
        If gid >= 2 Then
            gid = gid + 1
        End If
        With transactionInfo
            .TransactionID = transId
            .BoxCode = ssId & _
                        Microsoft.VisualBasic.Right("00" & gid, 2) & _
                        Microsoft.VisualBasic.Right("000" & sid, 3)
            .SupplierId = String.Empty
            .ExpressDeliveryId = String.Empty
            .ExpressCode = struInputInfo.KuaiDiDanHao
            .ExpressDescription = String.Empty
            .StorageTime = 60 * 6
            .PastDueTime = 0                    'TODO: 超时计算
            .TotalAmount = struInputInfo.FuFeiE 'TODO: 总金额，是否等于投币金额
            .PayType = 1                        'TODO: 支付类型，超时？
            .PayMode = 1
            .VoucherId = String.Empty
            .VoucherTotal = 0
            .PayPrice = .TotalAmount            'TODO: 支付金额计算
            .PickupPassword = struInputInfo.KaiXiangMima
            .IsStandardsCompliant = 1
            .NotStandardsCompliantCause = String.Empty
            .ExpressSizeType = 0                'TODO: 尺寸未知
            .SenderInfo = senderInfo
            .AddresseeInfo = addresseeInfo
            .CourierInfo = courierInfo
        End With

        With transactionRequest
            .SequenceNumber = 0
            If struInputInfo.SelType = 1 Then
                ' 寄件操作
                .TransActionType = 1
            ElseIf struInputInfo.SelType = 3 Then
                ' 寄存操作
                .TransActionType = 5
            ElseIf struInputInfo.SelType = 2 Then
                ' 取件操作
                ' TODO: 收件人取件业务，需判断取的是寄存件，还是快递件。
                ' 寄存件的TransActionType是6, 快递件的TransActionType是4
                .TransActionType = 4
            ElseIf struInputInfo.SelType = 4 Then
                ' 快递员业务
                If struInputInfo.ShouJianPaiJian = "收件" Then
                    ' 快递员收件
                    .TransActionType = 2
                Else
                    ' 快递员投件
                    .TransActionType = 3
                End If
            End If
            .StorageStationId = ssId
            .ClientTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            .ClientUploadTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            .TransactionInfo = transactionInfo
        End With

        Dim ret = False

        Dim result = client.Execute(transactionRequest)
        ret = result.ResultStatus <> 0

        Return ret
    End Function

    Public Function CourierSync() As Boolean
        CourierSync(String.Empty)
    End Function

    ''' <summary>
    ''' 更新快递员信息
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CourierSync(ByVal guiSequenceNum As String) As Boolean
        Dim client As New DefaultClient
        Dim synchCourierWrapper As New SynchCourierWrapper
        With synchCourierWrapper
            .StorageStationId = struStoreBoxPeiZhi.StroeBoxID
            .ExePermissionType = 0
            .GuiSequenceNumber = guiSequenceNum
        End With

        Dim synchResult = client.Execute(synchCourierWrapper)
        For Each courierInfo As ICourierAuthorityInfo In synchResult.CourierAuthorityInfos.ICourierAuthorityInfos
            If courierInfo.CourierInfo IsNot Nothing AndAlso Not String.IsNullOrEmpty(courierInfo.CourierInfo.CourierId) Then
                sqlExe.SaveCourier(courierInfo.CourierInfo.CourierId,
                                   courierInfo.CourierInfo.Name,
                                   courierInfo.CourierInfo.MobilePhone,
                                   courierInfo.CourierCardInfo.CardCode,
                                   courierInfo.CourierCardInfo.CardPwd,
                                   courierInfo.CourierInfo.ExcoName)
            End If
        Next


    End Function

    ''' <summary>
    ''' 获取当前所有箱子的状态列表
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBoxStatus() As IEnumerable(Of BoxStatus)
        Dim dt = sqlExe.GetDataTable("select * from WuXiangZhuangTai")

        Dim boxes As IList(Of BoxStatus) = New List(Of BoxStatus)()
        For i = 1 To struStoreBoxPeiZhi.StoreBoxSum
            For j = 1 To 20
                Dim q = From o In dt.AsEnumerable() Where o.Item("GroupNo") = i _
                        Where o.Item("BianHao") = j _
                        Select New BoxStatus With
                        {
                            .SSID = struStoreBoxPeiZhi.StroeBoxID,
                            .CCID = Right("00" & i, 2),
                            .BoxID = Right("000" & j, 3),
                            .Size = o.Item("Daxiaozhuangtai"),
                            .IsOk = (o.Item("ZhengChangZhuangTai") = 0),
                            .IsEmpty = (o.Item("YouWuZhuangTai") = 1),
                            .IsOpened = (o.Item("KaiGuanZhuangTai") = 1)
                        }
                Dim box = q.FirstOrDefault()
                'boxes.Add(q.FirstOrDefault())
                If Not IsNothing(box) Then
                    boxes.Add(box)
                End If

            Next
        Next
        Return boxes
    End Function

    Public Sub OpenBox(ByVal box As String)
        'SetStop()
        Dim port = New SerialPort("com5")
        port.Open()
        port.DiscardInBuffer()
        'port.Open()
        bStartReceive(2) = True
        iCommandType = 1
        CurSMS.SMS_Write(port, box, 1)
    End Sub
End Module

Public Structure BoxStatus
    ''' <summary>
    ''' 物箱的编号
    ''' </summary>
    ''' <remarks></remarks>
    Public SSID As String

    ''' <summary>
    ''' 柜子的编号
    ''' </summary>
    ''' <remarks></remarks>
    Public CCID As String

    ''' <summary>
    ''' 箱子的编号
    ''' </summary>
    ''' <remarks></remarks>
    Public BoxID As String

    ''' <summary>
    ''' 大小状态
    ''' 0 小 1 中 2 大
    ''' </summary>
    ''' <remarks></remarks>
    Public Size As Integer

    ''' <summary>
    ''' 箱子是否被打开
    ''' </summary>
    ''' <remarks>kong</remarks>
    Public IsOpened As Boolean

    ''' <summary>
    ''' 箱子是否正常
    ''' </summary>
    ''' <remarks></remarks>
    Public IsOk As Boolean

    ''' <summary>
    ''' 是否空箱
    ''' </summary>
    ''' <remarks></remarks>
    Public IsEmpty As Boolean
End Structure
