<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_JiCunFuFeiXuZhi
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
        Me.Btn_WoYaoFuFei = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Head = New System.Windows.Forms.Label()
        Me.Btn_QuXiaoJiCun = New System.Windows.Forms.Button()
        Me.Timer_DaoJiShi = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_S = New System.Windows.Forms.Label()
        Me.Lab_DaoJiShi = New System.Windows.Forms.Label()
        Me.Lbl_Timer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_WoYaoFuFei
        '
        Me.Btn_WoYaoFuFei.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_WoYaoFuFei.FlatAppearance.BorderSize = 0
        Me.Btn_WoYaoFuFei.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_WoYaoFuFei.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_WoYaoFuFei.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_WoYaoFuFei.Image = Global.StoreBox.My.Resources.Resources._02_04
        Me.Btn_WoYaoFuFei.Location = New System.Drawing.Point(335, 231)
        Me.Btn_WoYaoFuFei.Name = "Btn_WoYaoFuFei"
        Me.Btn_WoYaoFuFei.Size = New System.Drawing.Size(330, 150)
        Me.Btn_WoYaoFuFei.TabIndex = 18
        Me.Btn_WoYaoFuFei.Text = "我要付费"
        Me.Btn_WoYaoFuFei.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(538, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 41)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "2元"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(366, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 41)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "您需付费："
        '
        'Lbl_Head
        '
        Me.Lbl_Head.AutoSize = True
        Me.Lbl_Head.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Head.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Location = New System.Drawing.Point(362, 9)
        Me.Lbl_Head.Name = "Lbl_Head"
        Me.Lbl_Head.Size = New System.Drawing.Size(256, 75)
        Me.Lbl_Head.TabIndex = 12
        Me.Lbl_Head.Text = "付费须知"
        '
        'Btn_QuXiaoJiCun
        '
        Me.Btn_QuXiaoJiCun.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_QuXiaoJiCun.FlatAppearance.BorderSize = 0
        Me.Btn_QuXiaoJiCun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_QuXiaoJiCun.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_QuXiaoJiCun.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_QuXiaoJiCun.Image = Global.StoreBox.My.Resources.Resources._02_06
        Me.Btn_QuXiaoJiCun.Location = New System.Drawing.Point(335, 387)
        Me.Btn_QuXiaoJiCun.Name = "Btn_QuXiaoJiCun"
        Me.Btn_QuXiaoJiCun.Size = New System.Drawing.Size(330, 150)
        Me.Btn_QuXiaoJiCun.TabIndex = 22
        Me.Btn_QuXiaoJiCun.Text = "取消寄存"
        Me.Btn_QuXiaoJiCun.UseVisualStyleBackColor = False
        '
        'Timer_DaoJiShi
        '
        Me.Timer_DaoJiShi.Enabled = True
        Me.Timer_DaoJiShi.Interval = 1000
        '
        'lbl_S
        '
        Me.lbl_S.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_S.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_S.Location = New System.Drawing.Point(974, 245)
        Me.lbl_S.Name = "lbl_S"
        Me.lbl_S.Size = New System.Drawing.Size(21, 21)
        Me.lbl_S.TabIndex = 44
        Me.lbl_S.Text = "s"
        Me.lbl_S.Visible = False
        '
        'Lab_DaoJiShi
        '
        Me.Lab_DaoJiShi.BackColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lab_DaoJiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Location = New System.Drawing.Point(13, 1)
        Me.Lab_DaoJiShi.Name = "Lab_DaoJiShi"
        Me.Lab_DaoJiShi.Size = New System.Drawing.Size(132, 60)
        Me.Lab_DaoJiShi.TabIndex = 45
        Me.Lab_DaoJiShi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Timer
        '
        Me.Lbl_Timer.AutoSize = True
        Me.Lbl_Timer.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Timer.Location = New System.Drawing.Point(848, 245)
        Me.Lbl_Timer.Name = "Lbl_Timer"
        Me.Lbl_Timer.Size = New System.Drawing.Size(136, 21)
        Me.Lbl_Timer.TabIndex = 43
        Me.Lbl_Timer.Text = "操作倒计时："
        Me.Lbl_Timer.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(3, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(531, 42)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "2：发件方和收件方的姓名、地址、电话等必须准确无误的填写，收件方栏" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "同时写上收件人的手机。"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(3, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(451, 21)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "3：本收费为预收费，如超出收费标准，本公司有权收取补差。"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(3, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(307, 21)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "1：当天取件，次日上午送达的快递服务。"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 28)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "付费说明："
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.StoreBox.My.Resources.Resources._07_03
        Me.Panel5.Controls.Add(Me.Lab_DaoJiShi)
        Me.Panel5.Location = New System.Drawing.Point(835, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(158, 62)
        Me.Panel5.TabIndex = 59
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.StoreBox.My.Resources.Resources._12_02
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(133, 560)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 129)
        Me.Panel1.TabIndex = 60
        '
        'Frm_JiCunFuFeiXuZhi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_S)
        Me.Controls.Add(Me.Lbl_Timer)
        Me.Controls.Add(Me.Btn_QuXiaoJiCun)
        Me.Controls.Add(Me.Btn_WoYaoFuFei)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl_Head)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_JiCunFuFeiXuZhi"
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_WoYaoFuFei As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Head As System.Windows.Forms.Label
    Friend WithEvents Btn_QuXiaoJiCun As System.Windows.Forms.Button
    Friend WithEvents Timer_DaoJiShi As System.Windows.Forms.Timer
    Friend WithEvents lbl_S As System.Windows.Forms.Label
    Friend WithEvents Lab_DaoJiShi As System.Windows.Forms.Label
    Friend WithEvents Lbl_Timer As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
