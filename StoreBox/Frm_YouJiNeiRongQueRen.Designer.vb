<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_YouJiNeiRongQueRen
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
        Me.Lbl_Head = New System.Windows.Forms.Label()
        Me.Lab_DaoJiShi = New System.Windows.Forms.Label()
        Me.lbl_S = New System.Windows.Forms.Label()
        Me.Lbl_Timer = New System.Windows.Forms.Label()
        Me.Btn_XiaYiBu = New System.Windows.Forms.Button()
        Me.Btn_ShangYiBu = New System.Windows.Forms.Button()
        Me.Timer_DaoJiShi = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_shoujian = New System.Windows.Forms.Label()
        Me.Lbl_JiJian = New System.Windows.Forms.Label()
        Me.Lbl_KuaiDi = New System.Windows.Forms.Label()
        Me.TxtB_ShouJianRenShouJi = New System.Windows.Forms.Label()
        Me.TxtB_KuaiDiDanHao = New System.Windows.Forms.Label()
        Me.TxtB_JiJianRenShouJi = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Head
        '
        Me.Lbl_Head.AutoSize = True
        Me.Lbl_Head.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Font = New System.Drawing.Font("Microsoft YaHei", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Head.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Location = New System.Drawing.Point(335, 5)
        Me.Lbl_Head.Name = "Lbl_Head"
        Me.Lbl_Head.Size = New System.Drawing.Size(368, 75)
        Me.Lbl_Head.TabIndex = 0
        Me.Lbl_Head.Tag = " "
        Me.Lbl_Head.Text = "邮寄内容确认"
        '
        'Lab_DaoJiShi
        '
        Me.Lab_DaoJiShi.BackColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lab_DaoJiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Location = New System.Drawing.Point(12, 0)
        Me.Lab_DaoJiShi.Name = "Lab_DaoJiShi"
        Me.Lab_DaoJiShi.Size = New System.Drawing.Size(64, 60)
        Me.Lab_DaoJiShi.TabIndex = 13
        Me.Lab_DaoJiShi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_S
        '
        Me.lbl_S.Font = New System.Drawing.Font("SimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_S.Location = New System.Drawing.Point(874, 239)
        Me.lbl_S.Name = "lbl_S"
        Me.lbl_S.Size = New System.Drawing.Size(21, 21)
        Me.lbl_S.TabIndex = 12
        Me.lbl_S.Text = "s"
        Me.lbl_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_S.Visible = False
        '
        'Lbl_Timer
        '
        Me.Lbl_Timer.AutoSize = True
        Me.Lbl_Timer.Font = New System.Drawing.Font("SimSun", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Timer.Location = New System.Drawing.Point(845, 197)
        Me.Lbl_Timer.Name = "Lbl_Timer"
        Me.Lbl_Timer.Size = New System.Drawing.Size(129, 20)
        Me.Lbl_Timer.TabIndex = 11
        Me.Lbl_Timer.Text = "操作倒计时："
        Me.Lbl_Timer.Visible = False
        '
        'Btn_XiaYiBu
        '
        Me.Btn_XiaYiBu.BackColor = System.Drawing.Color.Transparent
        Me.Btn_XiaYiBu.FlatAppearance.BorderSize = 0
        Me.Btn_XiaYiBu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_XiaYiBu.Font = New System.Drawing.Font("Microsoft YaHei", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_XiaYiBu.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_XiaYiBu.Image = Global.StoreBox.My.Resources.Resources._02_05
        Me.Btn_XiaYiBu.Location = New System.Drawing.Point(361, 428)
        Me.Btn_XiaYiBu.Name = "Btn_XiaYiBu"
        Me.Btn_XiaYiBu.Size = New System.Drawing.Size(330, 150)
        Me.Btn_XiaYiBu.TabIndex = 1
        Me.Btn_XiaYiBu.Text = "确认"
        Me.Btn_XiaYiBu.UseVisualStyleBackColor = False
        '
        'Btn_ShangYiBu
        '
        Me.Btn_ShangYiBu.BackColor = System.Drawing.Color.Transparent
        Me.Btn_ShangYiBu.BackgroundImage = Global.StoreBox.My.Resources.Resources.无标题
        Me.Btn_ShangYiBu.FlatAppearance.BorderSize = 0
        Me.Btn_ShangYiBu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ShangYiBu.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_ShangYiBu.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_ShangYiBu.Location = New System.Drawing.Point(12, 12)
        Me.Btn_ShangYiBu.Name = "Btn_ShangYiBu"
        Me.Btn_ShangYiBu.Size = New System.Drawing.Size(180, 80)
        Me.Btn_ShangYiBu.TabIndex = 0
        Me.Btn_ShangYiBu.Text = "返回"
        Me.Btn_ShangYiBu.UseVisualStyleBackColor = False
        '
        'Timer_DaoJiShi
        '
        Me.Timer_DaoJiShi.Enabled = True
        Me.Timer_DaoJiShi.Interval = 1000
        '
        'Lbl_shoujian
        '
        Me.Lbl_shoujian.AutoSize = True
        Me.Lbl_shoujian.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_shoujian.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_shoujian.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_shoujian.Location = New System.Drawing.Point(312, 162)
        Me.Lbl_shoujian.Name = "Lbl_shoujian"
        Me.Lbl_shoujian.Size = New System.Drawing.Size(220, 38)
        Me.Lbl_shoujian.TabIndex = 21
        Me.Lbl_shoujian.Text = "收件人手机号："
        '
        'Lbl_JiJian
        '
        Me.Lbl_JiJian.AutoSize = True
        Me.Lbl_JiJian.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_JiJian.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_JiJian.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_JiJian.Location = New System.Drawing.Point(312, 233)
        Me.Lbl_JiJian.Name = "Lbl_JiJian"
        Me.Lbl_JiJian.Size = New System.Drawing.Size(220, 38)
        Me.Lbl_JiJian.TabIndex = 22
        Me.Lbl_JiJian.Text = "寄件人手机号："
        '
        'Lbl_KuaiDi
        '
        Me.Lbl_KuaiDi.AutoSize = True
        Me.Lbl_KuaiDi.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_KuaiDi.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_KuaiDi.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_KuaiDi.Location = New System.Drawing.Point(315, 301)
        Me.Lbl_KuaiDi.Name = "Lbl_KuaiDi"
        Me.Lbl_KuaiDi.Size = New System.Drawing.Size(189, 38)
        Me.Lbl_KuaiDi.TabIndex = 23
        Me.Lbl_KuaiDi.Text = "快 递 单 号："
        '
        'TxtB_ShouJianRenShouJi
        '
        Me.TxtB_ShouJianRenShouJi.AutoSize = True
        Me.TxtB_ShouJianRenShouJi.BackColor = System.Drawing.Color.Transparent
        Me.TxtB_ShouJianRenShouJi.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtB_ShouJianRenShouJi.ForeColor = System.Drawing.Color.Transparent
        Me.TxtB_ShouJianRenShouJi.Location = New System.Drawing.Point(526, 162)
        Me.TxtB_ShouJianRenShouJi.Name = "TxtB_ShouJianRenShouJi"
        Me.TxtB_ShouJianRenShouJi.Size = New System.Drawing.Size(189, 38)
        Me.TxtB_ShouJianRenShouJi.TabIndex = 27
        Me.TxtB_ShouJianRenShouJi.Text = "1339********"
        '
        'TxtB_KuaiDiDanHao
        '
        Me.TxtB_KuaiDiDanHao.AutoSize = True
        Me.TxtB_KuaiDiDanHao.BackColor = System.Drawing.Color.Transparent
        Me.TxtB_KuaiDiDanHao.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtB_KuaiDiDanHao.ForeColor = System.Drawing.Color.Transparent
        Me.TxtB_KuaiDiDanHao.Location = New System.Drawing.Point(526, 302)
        Me.TxtB_KuaiDiDanHao.Name = "TxtB_KuaiDiDanHao"
        Me.TxtB_KuaiDiDanHao.Size = New System.Drawing.Size(189, 38)
        Me.TxtB_KuaiDiDanHao.TabIndex = 28
        Me.TxtB_KuaiDiDanHao.Text = "1339********"
        '
        'TxtB_JiJianRenShouJi
        '
        Me.TxtB_JiJianRenShouJi.AutoSize = True
        Me.TxtB_JiJianRenShouJi.BackColor = System.Drawing.Color.Transparent
        Me.TxtB_JiJianRenShouJi.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtB_JiJianRenShouJi.ForeColor = System.Drawing.Color.Transparent
        Me.TxtB_JiJianRenShouJi.Location = New System.Drawing.Point(526, 232)
        Me.TxtB_JiJianRenShouJi.Name = "TxtB_JiJianRenShouJi"
        Me.TxtB_JiJianRenShouJi.Size = New System.Drawing.Size(189, 38)
        Me.TxtB_JiJianRenShouJi.TabIndex = 29
        Me.TxtB_JiJianRenShouJi.Text = "1339********"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.StoreBox.My.Resources.Resources._07_03
        Me.Panel5.Controls.Add(Me.Lab_DaoJiShi)
        Me.Panel5.Location = New System.Drawing.Point(835, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(158, 62)
        Me.Panel5.TabIndex = 53
        '
        'Frm_YouJiNeiRongQueRen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1022, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtB_JiJianRenShouJi)
        Me.Controls.Add(Me.TxtB_KuaiDiDanHao)
        Me.Controls.Add(Me.TxtB_ShouJianRenShouJi)
        Me.Controls.Add(Me.lbl_S)
        Me.Controls.Add(Me.Lbl_KuaiDi)
        Me.Controls.Add(Me.Lbl_JiJian)
        Me.Controls.Add(Me.Lbl_shoujian)
        Me.Controls.Add(Me.Btn_XiaYiBu)
        Me.Controls.Add(Me.Btn_ShangYiBu)
        Me.Controls.Add(Me.Lbl_Timer)
        Me.Controls.Add(Me.Lbl_Head)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_YouJiNeiRongQueRen"
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Head As System.Windows.Forms.Label
    Friend WithEvents Lab_DaoJiShi As System.Windows.Forms.Label
    Friend WithEvents lbl_S As System.Windows.Forms.Label
    Friend WithEvents Lbl_Timer As System.Windows.Forms.Label
    Friend WithEvents Btn_XiaYiBu As System.Windows.Forms.Button
    Friend WithEvents Btn_ShangYiBu As System.Windows.Forms.Button
    Friend WithEvents Timer_DaoJiShi As System.Windows.Forms.Timer
    Friend WithEvents Lbl_shoujian As System.Windows.Forms.Label
    Friend WithEvents Lbl_JiJian As System.Windows.Forms.Label
    Friend WithEvents Lbl_KuaiDi As System.Windows.Forms.Label
    Friend WithEvents TxtB_ShouJianRenShouJi As System.Windows.Forms.Label
    Friend WithEvents TxtB_KuaiDiDanHao As System.Windows.Forms.Label
    Friend WithEvents TxtB_JiJianRenShouJi As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
