<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Timer_StoreBox = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Loop = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Rnd = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort3 = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPort5 = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPort4 = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPort6 = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPort7 = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPort11 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer_S3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_BoxCommand = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 8)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(611, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Timer_StoreBox
        '
        Me.Timer_StoreBox.Interval = 3000
        '
        'Timer_Loop
        '
        Me.Timer_Loop.Interval = 1000
        '
        'Timer_Rnd
        '
        Me.Timer_Rnd.Interval = 12000
        '
        'SerialPort3
        '
        '
        'SerialPort5
        '
        '
        'SerialPort4
        '
        '
        'SerialPort6
        '
        '
        'SerialPort7
        '
        '
        'SerialPort11
        '
        '
        'Timer_S3
        '
        Me.Timer_S3.Enabled = True
        Me.Timer_S3.Interval = 300000
        '
        'Timer_BoxCommand
        '
        Me.Timer_BoxCommand.Enabled = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(629, 489)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMain"
        Me.Padding = New System.Windows.Forms.Padding(9, 8, 9, 8)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Timer_StoreBox As System.Windows.Forms.Timer
    Friend WithEvents Timer_Loop As System.Windows.Forms.Timer
    Friend WithEvents Timer_Rnd As System.Windows.Forms.Timer
    Friend WithEvents SerialPort3 As System.IO.Ports.SerialPort
    Friend WithEvents SerialPort5 As System.IO.Ports.SerialPort
    Friend WithEvents SerialPort4 As System.IO.Ports.SerialPort
    Friend WithEvents SerialPort6 As System.IO.Ports.SerialPort
    Friend WithEvents SerialPort7 As System.IO.Ports.SerialPort
    Friend WithEvents SerialPort11 As System.IO.Ports.SerialPort
    Friend WithEvents Timer_S3 As System.Windows.Forms.Timer
    Friend WithEvents Timer_BoxCommand As System.Windows.Forms.Timer

End Class
