<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_WeiHuYeWu
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_Head = New System.Windows.Forms.Label()
        Me.Btn_KaiXiang = New System.Windows.Forms.Button()
        Me.Btn_QiYong = New System.Windows.Forms.Button()
        Me.Btn_JinYong = New System.Windows.Forms.Button()
        Me.lbl_S = New System.Windows.Forms.Label()
        Me.Lbl_Timer = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbl_StoreBoxNo2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_StoreBoxNo1 = New System.Windows.Forms.Label()
        Me.Lab_DaoJiShi = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_DaoJiShi
        '
        Me.Timer_DaoJiShi.Enabled = True
        Me.Timer_DaoJiShi.Interval = 1000
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(165, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 38)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "维护如下箱子："
        '
        'Lbl_Head
        '
        Me.Lbl_Head.AutoSize = True
        Me.Lbl_Head.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Head.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Location = New System.Drawing.Point(387, 10)
        Me.Lbl_Head.Name = "Lbl_Head"
        Me.Lbl_Head.Size = New System.Drawing.Size(256, 75)
        Me.Lbl_Head.TabIndex = 76
        Me.Lbl_Head.Text = "维护业务"
        '
        'Btn_KaiXiang
        '
        Me.Btn_KaiXiang.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_KaiXiang.FlatAppearance.BorderSize = 0
        Me.Btn_KaiXiang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_KaiXiang.Font = New System.Drawing.Font("微软雅黑", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_KaiXiang.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_KaiXiang.Image = Global.StoreBox.My.Resources.Resources._02_04
        Me.Btn_KaiXiang.Location = New System.Drawing.Point(563, 249)
        Me.Btn_KaiXiang.Name = "Btn_KaiXiang"
        Me.Btn_KaiXiang.Size = New System.Drawing.Size(330, 150)
        Me.Btn_KaiXiang.TabIndex = 90
        Me.Btn_KaiXiang.Text = "开  箱"
        Me.Btn_KaiXiang.UseVisualStyleBackColor = False
        '
        'Btn_QiYong
        '
        Me.Btn_QiYong.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_QiYong.FlatAppearance.BorderSize = 0
        Me.Btn_QiYong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_QiYong.Font = New System.Drawing.Font("微软雅黑", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_QiYong.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_QiYong.Image = Global.StoreBox.My.Resources.Resources._02_02
        Me.Btn_QiYong.Location = New System.Drawing.Point(733, 405)
        Me.Btn_QiYong.Name = "Btn_QiYong"
        Me.Btn_QiYong.Size = New System.Drawing.Size(160, 160)
        Me.Btn_QiYong.TabIndex = 91
        Me.Btn_QiYong.Text = "启  用"
        Me.Btn_QiYong.UseVisualStyleBackColor = False
        '
        'Btn_JinYong
        '
        Me.Btn_JinYong.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_JinYong.FlatAppearance.BorderSize = 0
        Me.Btn_JinYong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_JinYong.Font = New System.Drawing.Font("微软雅黑", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_JinYong.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_JinYong.Image = Global.StoreBox.My.Resources.Resources._02_03
        Me.Btn_JinYong.Location = New System.Drawing.Point(563, 405)
        Me.Btn_JinYong.Name = "Btn_JinYong"
        Me.Btn_JinYong.Size = New System.Drawing.Size(160, 160)
        Me.Btn_JinYong.TabIndex = 92
        Me.Btn_JinYong.Text = "禁  用"
        Me.Btn_JinYong.UseVisualStyleBackColor = False
        '
        'lbl_S
        '
        Me.lbl_S.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_S.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_S.Location = New System.Drawing.Point(940, 95)
        Me.lbl_S.Name = "lbl_S"
        Me.lbl_S.Size = New System.Drawing.Size(21, 21)
        Me.lbl_S.TabIndex = 94
        Me.lbl_S.Text = "s"
        Me.lbl_S.Visible = False
        '
        'Lbl_Timer
        '
        Me.Lbl_Timer.AutoSize = True
        Me.Lbl_Timer.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Timer.Location = New System.Drawing.Point(788, 95)
        Me.Lbl_Timer.Name = "Lbl_Timer"
        Me.Lbl_Timer.Size = New System.Drawing.Size(136, 21)
        Me.Lbl_Timer.TabIndex = 93
        Me.Lbl_Timer.Text = "操作倒计时："
        Me.Lbl_Timer.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.StoreBox.My.Resources.Resources._29_06
        Me.Panel2.Controls.Add(Me.Lbl_StoreBoxNo2)
        Me.Panel2.Location = New System.Drawing.Point(271, 349)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(107, 107)
        Me.Panel2.TabIndex = 97
        '
        'Lbl_StoreBoxNo2
        '
        Me.Lbl_StoreBoxNo2.AutoSize = True
        Me.Lbl_StoreBoxNo2.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_StoreBoxNo2.Font = New System.Drawing.Font("宋体", 72.0!)
        Me.Lbl_StoreBoxNo2.Location = New System.Drawing.Point(10, 4)
        Me.Lbl_StoreBoxNo2.Name = "Lbl_StoreBoxNo2"
        Me.Lbl_StoreBoxNo2.Size = New System.Drawing.Size(90, 97)
        Me.Lbl_StoreBoxNo2.TabIndex = 74
        Me.Lbl_StoreBoxNo2.Text = "0"
        Me.Lbl_StoreBoxNo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.StoreBox.My.Resources.Resources._29_06
        Me.Panel1.Controls.Add(Me.Lbl_StoreBoxNo1)
        Me.Panel1.Location = New System.Drawing.Point(143, 349)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(105, 107)
        Me.Panel1.TabIndex = 96
        '
        'Lbl_StoreBoxNo1
        '
        Me.Lbl_StoreBoxNo1.AutoSize = True
        Me.Lbl_StoreBoxNo1.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_StoreBoxNo1.Font = New System.Drawing.Font("宋体", 72.0!)
        Me.Lbl_StoreBoxNo1.Location = New System.Drawing.Point(11, 5)
        Me.Lbl_StoreBoxNo1.Name = "Lbl_StoreBoxNo1"
        Me.Lbl_StoreBoxNo1.Size = New System.Drawing.Size(90, 97)
        Me.Lbl_StoreBoxNo1.TabIndex = 74
        Me.Lbl_StoreBoxNo1.Text = "0"
        Me.Lbl_StoreBoxNo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_DaoJiShi
        '
        Me.Lab_DaoJiShi.BackColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lab_DaoJiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Location = New System.Drawing.Point(16, 0)
        Me.Lab_DaoJiShi.Name = "Lab_DaoJiShi"
        Me.Lab_DaoJiShi.Size = New System.Drawing.Size(132, 62)
        Me.Lab_DaoJiShi.TabIndex = 98
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
        Me.Panel5.TabIndex = 100
        '
        'Frm_WeiHuYeWu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1022, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_S)
        Me.Controls.Add(Me.Lbl_Timer)
        Me.Controls.Add(Me.Btn_JinYong)
        Me.Controls.Add(Me.Btn_QiYong)
        Me.Controls.Add(Me.Btn_KaiXiang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lbl_Head)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_WeiHuYeWu"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer_DaoJiShi As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Head As System.Windows.Forms.Label
    Friend WithEvents Btn_KaiXiang As System.Windows.Forms.Button
    Friend WithEvents Btn_QiYong As System.Windows.Forms.Button
    Friend WithEvents Btn_JinYong As System.Windows.Forms.Button
    Friend WithEvents lbl_S As System.Windows.Forms.Label
    Friend WithEvents Lbl_Timer As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_StoreBoxNo2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_StoreBoxNo1 As System.Windows.Forms.Label
    Friend WithEvents Lab_DaoJiShi As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
