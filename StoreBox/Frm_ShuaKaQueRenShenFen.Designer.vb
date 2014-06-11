<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ShuaKaQueRenShenFen
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
        Me.Timer_DaoJiShi = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_Prev = New System.Windows.Forms.Button()
        Me.Lab_DaoJiShi = New System.Windows.Forms.Label()
        Me.Btn_FanHuiZhuYe = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Head
        '
        Me.Lbl_Head.AutoSize = True
        Me.Lbl_Head.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Font = New System.Drawing.Font("Microsoft YaHei", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Head.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Location = New System.Drawing.Point(321, 5)
        Me.Lbl_Head.Name = "Lbl_Head"
        Me.Lbl_Head.Size = New System.Drawing.Size(424, 75)
        Me.Lbl_Head.TabIndex = 0
        Me.Lbl_Head.Text = "请刷卡确认身份"
        '
        'Timer_DaoJiShi
        '
        Me.Timer_DaoJiShi.Enabled = True
        Me.Timer_DaoJiShi.Interval = 1000
        '
        'Btn_Prev
        '
        Me.Btn_Prev.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Prev.FlatAppearance.BorderSize = 0
        Me.Btn_Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Prev.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_Prev.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Prev.Image = Global.StoreBox.My.Resources.Resources.无标题
        Me.Btn_Prev.Location = New System.Drawing.Point(12, 12)
        Me.Btn_Prev.Name = "Btn_Prev"
        Me.Btn_Prev.Size = New System.Drawing.Size(180, 80)
        Me.Btn_Prev.TabIndex = 23
        Me.Btn_Prev.Text = "返回"
        Me.Btn_Prev.UseVisualStyleBackColor = False
        '
        'Lab_DaoJiShi
        '
        Me.Lab_DaoJiShi.BackColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lab_DaoJiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Location = New System.Drawing.Point(14, 1)
        Me.Lab_DaoJiShi.Name = "Lab_DaoJiShi"
        Me.Lab_DaoJiShi.Size = New System.Drawing.Size(134, 60)
        Me.Lab_DaoJiShi.TabIndex = 30
        Me.Lab_DaoJiShi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_FanHuiZhuYe
        '
        Me.Btn_FanHuiZhuYe.Location = New System.Drawing.Point(895, 655)
        Me.Btn_FanHuiZhuYe.Name = "Btn_FanHuiZhuYe"
        Me.Btn_FanHuiZhuYe.Size = New System.Drawing.Size(0, 0)
        Me.Btn_FanHuiZhuYe.TabIndex = 32
        Me.Btn_FanHuiZhuYe.Text = "Button1"
        Me.Btn_FanHuiZhuYe.UseVisualStyleBackColor = True
        Me.Btn_FanHuiZhuYe.Visible = False
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(284, 419)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "模拟刷卡"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_ShuaKaQueRenShenFen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1022, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lbl_Head)
        Me.Controls.Add(Me.Btn_FanHuiZhuYe)
        Me.Controls.Add(Me.Btn_Prev)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ShuaKaQueRenShenFen"
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Head As System.Windows.Forms.Label
    Friend WithEvents Timer_DaoJiShi As System.Windows.Forms.Timer
    Friend WithEvents Btn_Prev As System.Windows.Forms.Button
    Friend WithEvents Lab_DaoJiShi As System.Windows.Forms.Label
    Friend WithEvents Btn_FanHuiZhuYe As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
