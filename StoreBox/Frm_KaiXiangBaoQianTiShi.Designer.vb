<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_KaiXiangBaoQianTiShi
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
        Me.Timer_DaoJiShi = New System.Windows.Forms.Timer(Me.components)
        Me.Lab_TiShi = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_Head = New System.Windows.Forms.Label()
        Me.Btn_QuXiao = New System.Windows.Forms.Button()
        Me.Lbl_S = New System.Windows.Forms.Label()
        Me.Lbl_Timer = New System.Windows.Forms.Label()
        Me.Lab_DaoJiShi = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Lab_TiShi.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lab_TiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lab_TiShi.Location = New System.Drawing.Point(406, 227)
        Me.Lab_TiShi.Name = "Lab_TiShi"
        Me.Lab_TiShi.Size = New System.Drawing.Size(220, 38)
        Me.Lab_TiShi.TabIndex = 98
        Me.Lab_TiShi.Text = "请核对后再试！"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(349, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(336, 38)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "手机号或密码输入错误！"
        '
        'Lbl_Head
        '
        Me.Lbl_Head.AutoSize = True
        Me.Lbl_Head.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Font = New System.Drawing.Font("Microsoft YaHei", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Head.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Location = New System.Drawing.Point(383, 9)
        Me.Lbl_Head.Name = "Lbl_Head"
        Me.Lbl_Head.Size = New System.Drawing.Size(256, 75)
        Me.Lbl_Head.TabIndex = 89
        Me.Lbl_Head.Text = "物箱选择"
        '
        'Btn_QuXiao
        '
        Me.Btn_QuXiao.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_QuXiao.FlatAppearance.BorderSize = 0
        Me.Btn_QuXiao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_QuXiao.Font = New System.Drawing.Font("Microsoft YaHei", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_QuXiao.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_QuXiao.Image = Global.StoreBox.My.Resources.Resources._02_05
        Me.Btn_QuXiao.Location = New System.Drawing.Point(341, 422)
        Me.Btn_QuXiao.Name = "Btn_QuXiao"
        Me.Btn_QuXiao.Size = New System.Drawing.Size(330, 150)
        Me.Btn_QuXiao.TabIndex = 0
        Me.Btn_QuXiao.Text = "取  消"
        Me.Btn_QuXiao.UseVisualStyleBackColor = False
        '
        'Lbl_S
        '
        Me.Lbl_S.Font = New System.Drawing.Font("SimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_S.Location = New System.Drawing.Point(965, 244)
        Me.Lbl_S.Name = "Lbl_S"
        Me.Lbl_S.Size = New System.Drawing.Size(21, 21)
        Me.Lbl_S.TabIndex = 103
        Me.Lbl_S.Text = "s"
        Me.Lbl_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lbl_S.Visible = False
        '
        'Lbl_Timer
        '
        Me.Lbl_Timer.AutoSize = True
        Me.Lbl_Timer.Font = New System.Drawing.Font("SimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Timer.Location = New System.Drawing.Point(834, 244)
        Me.Lbl_Timer.Name = "Lbl_Timer"
        Me.Lbl_Timer.Size = New System.Drawing.Size(136, 21)
        Me.Lbl_Timer.TabIndex = 102
        Me.Lbl_Timer.Text = "操作倒计时："
        Me.Lbl_Timer.Visible = False
        '
        'Lab_DaoJiShi
        '
        Me.Lab_DaoJiShi.BackColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lab_DaoJiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Location = New System.Drawing.Point(14, 2)
        Me.Lab_DaoJiShi.Name = "Lab_DaoJiShi"
        Me.Lab_DaoJiShi.Size = New System.Drawing.Size(134, 60)
        Me.Lab_DaoJiShi.TabIndex = 106
        Me.Lab_DaoJiShi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.StoreBox.My.Resources.Resources._07_03
        Me.Panel5.Controls.Add(Me.Lab_DaoJiShi)
        Me.Panel5.Location = New System.Drawing.Point(835, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(158, 62)
        Me.Panel5.TabIndex = 108
        '
        'Frm_KaiXiangBaoQianTiShi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1022, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl_S)
        Me.Controls.Add(Me.Lbl_Timer)
        Me.Controls.Add(Me.Btn_QuXiao)
        Me.Controls.Add(Me.Lab_TiShi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lbl_Head)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_KaiXiangBaoQianTiShi"
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer_DaoJiShi As System.Windows.Forms.Timer
    Friend WithEvents Lab_TiShi As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Head As System.Windows.Forms.Label
    Friend WithEvents Btn_QuXiao As System.Windows.Forms.Button
    Friend WithEvents Lbl_S As System.Windows.Forms.Label
    Friend WithEvents Lbl_Timer As System.Windows.Forms.Label
    Friend WithEvents Lab_DaoJiShi As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
