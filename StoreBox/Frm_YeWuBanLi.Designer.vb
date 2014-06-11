<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_YeWuBanLi
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
        Me.Lbl_TiShi = New System.Windows.Forms.Label()
        Me.Timer_DaoJiShi = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_GuanLiYuanYeWu = New System.Windows.Forms.Button()
        Me.Btn_KuaiDiYuanYeWu = New System.Windows.Forms.Button()
        Me.Btn_WoYaoJiCun = New System.Windows.Forms.Button()
        Me.Btn_WoYaoShouJian = New System.Windows.Forms.Button()
        Me.Btn_WoYaoJiJian = New System.Windows.Forms.Button()
        Me.Btn_QuXiao = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Head
        '
        Me.Lbl_Head.AutoSize = True
        Me.Lbl_Head.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Font = New System.Drawing.Font("微软雅黑", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Head.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Location = New System.Drawing.Point(301, 23)
        Me.Lbl_Head.Name = "Lbl_Head"
        Me.Lbl_Head.Size = New System.Drawing.Size(459, 62)
        Me.Lbl_Head.TabIndex = 0
        Me.Lbl_Head.Text = "请选择需办理的业务"
        '
        'Lbl_TiShi
        '
        Me.Lbl_TiShi.AutoSize = True
        Me.Lbl_TiShi.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TiShi.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_TiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_TiShi.Location = New System.Drawing.Point(237, 100)
        Me.Lbl_TiShi.Name = "Lbl_TiShi"
        Me.Lbl_TiShi.Size = New System.Drawing.Size(591, 38)
        Me.Lbl_TiShi.TabIndex = 6
        Me.Lbl_TiShi.Text = "友情提示:办理寄件业务前,请首先填写快递单!"
        '
        'Timer_DaoJiShi
        '
        Me.Timer_DaoJiShi.Enabled = True
        Me.Timer_DaoJiShi.Interval = 1000
        '
        'Btn_GuanLiYuanYeWu
        '
        Me.Btn_GuanLiYuanYeWu.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_GuanLiYuanYeWu.FlatAppearance.BorderSize = 0
        Me.Btn_GuanLiYuanYeWu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_GuanLiYuanYeWu.Font = New System.Drawing.Font("微软雅黑", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_GuanLiYuanYeWu.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_GuanLiYuanYeWu.Image = Global.StoreBox.My.Resources.Resources._02_02
        Me.Btn_GuanLiYuanYeWu.Location = New System.Drawing.Point(697, 387)
        Me.Btn_GuanLiYuanYeWu.Name = "Btn_GuanLiYuanYeWu"
        Me.Btn_GuanLiYuanYeWu.Size = New System.Drawing.Size(160, 150)
        Me.Btn_GuanLiYuanYeWu.TabIndex = 5
        Me.Btn_GuanLiYuanYeWu.Text = "管理员"
        Me.Btn_GuanLiYuanYeWu.UseVisualStyleBackColor = False
        '
        'Btn_KuaiDiYuanYeWu
        '
        Me.Btn_KuaiDiYuanYeWu.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_KuaiDiYuanYeWu.FlatAppearance.BorderSize = 0
        Me.Btn_KuaiDiYuanYeWu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_KuaiDiYuanYeWu.Font = New System.Drawing.Font("微软雅黑", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_KuaiDiYuanYeWu.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_KuaiDiYuanYeWu.Image = Global.StoreBox.My.Resources.Resources._02_03
        Me.Btn_KuaiDiYuanYeWu.Location = New System.Drawing.Point(527, 387)
        Me.Btn_KuaiDiYuanYeWu.Name = "Btn_KuaiDiYuanYeWu"
        Me.Btn_KuaiDiYuanYeWu.Size = New System.Drawing.Size(160, 150)
        Me.Btn_KuaiDiYuanYeWu.TabIndex = 4
        Me.Btn_KuaiDiYuanYeWu.Text = "快递员"
        Me.Btn_KuaiDiYuanYeWu.UseVisualStyleBackColor = False
        '
        'Btn_WoYaoJiCun
        '
        Me.Btn_WoYaoJiCun.BackColor = System.Drawing.Color.Transparent
        Me.Btn_WoYaoJiCun.FlatAppearance.BorderSize = 0
        Me.Btn_WoYaoJiCun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_WoYaoJiCun.Font = New System.Drawing.Font("微软雅黑", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_WoYaoJiCun.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_WoYaoJiCun.Image = Global.StoreBox.My.Resources.Resources._02_04
        Me.Btn_WoYaoJiCun.Location = New System.Drawing.Point(527, 231)
        Me.Btn_WoYaoJiCun.Name = "Btn_WoYaoJiCun"
        Me.Btn_WoYaoJiCun.Size = New System.Drawing.Size(330, 150)
        Me.Btn_WoYaoJiCun.TabIndex = 3
        Me.Btn_WoYaoJiCun.Text = "我要寄存"
        Me.Btn_WoYaoJiCun.UseVisualStyleBackColor = False
        '
        'Btn_WoYaoShouJian
        '
        Me.Btn_WoYaoShouJian.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_WoYaoShouJian.FlatAppearance.BorderSize = 0
        Me.Btn_WoYaoShouJian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_WoYaoShouJian.Font = New System.Drawing.Font("微软雅黑", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_WoYaoShouJian.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_WoYaoShouJian.Image = Global.StoreBox.My.Resources.Resources._02_05
        Me.Btn_WoYaoShouJian.Location = New System.Drawing.Point(191, 387)
        Me.Btn_WoYaoShouJian.Name = "Btn_WoYaoShouJian"
        Me.Btn_WoYaoShouJian.Size = New System.Drawing.Size(330, 150)
        Me.Btn_WoYaoShouJian.TabIndex = 2
        Me.Btn_WoYaoShouJian.Text = "我要收件"
        Me.Btn_WoYaoShouJian.UseVisualStyleBackColor = False
        '
        'Btn_WoYaoJiJian
        '
        Me.Btn_WoYaoJiJian.BackColor = System.Drawing.Color.Transparent
        Me.Btn_WoYaoJiJian.FlatAppearance.BorderSize = 0
        Me.Btn_WoYaoJiJian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_WoYaoJiJian.Font = New System.Drawing.Font("微软雅黑", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_WoYaoJiJian.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_WoYaoJiJian.Image = Global.StoreBox.My.Resources.Resources._02_06
        Me.Btn_WoYaoJiJian.Location = New System.Drawing.Point(191, 231)
        Me.Btn_WoYaoJiJian.Name = "Btn_WoYaoJiJian"
        Me.Btn_WoYaoJiJian.Size = New System.Drawing.Size(330, 150)
        Me.Btn_WoYaoJiJian.TabIndex = 1
        Me.Btn_WoYaoJiJian.Text = "我要寄件"
        Me.Btn_WoYaoJiJian.UseVisualStyleBackColor = False
        '
        'Btn_QuXiao
        '
        Me.Btn_QuXiao.BackColor = System.Drawing.Color.Transparent
        Me.Btn_QuXiao.FlatAppearance.BorderSize = 0
        Me.Btn_QuXiao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_QuXiao.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_QuXiao.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_QuXiao.Image = Global.StoreBox.My.Resources.Resources.无标题
        Me.Btn_QuXiao.Location = New System.Drawing.Point(12, 12)
        Me.Btn_QuXiao.Name = "Btn_QuXiao"
        Me.Btn_QuXiao.Size = New System.Drawing.Size(180, 80)
        Me.Btn_QuXiao.TabIndex = 7
        Me.Btn_QuXiao.TabStop = False
        Me.Btn_QuXiao.Text = "返回"
        Me.Btn_QuXiao.UseVisualStyleBackColor = False
        '
        'Frm_YeWuBanLi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1022, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_QuXiao)
        Me.Controls.Add(Me.Lbl_TiShi)
        Me.Controls.Add(Me.Btn_GuanLiYuanYeWu)
        Me.Controls.Add(Me.Btn_KuaiDiYuanYeWu)
        Me.Controls.Add(Me.Btn_WoYaoJiCun)
        Me.Controls.Add(Me.Btn_WoYaoShouJian)
        Me.Controls.Add(Me.Btn_WoYaoJiJian)
        Me.Controls.Add(Me.Lbl_Head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_YeWuBanLi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Head As System.Windows.Forms.Label
    Friend WithEvents Btn_WoYaoJiJian As System.Windows.Forms.Button
    Friend WithEvents Btn_WoYaoShouJian As System.Windows.Forms.Button
    Friend WithEvents Btn_WoYaoJiCun As System.Windows.Forms.Button
    Friend WithEvents Btn_KuaiDiYuanYeWu As System.Windows.Forms.Button
    Friend WithEvents Btn_GuanLiYuanYeWu As System.Windows.Forms.Button
    Friend WithEvents Lbl_TiShi As System.Windows.Forms.Label
    Friend WithEvents Timer_DaoJiShi As System.Windows.Forms.Timer
    Friend WithEvents Btn_QuXiao As System.Windows.Forms.Button
End Class
