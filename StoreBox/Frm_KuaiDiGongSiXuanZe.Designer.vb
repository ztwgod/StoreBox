<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_KuaiDiGongSiXuanZe
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
        Me.Lbl_Head = New System.Windows.Forms.Label()
        Me.Btn_YuanTong = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Btn_Prev = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Head
        '
        Me.Lbl_Head.AutoSize = True
        Me.Lbl_Head.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Head.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Location = New System.Drawing.Point(333, -1)
        Me.Lbl_Head.Name = "Lbl_Head"
        Me.Lbl_Head.Size = New System.Drawing.Size(368, 75)
        Me.Lbl_Head.TabIndex = 1
        Me.Lbl_Head.Text = "快递公司选择"
        '
        'Btn_YuanTong
        '
        Me.Btn_YuanTong.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_YuanTong.FlatAppearance.BorderSize = 0
        Me.Btn_YuanTong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_YuanTong.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_YuanTong.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_YuanTong.Image = Global.StoreBox.My.Resources.Resources._02_06
        Me.Btn_YuanTong.Location = New System.Drawing.Point(175, 208)
        Me.Btn_YuanTong.Name = "Btn_YuanTong"
        Me.Btn_YuanTong.Size = New System.Drawing.Size(330, 150)
        Me.Btn_YuanTong.TabIndex = 3
        Me.Btn_YuanTong.Text = "圆通快递"
        Me.Btn_YuanTong.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Image = Global.StoreBox.My.Resources.Resources._02_04
        Me.Button3.Location = New System.Drawing.Point(511, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(330, 150)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "韵达快递"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Image = Global.StoreBox.My.Resources.Resources.绿色_大
        Me.Button4.Location = New System.Drawing.Point(511, 366)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(330, 150)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "其他"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Image = Global.StoreBox.My.Resources.Resources._02_05
        Me.Button5.Location = New System.Drawing.Point(175, 366)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(330, 150)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "申通快递"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Btn_Prev
        '
        Me.Btn_Prev.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Prev.FlatAppearance.BorderSize = 0
        Me.Btn_Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Prev.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_Prev.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Prev.Image = Global.StoreBox.My.Resources.Resources.无标题
        Me.Btn_Prev.Location = New System.Drawing.Point(12, 9)
        Me.Btn_Prev.Name = "Btn_Prev"
        Me.Btn_Prev.Size = New System.Drawing.Size(180, 80)
        Me.Btn_Prev.TabIndex = 8
        Me.Btn_Prev.Text = "返回"
        Me.Btn_Prev.UseVisualStyleBackColor = False
        '
        'Frm_KuaiDiGongSiXuanZe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1022, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Prev)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Btn_YuanTong)
        Me.Controls.Add(Me.Lbl_Head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_KuaiDiGongSiXuanZe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Head As System.Windows.Forms.Label
    Friend WithEvents Btn_YuanTong As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Btn_Prev As System.Windows.Forms.Button
    Friend WithEvents Timer_DaoJiShi As System.Windows.Forms.Timer
End Class
