<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_KuaiDiDanSaoMiao
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
        Me.Lbl_Timer = New System.Windows.Forms.Label()
        Me.Btn_ShouGongShuRu = New System.Windows.Forms.Button()
        Me.Lab_DaoJiShi = New System.Windows.Forms.Label()
        Me.Timer_DaoJiShi = New System.Windows.Forms.Timer(Me.components)
        Me.TxtB_KuaiDiDanHao = New System.Windows.Forms.TextBox()
        Me.Btn_XiaYiBu = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_ShangYiBu = New System.Windows.Forms.Button()
        Me.Lbl_Head = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_S = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Timer
        '
        Me.Lbl_Timer.AutoSize = True
        Me.Lbl_Timer.Font = New System.Drawing.Font("SimSun", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Timer.Location = New System.Drawing.Point(821, 279)
        Me.Lbl_Timer.Name = "Lbl_Timer"
        Me.Lbl_Timer.Size = New System.Drawing.Size(129, 20)
        Me.Lbl_Timer.TabIndex = 1
        Me.Lbl_Timer.Text = "操作倒计时："
        Me.Lbl_Timer.Visible = False
        '
        'Btn_ShouGongShuRu
        '
        Me.Btn_ShouGongShuRu.BackColor = System.Drawing.Color.Transparent
        Me.Btn_ShouGongShuRu.FlatAppearance.BorderSize = 0
        Me.Btn_ShouGongShuRu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ShouGongShuRu.Font = New System.Drawing.Font("Microsoft YaHei", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_ShouGongShuRu.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_ShouGongShuRu.Image = Global.StoreBox.My.Resources.Resources._02_05
        Me.Btn_ShouGongShuRu.Location = New System.Drawing.Point(242, 410)
        Me.Btn_ShouGongShuRu.Name = "Btn_ShouGongShuRu"
        Me.Btn_ShouGongShuRu.Size = New System.Drawing.Size(330, 150)
        Me.Btn_ShouGongShuRu.TabIndex = 6
        Me.Btn_ShouGongShuRu.Text = "手工输入"
        Me.Btn_ShouGongShuRu.UseVisualStyleBackColor = False
        '
        'Lab_DaoJiShi
        '
        Me.Lab_DaoJiShi.BackColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lab_DaoJiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Location = New System.Drawing.Point(16, 0)
        Me.Lab_DaoJiShi.Name = "Lab_DaoJiShi"
        Me.Lab_DaoJiShi.Size = New System.Drawing.Size(64, 60)
        Me.Lab_DaoJiShi.TabIndex = 10
        Me.Lab_DaoJiShi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer_DaoJiShi
        '
        Me.Timer_DaoJiShi.Enabled = True
        Me.Timer_DaoJiShi.Interval = 1000
        '
        'TxtB_KuaiDiDanHao
        '
        Me.TxtB_KuaiDiDanHao.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtB_KuaiDiDanHao.ForeColor = System.Drawing.Color.Black
        Me.TxtB_KuaiDiDanHao.Location = New System.Drawing.Point(242, 188)
        Me.TxtB_KuaiDiDanHao.MaxLength = 20
        Me.TxtB_KuaiDiDanHao.Name = "TxtB_KuaiDiDanHao"
        Me.TxtB_KuaiDiDanHao.ReadOnly = True
        Me.TxtB_KuaiDiDanHao.Size = New System.Drawing.Size(507, 46)
        Me.TxtB_KuaiDiDanHao.TabIndex = 11
        Me.TxtB_KuaiDiDanHao.Text = "请扫描快递单号"
        Me.TxtB_KuaiDiDanHao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_XiaYiBu
        '
        Me.Btn_XiaYiBu.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_XiaYiBu.FlatAppearance.BorderSize = 0
        Me.Btn_XiaYiBu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_XiaYiBu.Font = New System.Drawing.Font("Microsoft YaHei", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_XiaYiBu.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_XiaYiBu.Image = Global.StoreBox.My.Resources.Resources._02_03
        Me.Btn_XiaYiBu.Location = New System.Drawing.Point(589, 410)
        Me.Btn_XiaYiBu.Name = "Btn_XiaYiBu"
        Me.Btn_XiaYiBu.Size = New System.Drawing.Size(160, 150)
        Me.Btn_XiaYiBu.TabIndex = 14
        Me.Btn_XiaYiBu.Text = "下一步"
        Me.Btn_XiaYiBu.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StoreBox.My.Resources.Resources.KuaiDiTou
        Me.PictureBox1.Location = New System.Drawing.Point(242, 253)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(507, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
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
        Me.Btn_ShangYiBu.TabIndex = 23
        Me.Btn_ShangYiBu.Text = "返回"
        Me.Btn_ShangYiBu.UseVisualStyleBackColor = False
        '
        'Lbl_Head
        '
        Me.Lbl_Head.AutoSize = True
        Me.Lbl_Head.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Font = New System.Drawing.Font("Microsoft YaHei", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Head.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Location = New System.Drawing.Point(344, 5)
        Me.Lbl_Head.Name = "Lbl_Head"
        Me.Lbl_Head.Size = New System.Drawing.Size(312, 75)
        Me.Lbl_Head.TabIndex = 50
        Me.Lbl_Head.Text = "快递单扫描"
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
        'lbl_S
        '
        Me.lbl_S.Font = New System.Drawing.Font("SimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_S.Location = New System.Drawing.Point(973, 279)
        Me.lbl_S.Name = "lbl_S"
        Me.lbl_S.Size = New System.Drawing.Size(21, 21)
        Me.lbl_S.TabIndex = 2
        Me.lbl_S.Text = "s"
        Me.lbl_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_S.Visible = False
        '
        'Frm_KuaiDiDanSaoMiao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1022, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl_Head)
        Me.Controls.Add(Me.Btn_ShangYiBu)
        Me.Controls.Add(Me.lbl_S)
        Me.Controls.Add(Me.Btn_XiaYiBu)
        Me.Controls.Add(Me.TxtB_KuaiDiDanHao)
        Me.Controls.Add(Me.Btn_ShouGongShuRu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Lbl_Timer)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_KuaiDiDanSaoMiao"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Timer As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_ShouGongShuRu As System.Windows.Forms.Button
    Friend WithEvents Lab_DaoJiShi As System.Windows.Forms.Label
    Friend WithEvents Timer_DaoJiShi As System.Windows.Forms.Timer
    Friend WithEvents TxtB_KuaiDiDanHao As System.Windows.Forms.TextBox
    Friend WithEvents Btn_XiaYiBu As System.Windows.Forms.Button
    Friend WithEvents Btn_ShangYiBu As System.Windows.Forms.Button
    Friend WithEvents Lbl_Head As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbl_S As System.Windows.Forms.Label
End Class
