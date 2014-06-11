<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_JiJianRenShouJi
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
        Me.TxtB_ShouJiHao = New System.Windows.Forms.TextBox()
        Me.Lab_DaoJiShi = New System.Windows.Forms.Label()
        Me.Timer_DaoJiShi = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_TiShi = New System.Windows.Forms.Label()
        Me.Lbl_Head = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_9 = New System.Windows.Forms.Button()
        Me.Btn_8 = New System.Windows.Forms.Button()
        Me.Btn_XiaYiBu = New System.Windows.Forms.Button()
        Me.Btn_7 = New System.Windows.Forms.Button()
        Me.Btn_0 = New System.Windows.Forms.Button()
        Me.Btn_6 = New System.Windows.Forms.Button()
        Me.Btn_5 = New System.Windows.Forms.Button()
        Me.Btn_4 = New System.Windows.Forms.Button()
        Me.Btn_BK = New System.Windows.Forms.Button()
        Me.Btn_3 = New System.Windows.Forms.Button()
        Me.Btn_2 = New System.Windows.Forms.Button()
        Me.Btn_1 = New System.Windows.Forms.Button()
        Me.Btn_ShangYiBu = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtB_ShouJiHao
        '
        Me.TxtB_ShouJiHao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtB_ShouJiHao.Font = New System.Drawing.Font("Microsoft YaHei", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtB_ShouJiHao.Location = New System.Drawing.Point(320, 221)
        Me.TxtB_ShouJiHao.MaxLength = 11
        Me.TxtB_ShouJiHao.Name = "TxtB_ShouJiHao"
        Me.TxtB_ShouJiHao.Size = New System.Drawing.Size(355, 47)
        Me.TxtB_ShouJiHao.TabIndex = 1
        Me.TxtB_ShouJiHao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lab_DaoJiShi
        '
        Me.Lab_DaoJiShi.BackColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lab_DaoJiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Location = New System.Drawing.Point(15, 1)
        Me.Lab_DaoJiShi.Name = "Lab_DaoJiShi"
        Me.Lab_DaoJiShi.Size = New System.Drawing.Size(64, 60)
        Me.Lab_DaoJiShi.TabIndex = 42
        Me.Lab_DaoJiShi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer_DaoJiShi
        '
        Me.Timer_DaoJiShi.Enabled = True
        Me.Timer_DaoJiShi.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.StoreBox.My.Resources.Resources._06_02
        Me.PictureBox1.Location = New System.Drawing.Point(296, 204)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(398, 79)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'Lbl_TiShi
        '
        Me.Lbl_TiShi.AutoSize = True
        Me.Lbl_TiShi.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TiShi.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_TiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_TiShi.Location = New System.Drawing.Point(278, 102)
        Me.Lbl_TiShi.Name = "Lbl_TiShi"
        Me.Lbl_TiShi.Size = New System.Drawing.Size(452, 38)
        Me.Lbl_TiShi.TabIndex = 47
        Me.Lbl_TiShi.Text = "友情提示：请正确输入手机号码！"
        '
        'Lbl_Head
        '
        Me.Lbl_Head.AutoSize = True
        Me.Lbl_Head.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Font = New System.Drawing.Font("Microsoft YaHei", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Head.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Location = New System.Drawing.Point(304, 5)
        Me.Lbl_Head.Name = "Lbl_Head"
        Me.Lbl_Head.Size = New System.Drawing.Size(368, 75)
        Me.Lbl_Head.TabIndex = 48
        Me.Lbl_Head.Text = "寄件人手机号"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.StoreBox.My.Resources.Resources._06_04
        Me.Panel1.Controls.Add(Me.Btn_9)
        Me.Panel1.Controls.Add(Me.Btn_8)
        Me.Panel1.Controls.Add(Me.Btn_XiaYiBu)
        Me.Panel1.Controls.Add(Me.Btn_7)
        Me.Panel1.Controls.Add(Me.Btn_0)
        Me.Panel1.Controls.Add(Me.Btn_6)
        Me.Panel1.Controls.Add(Me.Btn_5)
        Me.Panel1.Controls.Add(Me.Btn_4)
        Me.Panel1.Controls.Add(Me.Btn_BK)
        Me.Panel1.Controls.Add(Me.Btn_3)
        Me.Panel1.Controls.Add(Me.Btn_2)
        Me.Panel1.Controls.Add(Me.Btn_1)
        Me.Panel1.Location = New System.Drawing.Point(297, 302)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 310)
        Me.Panel1.TabIndex = 49
        '
        'Btn_9
        '
        Me.Btn_9.BackColor = System.Drawing.Color.Transparent
        Me.Btn_9.BackgroundImage = Global.StoreBox.My.Resources.Resources._06_05
        Me.Btn_9.FlatAppearance.BorderSize = 0
        Me.Btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_9.Font = New System.Drawing.Font("SimSun", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_9.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_9.Location = New System.Drawing.Point(204, 214)
        Me.Btn_9.Name = "Btn_9"
        Me.Btn_9.Size = New System.Drawing.Size(88, 88)
        Me.Btn_9.TabIndex = 33
        Me.Btn_9.Text = "9"
        Me.Btn_9.UseVisualStyleBackColor = False
        '
        'Btn_8
        '
        Me.Btn_8.BackColor = System.Drawing.Color.Transparent
        Me.Btn_8.BackgroundImage = Global.StoreBox.My.Resources.Resources._06_05
        Me.Btn_8.FlatAppearance.BorderSize = 0
        Me.Btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_8.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_8.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_8.Location = New System.Drawing.Point(105, 214)
        Me.Btn_8.Name = "Btn_8"
        Me.Btn_8.Size = New System.Drawing.Size(88, 88)
        Me.Btn_8.TabIndex = 32
        Me.Btn_8.Text = "8"
        Me.Btn_8.UseVisualStyleBackColor = False
        '
        'Btn_XiaYiBu
        '
        Me.Btn_XiaYiBu.BackColor = System.Drawing.Color.Transparent
        Me.Btn_XiaYiBu.BackgroundImage = Global.StoreBox.My.Resources.Resources._06_05
        Me.Btn_XiaYiBu.FlatAppearance.BorderSize = 0
        Me.Btn_XiaYiBu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_XiaYiBu.Font = New System.Drawing.Font("SimSun", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_XiaYiBu.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_XiaYiBu.Location = New System.Drawing.Point(303, 214)
        Me.Btn_XiaYiBu.Name = "Btn_XiaYiBu"
        Me.Btn_XiaYiBu.Size = New System.Drawing.Size(88, 88)
        Me.Btn_XiaYiBu.TabIndex = 32
        Me.Btn_XiaYiBu.Text = "确认"
        Me.Btn_XiaYiBu.UseVisualStyleBackColor = False
        '
        'Btn_7
        '
        Me.Btn_7.BackColor = System.Drawing.Color.Transparent
        Me.Btn_7.BackgroundImage = Global.StoreBox.My.Resources.Resources._06_05
        Me.Btn_7.FlatAppearance.BorderSize = 0
        Me.Btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_7.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_7.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_7.Location = New System.Drawing.Point(7, 214)
        Me.Btn_7.Name = "Btn_7"
        Me.Btn_7.Size = New System.Drawing.Size(88, 88)
        Me.Btn_7.TabIndex = 29
        Me.Btn_7.Text = "7"
        Me.Btn_7.UseVisualStyleBackColor = False
        '
        'Btn_0
        '
        Me.Btn_0.BackColor = System.Drawing.Color.Transparent
        Me.Btn_0.BackgroundImage = Global.StoreBox.My.Resources.Resources._06_05
        Me.Btn_0.FlatAppearance.BorderSize = 0
        Me.Btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_0.Font = New System.Drawing.Font("SimSun", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_0.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_0.Location = New System.Drawing.Point(303, 114)
        Me.Btn_0.Name = "Btn_0"
        Me.Btn_0.Size = New System.Drawing.Size(88, 88)
        Me.Btn_0.TabIndex = 31
        Me.Btn_0.Text = "0"
        Me.Btn_0.UseVisualStyleBackColor = False
        '
        'Btn_6
        '
        Me.Btn_6.BackColor = System.Drawing.Color.Transparent
        Me.Btn_6.BackgroundImage = Global.StoreBox.My.Resources.Resources._06_05
        Me.Btn_6.FlatAppearance.BorderSize = 0
        Me.Btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_6.Font = New System.Drawing.Font("SimSun", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_6.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_6.Location = New System.Drawing.Point(204, 114)
        Me.Btn_6.Name = "Btn_6"
        Me.Btn_6.Size = New System.Drawing.Size(88, 88)
        Me.Btn_6.TabIndex = 30
        Me.Btn_6.Text = "6"
        Me.Btn_6.UseVisualStyleBackColor = False
        '
        'Btn_5
        '
        Me.Btn_5.BackColor = System.Drawing.Color.Transparent
        Me.Btn_5.BackgroundImage = Global.StoreBox.My.Resources.Resources._06_05
        Me.Btn_5.FlatAppearance.BorderSize = 0
        Me.Btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_5.Font = New System.Drawing.Font("SimSun", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_5.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_5.Location = New System.Drawing.Point(105, 114)
        Me.Btn_5.Name = "Btn_5"
        Me.Btn_5.Size = New System.Drawing.Size(88, 88)
        Me.Btn_5.TabIndex = 29
        Me.Btn_5.Text = "5"
        Me.Btn_5.UseVisualStyleBackColor = False
        '
        'Btn_4
        '
        Me.Btn_4.BackColor = System.Drawing.Color.Transparent
        Me.Btn_4.BackgroundImage = Global.StoreBox.My.Resources.Resources._06_05
        Me.Btn_4.FlatAppearance.BorderSize = 0
        Me.Btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_4.Font = New System.Drawing.Font("SimSun", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_4.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_4.Location = New System.Drawing.Point(7, 114)
        Me.Btn_4.Name = "Btn_4"
        Me.Btn_4.Size = New System.Drawing.Size(88, 88)
        Me.Btn_4.TabIndex = 29
        Me.Btn_4.Text = "4"
        Me.Btn_4.UseVisualStyleBackColor = False
        '
        'Btn_BK
        '
        Me.Btn_BK.FlatAppearance.BorderSize = 0
        Me.Btn_BK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BK.Font = New System.Drawing.Font("SimSun", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_BK.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_BK.Image = Global.StoreBox.My.Resources.Resources._06_05
        Me.Btn_BK.Location = New System.Drawing.Point(303, 10)
        Me.Btn_BK.Name = "Btn_BK"
        Me.Btn_BK.Size = New System.Drawing.Size(88, 88)
        Me.Btn_BK.TabIndex = 11
        Me.Btn_BK.Text = "删除"
        Me.Btn_BK.UseVisualStyleBackColor = True
        '
        'Btn_3
        '
        Me.Btn_3.BackgroundImage = Global.StoreBox.My.Resources.Resources._06_05
        Me.Btn_3.FlatAppearance.BorderSize = 0
        Me.Btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_3.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_3.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_3.Location = New System.Drawing.Point(204, 10)
        Me.Btn_3.Name = "Btn_3"
        Me.Btn_3.Size = New System.Drawing.Size(88, 88)
        Me.Btn_3.TabIndex = 2
        Me.Btn_3.Text = "3"
        Me.Btn_3.UseVisualStyleBackColor = True
        '
        'Btn_2
        '
        Me.Btn_2.BackColor = System.Drawing.Color.Transparent
        Me.Btn_2.BackgroundImage = Global.StoreBox.My.Resources.Resources._06_05
        Me.Btn_2.FlatAppearance.BorderSize = 0
        Me.Btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_2.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_2.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_2.Location = New System.Drawing.Point(105, 10)
        Me.Btn_2.Name = "Btn_2"
        Me.Btn_2.Size = New System.Drawing.Size(88, 88)
        Me.Btn_2.TabIndex = 1
        Me.Btn_2.Text = "2"
        Me.Btn_2.UseVisualStyleBackColor = False
        '
        'Btn_1
        '
        Me.Btn_1.BackColor = System.Drawing.Color.Transparent
        Me.Btn_1.BackgroundImage = Global.StoreBox.My.Resources.Resources._06_05
        Me.Btn_1.FlatAppearance.BorderSize = 0
        Me.Btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_1.Font = New System.Drawing.Font("SimSun", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_1.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_1.Location = New System.Drawing.Point(7, 10)
        Me.Btn_1.Name = "Btn_1"
        Me.Btn_1.Size = New System.Drawing.Size(88, 88)
        Me.Btn_1.TabIndex = 0
        Me.Btn_1.Text = "1"
        Me.Btn_1.UseVisualStyleBackColor = False
        '
        'Btn_ShangYiBu
        '
        Me.Btn_ShangYiBu.BackColor = System.Drawing.Color.Transparent
        Me.Btn_ShangYiBu.FlatAppearance.BorderSize = 0
        Me.Btn_ShangYiBu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ShangYiBu.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_ShangYiBu.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_ShangYiBu.Image = Global.StoreBox.My.Resources.Resources.无标题
        Me.Btn_ShangYiBu.Location = New System.Drawing.Point(12, 12)
        Me.Btn_ShangYiBu.Name = "Btn_ShangYiBu"
        Me.Btn_ShangYiBu.Size = New System.Drawing.Size(180, 80)
        Me.Btn_ShangYiBu.TabIndex = 51
        Me.Btn_ShangYiBu.Text = "返回"
        Me.Btn_ShangYiBu.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.StoreBox.My.Resources.Resources._07_03
        Me.Panel5.Controls.Add(Me.Lab_DaoJiShi)
        Me.Panel5.Location = New System.Drawing.Point(835, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(158, 62)
        Me.Panel5.TabIndex = 55
        '
        'Frm_JiJianRenShouJi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1022, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_ShangYiBu)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lbl_Head)
        Me.Controls.Add(Me.Lbl_TiShi)
        Me.Controls.Add(Me.TxtB_ShouJiHao)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_JiJianRenShouJi"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtB_ShouJiHao As System.Windows.Forms.TextBox
    Friend WithEvents Lab_DaoJiShi As System.Windows.Forms.Label
    Friend WithEvents Timer_DaoJiShi As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_TiShi As System.Windows.Forms.Label
    Friend WithEvents Lbl_Head As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btn_9 As System.Windows.Forms.Button
    Friend WithEvents Btn_8 As System.Windows.Forms.Button
    Friend WithEvents Btn_XiaYiBu As System.Windows.Forms.Button
    Friend WithEvents Btn_7 As System.Windows.Forms.Button
    Friend WithEvents Btn_0 As System.Windows.Forms.Button
    Friend WithEvents Btn_6 As System.Windows.Forms.Button
    Friend WithEvents Btn_5 As System.Windows.Forms.Button
    Friend WithEvents Btn_4 As System.Windows.Forms.Button
    Friend WithEvents Btn_BK As System.Windows.Forms.Button
    Friend WithEvents Btn_3 As System.Windows.Forms.Button
    Friend WithEvents Btn_2 As System.Windows.Forms.Button
    Friend WithEvents Btn_1 As System.Windows.Forms.Button
    Friend WithEvents Btn_ShangYiBu As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
