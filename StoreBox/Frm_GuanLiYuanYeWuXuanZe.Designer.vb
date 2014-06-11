<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GuanLiYuanYeWuXuanZe
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
        Me.Btn_WeiHu = New System.Windows.Forms.Button()
        Me.Btn_PeiZhi = New System.Windows.Forms.Button()
        Me.Lbl_Head = New System.Windows.Forms.Label()
        Me.Lbl_S = New System.Windows.Forms.Label()
        Me.Lbl_Timer = New System.Windows.Forms.Label()
        Me.btn_TongBuWuXiang = New System.Windows.Forms.Button()
        Me.btn_GengXinKuaiDi = New System.Windows.Forms.Button()
        Me.Btn_prev = New System.Windows.Forms.Button()
        Me.Lab_DaoJiShi = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_DaoJiShi
        '
        Me.Timer_DaoJiShi.Enabled = True
        Me.Timer_DaoJiShi.Interval = 1000
        '
        'Btn_WeiHu
        '
        Me.Btn_WeiHu.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_WeiHu.FlatAppearance.BorderSize = 0
        Me.Btn_WeiHu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_WeiHu.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_WeiHu.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_WeiHu.Image = Global.StoreBox.My.Resources.Resources._02_04
        Me.Btn_WeiHu.Location = New System.Drawing.Point(526, 207)
        Me.Btn_WeiHu.Name = "Btn_WeiHu"
        Me.Btn_WeiHu.Size = New System.Drawing.Size(330, 150)
        Me.Btn_WeiHu.TabIndex = 37
        Me.Btn_WeiHu.Text = "维  护"
        Me.Btn_WeiHu.UseVisualStyleBackColor = False
        '
        'Btn_PeiZhi
        '
        Me.Btn_PeiZhi.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_PeiZhi.FlatAppearance.BorderSize = 0
        Me.Btn_PeiZhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_PeiZhi.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_PeiZhi.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_PeiZhi.Image = Global.StoreBox.My.Resources.Resources._02_06
        Me.Btn_PeiZhi.Location = New System.Drawing.Point(190, 207)
        Me.Btn_PeiZhi.Name = "Btn_PeiZhi"
        Me.Btn_PeiZhi.Size = New System.Drawing.Size(330, 150)
        Me.Btn_PeiZhi.TabIndex = 36
        Me.Btn_PeiZhi.Text = "配  置"
        Me.Btn_PeiZhi.UseVisualStyleBackColor = False
        '
        'Lbl_Head
        '
        Me.Lbl_Head.AutoSize = True
        Me.Lbl_Head.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Font = New System.Drawing.Font("Microsoft YaHei", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Head.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Location = New System.Drawing.Point(307, 5)
        Me.Lbl_Head.Name = "Lbl_Head"
        Me.Lbl_Head.Size = New System.Drawing.Size(424, 75)
        Me.Lbl_Head.TabIndex = 31
        Me.Lbl_Head.Text = "管理员业务选择"
        '
        'Lbl_S
        '
        Me.Lbl_S.Font = New System.Drawing.Font("SimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_S.Location = New System.Drawing.Point(973, 373)
        Me.Lbl_S.Name = "Lbl_S"
        Me.Lbl_S.Size = New System.Drawing.Size(21, 21)
        Me.Lbl_S.TabIndex = 41
        Me.Lbl_S.Text = "s"
        Me.Lbl_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lbl_S.Visible = False
        '
        'Lbl_Timer
        '
        Me.Lbl_Timer.AutoSize = True
        Me.Lbl_Timer.Font = New System.Drawing.Font("SimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Timer.Location = New System.Drawing.Point(831, 373)
        Me.Lbl_Timer.Name = "Lbl_Timer"
        Me.Lbl_Timer.Size = New System.Drawing.Size(136, 21)
        Me.Lbl_Timer.TabIndex = 40
        Me.Lbl_Timer.Text = "操作倒计时："
        Me.Lbl_Timer.Visible = False
        '
        'btn_TongBuWuXiang
        '
        Me.btn_TongBuWuXiang.BackColor = System.Drawing.SystemColors.Control
        Me.btn_TongBuWuXiang.FlatAppearance.BorderSize = 0
        Me.btn_TongBuWuXiang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_TongBuWuXiang.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_TongBuWuXiang.ForeColor = System.Drawing.Color.Transparent
        Me.btn_TongBuWuXiang.Image = Global.StoreBox.My.Resources.Resources._02_05
        Me.btn_TongBuWuXiang.Location = New System.Drawing.Point(190, 363)
        Me.btn_TongBuWuXiang.Name = "btn_TongBuWuXiang"
        Me.btn_TongBuWuXiang.Size = New System.Drawing.Size(330, 150)
        Me.btn_TongBuWuXiang.TabIndex = 44
        Me.btn_TongBuWuXiang.Text = "同步物箱状态"
        Me.btn_TongBuWuXiang.UseVisualStyleBackColor = False
        '
        'btn_GengXinKuaiDi
        '
        Me.btn_GengXinKuaiDi.BackColor = System.Drawing.SystemColors.Control
        Me.btn_GengXinKuaiDi.FlatAppearance.BorderSize = 0
        Me.btn_GengXinKuaiDi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_GengXinKuaiDi.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_GengXinKuaiDi.ForeColor = System.Drawing.Color.Transparent
        Me.btn_GengXinKuaiDi.Image = Global.StoreBox.My.Resources.Resources.绿色_大
        Me.btn_GengXinKuaiDi.Location = New System.Drawing.Point(526, 363)
        Me.btn_GengXinKuaiDi.Name = "btn_GengXinKuaiDi"
        Me.btn_GengXinKuaiDi.Size = New System.Drawing.Size(330, 150)
        Me.btn_GengXinKuaiDi.TabIndex = 45
        Me.btn_GengXinKuaiDi.Text = "更新快递员"
        Me.btn_GengXinKuaiDi.UseVisualStyleBackColor = False
        '
        'Btn_prev
        '
        Me.Btn_prev.BackColor = System.Drawing.Color.Transparent
        Me.Btn_prev.FlatAppearance.BorderSize = 0
        Me.Btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_prev.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Btn_prev.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_prev.Image = Global.StoreBox.My.Resources.Resources.无标题
        Me.Btn_prev.Location = New System.Drawing.Point(12, 12)
        Me.Btn_prev.Name = "Btn_prev"
        Me.Btn_prev.Size = New System.Drawing.Size(180, 80)
        Me.Btn_prev.TabIndex = 46
        Me.Btn_prev.Text = "返回"
        Me.Btn_prev.UseVisualStyleBackColor = False
        '
        'Lab_DaoJiShi
        '
        Me.Lab_DaoJiShi.BackColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lab_DaoJiShi.ForeColor = System.Drawing.Color.Transparent
        Me.Lab_DaoJiShi.Location = New System.Drawing.Point(11, 0)
        Me.Lab_DaoJiShi.Name = "Lab_DaoJiShi"
        Me.Lab_DaoJiShi.Size = New System.Drawing.Size(134, 62)
        Me.Lab_DaoJiShi.TabIndex = 47
        Me.Lab_DaoJiShi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Button1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(190, 519)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(666, 136)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "退出程序"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Frm_GuanLiYuanYeWuXuanZe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1022, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_prev)
        Me.Controls.Add(Me.btn_GengXinKuaiDi)
        Me.Controls.Add(Me.btn_TongBuWuXiang)
        Me.Controls.Add(Me.Lbl_S)
        Me.Controls.Add(Me.Lbl_Timer)
        Me.Controls.Add(Me.Btn_WeiHu)
        Me.Controls.Add(Me.Btn_PeiZhi)
        Me.Controls.Add(Me.Lbl_Head)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_GuanLiYuanYeWuXuanZe"
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer_DaoJiShi As System.Windows.Forms.Timer
    Friend WithEvents Btn_WeiHu As System.Windows.Forms.Button
    Friend WithEvents Btn_PeiZhi As System.Windows.Forms.Button
    Friend WithEvents Lbl_Head As System.Windows.Forms.Label
    Friend WithEvents Lbl_S As System.Windows.Forms.Label
    Friend WithEvents Lbl_Timer As System.Windows.Forms.Label
    Friend WithEvents btn_TongBuWuXiang As System.Windows.Forms.Button
    Friend WithEvents btn_GengXinKuaiDi As System.Windows.Forms.Button
    Friend WithEvents Btn_prev As System.Windows.Forms.Button
    Friend WithEvents Lab_DaoJiShi As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
