<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_YeWuWanChengTiShi
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
        Me.Lbl_TiShi = New System.Windows.Forms.Label()
        Me.Lbl_S = New System.Windows.Forms.Label()
        Me.Lbl_Timer = New System.Windows.Forms.Label()
        Me.Btn_FanHuiZhuYe = New System.Windows.Forms.Button()
        Me.Lab_Daojishi = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_DaoJiShi
        '
        Me.Timer_DaoJiShi.Enabled = True
        Me.Timer_DaoJiShi.Interval = 1000
        '
        'Lbl_TiShi
        '
        Me.Lbl_TiShi.AutoSize = True
        Me.Lbl_TiShi.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TiShi.Font = New System.Drawing.Font("微软雅黑", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_TiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_TiShi.Location = New System.Drawing.Point(348, 346)
        Me.Lbl_TiShi.Name = "Lbl_TiShi"
        Me.Lbl_TiShi.Size = New System.Drawing.Size(378, 46)
        Me.Lbl_TiShi.TabIndex = 33
        Me.Lbl_TiShi.Text = "业务已完成,谢谢使用！"
        '
        'Lbl_S
        '
        Me.Lbl_S.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_S.Location = New System.Drawing.Point(915, 247)
        Me.Lbl_S.Name = "Lbl_S"
        Me.Lbl_S.Size = New System.Drawing.Size(21, 21)
        Me.Lbl_S.TabIndex = 30
        Me.Lbl_S.Text = "s"
        Me.Lbl_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lbl_S.Visible = False
        '
        'Lbl_Timer
        '
        Me.Lbl_Timer.AutoSize = True
        Me.Lbl_Timer.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Timer.Location = New System.Drawing.Point(773, 247)
        Me.Lbl_Timer.Name = "Lbl_Timer"
        Me.Lbl_Timer.Size = New System.Drawing.Size(136, 21)
        Me.Lbl_Timer.TabIndex = 29
        Me.Lbl_Timer.Text = "操作倒计时："
        Me.Lbl_Timer.Visible = False
        '
        'Btn_FanHuiZhuYe
        '
        Me.Btn_FanHuiZhuYe.BackColor = System.Drawing.Color.Transparent
        Me.Btn_FanHuiZhuYe.FlatAppearance.BorderSize = 0
        Me.Btn_FanHuiZhuYe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_FanHuiZhuYe.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_FanHuiZhuYe.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_FanHuiZhuYe.Image = Global.StoreBox.My.Resources.Resources.无标题
        Me.Btn_FanHuiZhuYe.Location = New System.Drawing.Point(12, 12)
        Me.Btn_FanHuiZhuYe.Name = "Btn_FanHuiZhuYe"
        Me.Btn_FanHuiZhuYe.Size = New System.Drawing.Size(180, 80)
        Me.Btn_FanHuiZhuYe.TabIndex = 39
        Me.Btn_FanHuiZhuYe.Text = "返回"
        Me.Btn_FanHuiZhuYe.UseVisualStyleBackColor = False
        '
        'Lab_Daojishi
        '
        Me.Lab_Daojishi.BackColor = System.Drawing.Color.Transparent
        Me.Lab_Daojishi.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lab_Daojishi.ForeColor = System.Drawing.Color.Transparent
        Me.Lab_Daojishi.Location = New System.Drawing.Point(14, 0)
        Me.Lab_Daojishi.Name = "Lab_Daojishi"
        Me.Lab_Daojishi.Size = New System.Drawing.Size(132, 62)
        Me.Lab_Daojishi.TabIndex = 53
        Me.Lab_Daojishi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.StoreBox.My.Resources.Resources._07_03
        Me.Panel5.Controls.Add(Me.Lab_Daojishi)
        Me.Panel5.Location = New System.Drawing.Point(835, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(158, 62)
        Me.Panel5.TabIndex = 55
        '
        'Frm_YeWuWanChengTiShi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1022, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl_S)
        Me.Controls.Add(Me.Btn_FanHuiZhuYe)
        Me.Controls.Add(Me.Lbl_TiShi)
        Me.Controls.Add(Me.Lbl_Timer)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_YeWuWanChengTiShi"
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer_DaoJiShi As System.Windows.Forms.Timer
    Friend WithEvents Lbl_TiShi As System.Windows.Forms.Label
    Friend WithEvents Lbl_S As System.Windows.Forms.Label
    Friend WithEvents Lbl_Timer As System.Windows.Forms.Label
    Friend WithEvents Btn_FanHuiZhuYe As System.Windows.Forms.Button
    Friend WithEvents Lab_Daojishi As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
