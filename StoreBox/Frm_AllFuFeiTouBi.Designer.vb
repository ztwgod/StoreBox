<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AllFuFeiTouBi
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_Head = New System.Windows.Forms.Label()
        Me.Timer_DaoJiShi = New System.Windows.Forms.Timer(Me.components)
        Me.Lab_FuKuan = New System.Windows.Forms.Label()
        Me.Lab_DaoJiShi = New System.Windows.Forms.Label()
        Me.Lbl_SumE = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_QuXiao = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(405, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 31)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "需付款总额："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(435, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 31)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "您已付款："
        '
        'Lbl_Head
        '
        Me.Lbl_Head.AutoSize = True
        Me.Lbl_Head.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Font = New System.Drawing.Font("Microsoft YaHei", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Head.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Location = New System.Drawing.Point(365, 9)
        Me.Lbl_Head.Name = "Lbl_Head"
        Me.Lbl_Head.Size = New System.Drawing.Size(256, 75)
        Me.Lbl_Head.TabIndex = 12
        Me.Lbl_Head.Text = "付费投币"
        '
        'Timer_DaoJiShi
        '
        Me.Timer_DaoJiShi.Enabled = True
        Me.Timer_DaoJiShi.Interval = 1000
        '
        'Lab_FuKuan
        '
        Me.Lab_FuKuan.BackColor = System.Drawing.Color.Transparent
        Me.Lab_FuKuan.Font = New System.Drawing.Font("Microsoft YaHei", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lab_FuKuan.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Lab_FuKuan.Location = New System.Drawing.Point(7, 13)
        Me.Lab_FuKuan.Name = "Lab_FuKuan"
        Me.Lab_FuKuan.Size = New System.Drawing.Size(96, 88)
        Me.Lab_FuKuan.TabIndex = 26
        Me.Lab_FuKuan.Text = "99"
        Me.Lab_FuKuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_DaoJiShi
        '
        Me.Lab_DaoJiShi.BackColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lab_DaoJiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Location = New System.Drawing.Point(14, 0)
        Me.Lab_DaoJiShi.Name = "Lab_DaoJiShi"
        Me.Lab_DaoJiShi.Size = New System.Drawing.Size(64, 60)
        Me.Lab_DaoJiShi.TabIndex = 33
        Me.Lab_DaoJiShi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_SumE
        '
        Me.Lbl_SumE.AutoSize = True
        Me.Lbl_SumE.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SumE.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_SumE.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_SumE.Location = New System.Drawing.Point(555, 159)
        Me.Lbl_SumE.Name = "Lbl_SumE"
        Me.Lbl_SumE.Size = New System.Drawing.Size(52, 31)
        Me.Lbl_SumE.TabIndex = 34
        Me.Lbl_SumE.Text = "5元"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(805, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 38)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "模拟投币"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.StoreBox.My.Resources.Resources._29_06
        Me.Panel1.Controls.Add(Me.Lab_FuKuan)
        Me.Panel1.Location = New System.Drawing.Point(444, 301)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(105, 105)
        Me.Panel1.TabIndex = 60
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.StoreBox.My.Resources.Resources._07_03
        Me.Panel5.Controls.Add(Me.Lab_DaoJiShi)
        Me.Panel5.Location = New System.Drawing.Point(835, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(158, 62)
        Me.Panel5.TabIndex = 61
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.StoreBox.My.Resources.Resources._12_02
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(122, 479)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 129)
        Me.Panel2.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(3, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(451, 21)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "3：本收费为预收费，如超出收费标准，本公司有权收取补差。"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(3, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(531, 42)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "2：发件方和收件方的姓名、地址、电话等必须准确无误的填写，收件方栏" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "同时写上收件人的手机。"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(7, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 28)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "付费说明："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(3, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(307, 21)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "1：当天取件，次日上午送达的快递服务。"
        '
        'Btn_QuXiao
        '
        Me.Btn_QuXiao.BackColor = System.Drawing.Color.Transparent
        Me.Btn_QuXiao.FlatAppearance.BorderSize = 0
        Me.Btn_QuXiao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_QuXiao.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_QuXiao.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_QuXiao.Image = Global.StoreBox.My.Resources.Resources.无标题
        Me.Btn_QuXiao.Location = New System.Drawing.Point(12, 12)
        Me.Btn_QuXiao.Name = "Btn_QuXiao"
        Me.Btn_QuXiao.Size = New System.Drawing.Size(180, 80)
        Me.Btn_QuXiao.TabIndex = 63
        Me.Btn_QuXiao.TabStop = False
        Me.Btn_QuXiao.Text = "返回"
        Me.Btn_QuXiao.UseVisualStyleBackColor = False
        '
        'Frm_AllFuFeiTouBi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1022, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_QuXiao)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lbl_SumE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lbl_Head)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_AllFuFeiTouBi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Head As System.Windows.Forms.Label
    Friend WithEvents Timer_DaoJiShi As System.Windows.Forms.Timer
    Friend WithEvents Lab_FuKuan As System.Windows.Forms.Label
    Friend WithEvents Lab_DaoJiShi As System.Windows.Forms.Label
    Friend WithEvents Lbl_SumE As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Btn_QuXiao As System.Windows.Forms.Button
End Class
