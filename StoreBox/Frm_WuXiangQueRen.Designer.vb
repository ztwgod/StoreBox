<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_WuXiangQueRen
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
        Me.Lbl_ShuoMing = New System.Windows.Forms.Label()
        Me.Lbl_S = New System.Windows.Forms.Label()
        Me.Lbl_Timer = New System.Windows.Forms.Label()
        Me.Lbl_Head = New System.Windows.Forms.Label()
        Me.Lab_DaoJiShi = New System.Windows.Forms.Label()
        Me.Timer_DaoJiShi = New System.Windows.Forms.Timer(Me.components)
        Me.Lab_TiShi = New System.Windows.Forms.Label()
        Me.Lbl_StoreBoxNo1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbl_StoreBoxNo2 = New System.Windows.Forms.Label()
        Me.Timer_SMS_Wait = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Ctrl_Wait = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_ShuoMing
        '
        Me.Lbl_ShuoMing.AutoSize = True
        Me.Lbl_ShuoMing.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ShuoMing.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_ShuoMing.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_ShuoMing.Location = New System.Drawing.Point(371, 149)
        Me.Lbl_ShuoMing.Name = "Lbl_ShuoMing"
        Me.Lbl_ShuoMing.Size = New System.Drawing.Size(278, 38)
        Me.Lbl_ShuoMing.TabIndex = 52
        Me.Lbl_ShuoMing.Text = "请将您的物品放置："
        '
        'Lbl_S
        '
        Me.Lbl_S.Font = New System.Drawing.Font("SimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_S.Location = New System.Drawing.Point(951, 251)
        Me.Lbl_S.Name = "Lbl_S"
        Me.Lbl_S.Size = New System.Drawing.Size(21, 21)
        Me.Lbl_S.TabIndex = 50
        Me.Lbl_S.Text = "s"
        Me.Lbl_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lbl_S.Visible = False
        '
        'Lbl_Timer
        '
        Me.Lbl_Timer.AutoSize = True
        Me.Lbl_Timer.Font = New System.Drawing.Font("SimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Timer.Location = New System.Drawing.Point(809, 251)
        Me.Lbl_Timer.Name = "Lbl_Timer"
        Me.Lbl_Timer.Size = New System.Drawing.Size(136, 21)
        Me.Lbl_Timer.TabIndex = 49
        Me.Lbl_Timer.Text = "操作倒计时："
        Me.Lbl_Timer.Visible = False
        '
        'Lbl_Head
        '
        Me.Lbl_Head.AutoSize = True
        Me.Lbl_Head.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Head.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Location = New System.Drawing.Point(409, 7)
        Me.Lbl_Head.Name = "Lbl_Head"
        Me.Lbl_Head.Size = New System.Drawing.Size(219, 62)
        Me.Lbl_Head.TabIndex = 48
        Me.Lbl_Head.Text = "物箱确认"
        '
        'Lab_DaoJiShi
        '
        Me.Lab_DaoJiShi.BackColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lab_DaoJiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Location = New System.Drawing.Point(13, 0)
        Me.Lab_DaoJiShi.Name = "Lab_DaoJiShi"
        Me.Lab_DaoJiShi.Size = New System.Drawing.Size(64, 60)
        Me.Lab_DaoJiShi.TabIndex = 69
        Me.Lab_DaoJiShi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer_DaoJiShi
        '
        Me.Timer_DaoJiShi.Enabled = True
        Me.Timer_DaoJiShi.Interval = 1000
        '
        'Lab_TiShi
        '
        Me.Lab_TiShi.AutoSize = True
        Me.Lab_TiShi.BackColor = System.Drawing.Color.Transparent
        Me.Lab_TiShi.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lab_TiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lab_TiShi.Location = New System.Drawing.Point(266, 87)
        Me.Lab_TiShi.Name = "Lab_TiShi"
        Me.Lab_TiShi.Size = New System.Drawing.Size(518, 31)
        Me.Lab_TiShi.TabIndex = 70
        Me.Lab_TiShi.Text = "友情提示：为保证您的合法权益，请关好箱门！"
        '
        'Lbl_StoreBoxNo1
        '
        Me.Lbl_StoreBoxNo1.AutoSize = True
        Me.Lbl_StoreBoxNo1.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_StoreBoxNo1.Font = New System.Drawing.Font("Microsoft YaHei", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_StoreBoxNo1.Location = New System.Drawing.Point(16, 6)
        Me.Lbl_StoreBoxNo1.Name = "Lbl_StoreBoxNo1"
        Me.Lbl_StoreBoxNo1.Size = New System.Drawing.Size(92, 104)
        Me.Lbl_StoreBoxNo1.TabIndex = 74
        Me.Lbl_StoreBoxNo1.Text = "0"
        Me.Lbl_StoreBoxNo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Lbl_StoreBoxNo1)
        Me.Panel1.Location = New System.Drawing.Point(369, 251)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(120, 120)
        Me.Panel1.TabIndex = 75
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Lbl_StoreBoxNo2)
        Me.Panel2.Location = New System.Drawing.Point(529, 251)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(120, 120)
        Me.Panel2.TabIndex = 76
        '
        'Lbl_StoreBoxNo2
        '
        Me.Lbl_StoreBoxNo2.AutoSize = True
        Me.Lbl_StoreBoxNo2.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_StoreBoxNo2.Font = New System.Drawing.Font("Microsoft YaHei", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_StoreBoxNo2.Location = New System.Drawing.Point(17, 5)
        Me.Lbl_StoreBoxNo2.Name = "Lbl_StoreBoxNo2"
        Me.Lbl_StoreBoxNo2.Size = New System.Drawing.Size(92, 104)
        Me.Lbl_StoreBoxNo2.TabIndex = 74
        Me.Lbl_StoreBoxNo2.Text = "0"
        Me.Lbl_StoreBoxNo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer_SMS_Wait
        '
        Me.Timer_SMS_Wait.Interval = 25000
        '
        'Timer_Ctrl_Wait
        '
        Me.Timer_Ctrl_Wait.Interval = 3500
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(8, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(694, 26)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "2：发件方和收件方的姓名、地址、电话等必须准确无误的填写，收件方栏同时写上收件人手机。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(7, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(451, 21)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "3：本收费为预收费，如超出收费标准，本公司有权收取补差。"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(8, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(307, 21)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "1：当天取件，次日上午送达的快递服务。"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "付费说明："
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.StoreBox.My.Resources.Resources._07_03
        Me.Panel5.Controls.Add(Me.Lab_DaoJiShi)
        Me.Panel5.Location = New System.Drawing.Point(835, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(158, 62)
        Me.Panel5.TabIndex = 85
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.StoreBox.My.Resources.Resources._12_02
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(144, 560)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(770, 128)
        Me.Panel3.TabIndex = 86
        '
        'Frm_WuXiangQueRen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1022, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lbl_S)
        Me.Controls.Add(Me.Lab_TiShi)
        Me.Controls.Add(Me.Lbl_ShuoMing)
        Me.Controls.Add(Me.Lbl_Timer)
        Me.Controls.Add(Me.Lbl_Head)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_WuXiangQueRen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_ShuoMing As System.Windows.Forms.Label
    Friend WithEvents Lbl_S As System.Windows.Forms.Label
    Friend WithEvents Lbl_Timer As System.Windows.Forms.Label
    Friend WithEvents Lbl_Head As System.Windows.Forms.Label
    Friend WithEvents Lab_DaoJiShi As System.Windows.Forms.Label
    Friend WithEvents Timer_DaoJiShi As System.Windows.Forms.Timer
    Friend WithEvents Lab_TiShi As System.Windows.Forms.Label
    Friend WithEvents Lbl_StoreBoxNo1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_StoreBoxNo2 As System.Windows.Forms.Label
    Friend WithEvents Timer_SMS_Wait As System.Windows.Forms.Timer
    Friend WithEvents Timer_Ctrl_Wait As System.Windows.Forms.Timer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
