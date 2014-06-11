<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AllFuFeiTouBiTiShi
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
        Me.Btn_QuXiao = New System.Windows.Forms.Button()
        Me.Timer_DaoJiShi = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_TouBi = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_Head = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_JinE = New System.Windows.Forms.Label()
        Me.Lab_DaoJiShi = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_QuXiao
        '
        Me.Btn_QuXiao.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_QuXiao.FlatAppearance.BorderSize = 0
        Me.Btn_QuXiao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_QuXiao.Font = New System.Drawing.Font("Microsoft YaHei", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_QuXiao.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_QuXiao.Image = Global.StoreBox.My.Resources.Resources._02_04
        Me.Btn_QuXiao.Location = New System.Drawing.Point(514, 435)
        Me.Btn_QuXiao.Name = "Btn_QuXiao"
        Me.Btn_QuXiao.Size = New System.Drawing.Size(328, 150)
        Me.Btn_QuXiao.TabIndex = 27
        Me.Btn_QuXiao.Text = "取  消"
        Me.Btn_QuXiao.UseVisualStyleBackColor = False
        '
        'Timer_DaoJiShi
        '
        Me.Timer_DaoJiShi.Enabled = True
        Me.Timer_DaoJiShi.Interval = 1000
        '
        'Btn_TouBi
        '
        Me.Btn_TouBi.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_TouBi.FlatAppearance.BorderSize = 0
        Me.Btn_TouBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_TouBi.Font = New System.Drawing.Font("Microsoft YaHei", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_TouBi.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_TouBi.Image = Global.StoreBox.My.Resources.Resources._02_06
        Me.Btn_TouBi.Location = New System.Drawing.Point(147, 435)
        Me.Btn_TouBi.Name = "Btn_TouBi"
        Me.Btn_TouBi.Size = New System.Drawing.Size(330, 150)
        Me.Btn_TouBi.TabIndex = 23
        Me.Btn_TouBi.Text = "投  币"
        Me.Btn_TouBi.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(24, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(256, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "1:没有退币功能，请确认你有"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(22, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 38)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "重要提示："
        '
        'Lbl_Head
        '
        Me.Lbl_Head.AutoSize = True
        Me.Lbl_Head.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Font = New System.Drawing.Font("Microsoft YaHei", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Head.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Location = New System.Drawing.Point(356, 5)
        Me.Lbl_Head.Name = "Lbl_Head"
        Me.Lbl_Head.Size = New System.Drawing.Size(256, 75)
        Me.Lbl_Head.TabIndex = 18
        Me.Lbl_Head.Text = "付费须知"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(24, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(351, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "3:付费后无法取消或归还，请谨慎投币。"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(24, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(544, 25)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "2:投币间隔60秒，如超时则投币是失败，且已投硬币无法归还。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(303, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 25)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "个一元硬币，然后点击""投币""。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Lbl_JinE
        '
        Me.Lbl_JinE.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_JinE.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_JinE.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_JinE.Location = New System.Drawing.Point(271, 72)
        Me.Lbl_JinE.Name = "Lbl_JinE"
        Me.Lbl_JinE.Size = New System.Drawing.Size(36, 25)
        Me.Lbl_JinE.TabIndex = 35
        Me.Lbl_JinE.Text = "0"
        Me.Lbl_JinE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lab_DaoJiShi
        '
        Me.Lab_DaoJiShi.BackColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lab_DaoJiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Location = New System.Drawing.Point(15, 1)
        Me.Lab_DaoJiShi.Name = "Lab_DaoJiShi"
        Me.Lab_DaoJiShi.Size = New System.Drawing.Size(64, 60)
        Me.Lab_DaoJiShi.TabIndex = 49
        Me.Lab_DaoJiShi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.StoreBox.My.Resources.Resources._25_02
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Lbl_JinE)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(147, 182)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(695, 235)
        Me.Panel1.TabIndex = 51
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.StoreBox.My.Resources.Resources._07_03
        Me.Panel5.Controls.Add(Me.Lab_DaoJiShi)
        Me.Panel5.Location = New System.Drawing.Point(835, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(158, 62)
        Me.Panel5.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(531, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 41)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "5元"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(358, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 41)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "您需付费："
        '
        'Frm_AllFuFeiTouBiTiShi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Btn_QuXiao)
        Me.Controls.Add(Me.Btn_TouBi)
        Me.Controls.Add(Me.Lbl_Head)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_AllFuFeiTouBiTiShi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_QuXiao As System.Windows.Forms.Button
    Friend WithEvents Timer_DaoJiShi As System.Windows.Forms.Timer
    Friend WithEvents Btn_TouBi As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Head As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_JinE As System.Windows.Forms.Label
    Friend WithEvents Lab_DaoJiShi As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
