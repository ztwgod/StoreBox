<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ShuaKaKaiXiangQueRenShenFen
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_S = New System.Windows.Forms.Label()
        Me.Timer_DaoJiShi = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_Prev = New System.Windows.Forms.Button()
        Me.lab_daojishi = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Head
        '
        Me.Lbl_Head.AutoSize = True
        Me.Lbl_Head.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Head.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Location = New System.Drawing.Point(321, 5)
        Me.Lbl_Head.Name = "Lbl_Head"
        Me.Lbl_Head.Size = New System.Drawing.Size(424, 75)
        Me.Lbl_Head.TabIndex = 0
        Me.Lbl_Head.Text = "请刷卡确认身份"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(411, 399)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "操作倒计时:"
        Me.Label2.Visible = False
        '
        'Lbl_S
        '
        Me.Lbl_S.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_S.Location = New System.Drawing.Point(575, 399)
        Me.Lbl_S.Name = "Lbl_S"
        Me.Lbl_S.Size = New System.Drawing.Size(21, 21)
        Me.Lbl_S.TabIndex = 4
        Me.Lbl_S.Text = "s"
        Me.Lbl_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lbl_S.Visible = False
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
        Me.Btn_Prev.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_Prev.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Prev.Image = Global.StoreBox.My.Resources.Resources.无标题
        Me.Btn_Prev.Location = New System.Drawing.Point(12, 12)
        Me.Btn_Prev.Name = "Btn_Prev"
        Me.Btn_Prev.Size = New System.Drawing.Size(180, 80)
        Me.Btn_Prev.TabIndex = 52
        Me.Btn_Prev.Text = "返回"
        Me.Btn_Prev.UseVisualStyleBackColor = False
        '
        'lab_daojishi
        '
        Me.lab_daojishi.BackColor = System.Drawing.Color.Transparent
        Me.lab_daojishi.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lab_daojishi.ForeColor = System.Drawing.Color.Transparent
        Me.lab_daojishi.Location = New System.Drawing.Point(14, 1)
        Me.lab_daojishi.Name = "lab_daojishi"
        Me.lab_daojishi.Size = New System.Drawing.Size(134, 60)
        Me.lab_daojishi.TabIndex = 53
        Me.lab_daojishi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.StoreBox.My.Resources.Resources._07_03
        Me.Panel5.Controls.Add(Me.lab_daojishi)
        Me.Panel5.Location = New System.Drawing.Point(835, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(158, 62)
        Me.Panel5.TabIndex = 55
        '
        'Frm_ShuaKaKaiXiangQueRenShenFen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1022, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Prev)
        Me.Controls.Add(Me.Lbl_S)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl_Head)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ShuaKaKaiXiangQueRenShenFen"
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Head As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_S As System.Windows.Forms.Label
    Friend WithEvents Timer_DaoJiShi As System.Windows.Forms.Timer
    Friend WithEvents Btn_Prev As System.Windows.Forms.Button
    Friend WithEvents lab_daojishi As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
