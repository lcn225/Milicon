<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maintenance_Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Maintenance_Password))
        Me.oldPW_TextBox = New System.Windows.Forms.TextBox()
        Me.newPW_TextBox = New System.Windows.Forms.TextBox()
        Me.renewPW_TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'oldPW_TextBox
        '
        Me.oldPW_TextBox.Location = New System.Drawing.Point(121, 54)
        Me.oldPW_TextBox.Name = "oldPW_TextBox"
        Me.oldPW_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.oldPW_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.oldPW_TextBox.TabIndex = 0
        '
        'newPW_TextBox
        '
        Me.newPW_TextBox.Location = New System.Drawing.Point(121, 100)
        Me.newPW_TextBox.Name = "newPW_TextBox"
        Me.newPW_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newPW_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.newPW_TextBox.TabIndex = 1
        '
        'renewPW_TextBox
        '
        Me.renewPW_TextBox.Location = New System.Drawing.Point(121, 146)
        Me.renewPW_TextBox.Name = "renewPW_TextBox"
        Me.renewPW_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.renewPW_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.renewPW_TextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "旧密码"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "新密码"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "重复新密码"
        '
        'OK_Button
        '
        Me.OK_Button.Enabled = False
        Me.OK_Button.Location = New System.Drawing.Point(289, 47)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(75, 23)
        Me.OK_Button.TabIndex = 6
        Me.OK_Button.Text = "确定"
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(289, 89)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_Button.TabIndex = 7
        Me.Cancel_Button.Text = "取消"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(53, 13)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "数据变更"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(150, 13)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "维护密码"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Maintenance_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 200)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.renewPW_TextBox)
        Me.Controls.Add(Me.newPW_TextBox)
        Me.Controls.Add(Me.oldPW_TextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Maintenance_Password"
        Me.Text = "密码维护"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents oldPW_TextBox As TextBox
    Friend WithEvents newPW_TextBox As TextBox
    Friend WithEvents renewPW_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
