<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ShouYe
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
        Me.Bttn_YeWuBanLi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Head
        '
        Me.Lbl_Head.AutoSize = True
        Me.Lbl_Head.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Font = New System.Drawing.Font("微软雅黑", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Head.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_Head.Location = New System.Drawing.Point(138, 24)
        Me.Lbl_Head.Name = "Lbl_Head"
        Me.Lbl_Head.Size = New System.Drawing.Size(759, 62)
        Me.Lbl_Head.TabIndex = 0
        Me.Lbl_Head.Text = "储递宝 iHandbox 智慧储物箱系统"
        '
        'Bttn_YeWuBanLi
        '
        Me.Bttn_YeWuBanLi.BackColor = System.Drawing.Color.Transparent
        Me.Bttn_YeWuBanLi.FlatAppearance.BorderSize = 0
        Me.Bttn_YeWuBanLi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bttn_YeWuBanLi.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Bttn_YeWuBanLi.ForeColor = System.Drawing.Color.Transparent
        Me.Bttn_YeWuBanLi.Image = Global.StoreBox.My.Resources.Resources.绿色_大
        Me.Bttn_YeWuBanLi.Location = New System.Drawing.Point(348, 351)
        Me.Bttn_YeWuBanLi.Name = "Bttn_YeWuBanLi"
        Me.Bttn_YeWuBanLi.Size = New System.Drawing.Size(330, 150)
        Me.Bttn_YeWuBanLi.TabIndex = 5
        Me.Bttn_YeWuBanLi.Text = "业务办理"
        Me.Bttn_YeWuBanLi.UseVisualStyleBackColor = False
        '
        'Frm_ShouYe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StoreBox.My.Resources.Resources._01_01
        Me.ClientSize = New System.Drawing.Size(1022, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.Bttn_YeWuBanLi)
        Me.Controls.Add(Me.Lbl_Head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ShouYe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Head As System.Windows.Forms.Label
    Friend WithEvents Bttn_YeWuBanLi As System.Windows.Forms.Button

End Class
