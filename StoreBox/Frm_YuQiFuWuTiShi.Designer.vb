<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_YuQiFuWuTiShi
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
        Me.Btn_WoYaoFuFei = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_JinE = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Head = New System.Windows.Forms.Label()
        Me.Lbl_S = New System.Windows.Forms.Label()
        Me.Lbl_Timer = New System.Windows.Forms.Label()
        Me.Timer_DaoJiShi = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_QuXiao = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Prev = New System.Windows.Forms.Button()
        Me.Lab_DaoJiShi = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_WoYaoFuFei
        '
        Me.Btn_WoYaoFuFei.BackColor = System.Drawing.Color.Transparent
        Me.Btn_WoYaoFuFei.FlatAppearance.BorderSize = 0
        Me.Btn_WoYaoFuFei.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_WoYaoFuFei.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_WoYaoFuFei.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_WoYaoFuFei.Image = Global.StoreBox.My.Resources.Resources._02_04
        Me.Btn_WoYaoFuFei.Location = New System.Drawing.Point(350, 192)
        Me.Btn_WoYaoFuFei.Name = "Btn_WoYaoFuFei"
        Me.Btn_WoYaoFuFei.Size = New System.Drawing.Size(330, 150)
        Me.Btn_WoYaoFuFei.TabIndex = 18
        Me.Btn_WoYaoFuFei.Text = "我要付费"
        Me.Btn_WoYaoFuFei.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(229, 610)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(351, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "1:当天取件，次日上午送达的快递服务。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(229, 576)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 31)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "付费说明："
        '
        'Lbl_JinE
        '
        Me.Lbl_JinE.AutoSize = True
        Me.Lbl_JinE.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_JinE.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_JinE.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_JinE.Location = New System.Drawing.Point(646, 118)
        Me.Lbl_JinE.Name = "Lbl_JinE"
        Me.Lbl_JinE.Size = New System.Drawing.Size(34, 38)
        Me.Lbl_JinE.TabIndex = 15
        Me.Lbl_JinE.Text = "5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(300, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 38)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "您需要交纳的逾期服务费："
        '
        'Lbl_Head
        '
        Me.Lbl_Head.AutoSize = True
        Me.Lbl_Head.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Head.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Location = New System.Drawing.Point(320, 22)
        Me.Lbl_Head.Name = "Lbl_Head"
        Me.Lbl_Head.Size = New System.Drawing.Size(368, 75)
        Me.Lbl_Head.TabIndex = 12
        Me.Lbl_Head.Text = "逾期服务提示"
        '
        'Lbl_S
        '
        Me.Lbl_S.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_S.Location = New System.Drawing.Point(890, 223)
        Me.Lbl_S.Name = "Lbl_S"
        Me.Lbl_S.Size = New System.Drawing.Size(21, 21)
        Me.Lbl_S.TabIndex = 23
        Me.Lbl_S.Text = "s"
        Me.Lbl_S.Visible = False
        '
        'Lbl_Timer
        '
        Me.Lbl_Timer.AutoSize = True
        Me.Lbl_Timer.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Timer.Location = New System.Drawing.Point(741, 305)
        Me.Lbl_Timer.Name = "Lbl_Timer"
        Me.Lbl_Timer.Size = New System.Drawing.Size(136, 21)
        Me.Lbl_Timer.TabIndex = 22
        Me.Lbl_Timer.Text = "投币倒计时："
        Me.Lbl_Timer.Visible = False
        '
        'Timer_DaoJiShi
        '
        Me.Timer_DaoJiShi.Enabled = True
        Me.Timer_DaoJiShi.Interval = 1000
        '
        'Btn_QuXiao
        '
        Me.Btn_QuXiao.BackColor = System.Drawing.Color.Transparent
        Me.Btn_QuXiao.FlatAppearance.BorderSize = 0
        Me.Btn_QuXiao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_QuXiao.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_QuXiao.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_QuXiao.Image = Global.StoreBox.My.Resources.Resources._02_06
        Me.Btn_QuXiao.Location = New System.Drawing.Point(350, 348)
        Me.Btn_QuXiao.Name = "Btn_QuXiao"
        Me.Btn_QuXiao.Size = New System.Drawing.Size(330, 150)
        Me.Btn_QuXiao.TabIndex = 26
        Me.Btn_QuXiao.Text = "取  消"
        Me.Btn_QuXiao.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(229, 639)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(558, 25)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "2:快递到达物箱后6小时免费，超过6小时每小时1元，10元封顶！"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(671, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 38)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "元"
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
        Me.Btn_Prev.TabIndex = 39
        Me.Btn_Prev.Text = "返回"
        Me.Btn_Prev.UseVisualStyleBackColor = False
        '
        'Lab_DaoJiShi
        '
        Me.Lab_DaoJiShi.BackColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lab_DaoJiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Location = New System.Drawing.Point(14, 1)
        Me.Lab_DaoJiShi.Name = "Lab_DaoJiShi"
        Me.Lab_DaoJiShi.Size = New System.Drawing.Size(134, 60)
        Me.Lab_DaoJiShi.TabIndex = 40
        Me.Lab_DaoJiShi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.StoreBox.My.Resources.Resources._24_03
        Me.PictureBox1.Location = New System.Drawing.Point(219, 569)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(602, 102)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
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
        'Frm_YuQiFuWuTiShi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1022, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Prev)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lbl_S)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Btn_QuXiao)
        Me.Controls.Add(Me.Lbl_Timer)
        Me.Controls.Add(Me.Btn_WoYaoFuFei)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lbl_JinE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl_Head)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_YuQiFuWuTiShi"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_WoYaoFuFei As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_JinE As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Head As System.Windows.Forms.Label
    Friend WithEvents Lbl_S As System.Windows.Forms.Label
    Friend WithEvents Lbl_Timer As System.Windows.Forms.Label
    Friend WithEvents Timer_DaoJiShi As System.Windows.Forms.Timer
    Friend WithEvents Btn_QuXiao As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btn_Prev As System.Windows.Forms.Button
    Friend WithEvents Lab_DaoJiShi As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
