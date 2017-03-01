<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maintenance_Type
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
        Me.type_DataGridView = New System.Windows.Forms.DataGridView()
        Me.signin_Button = New System.Windows.Forms.Button()
        Me.del_Button = New System.Windows.Forms.Button()
        Me.exit_Button = New System.Windows.Forms.Button()
        CType(Me.type_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'type_DataGridView
        '
        Me.type_DataGridView.AllowUserToDeleteRows = False
        Me.type_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.type_DataGridView.Location = New System.Drawing.Point(23, 46)
        Me.type_DataGridView.Name = "type_DataGridView"
        Me.type_DataGridView.RowTemplate.Height = 23
        Me.type_DataGridView.Size = New System.Drawing.Size(464, 240)
        Me.type_DataGridView.TabIndex = 0
        '
        'signin_Button
        '
        Me.signin_Button.Location = New System.Drawing.Point(23, 337)
        Me.signin_Button.Name = "signin_Button"
        Me.signin_Button.Size = New System.Drawing.Size(75, 23)
        Me.signin_Button.TabIndex = 1
        Me.signin_Button.Text = "Button1"
        Me.signin_Button.UseVisualStyleBackColor = True
        '
        'del_Button
        '
        Me.del_Button.Location = New System.Drawing.Point(202, 337)
        Me.del_Button.Name = "del_Button"
        Me.del_Button.Size = New System.Drawing.Size(75, 23)
        Me.del_Button.TabIndex = 2
        Me.del_Button.Text = "Button2"
        Me.del_Button.UseVisualStyleBackColor = True
        '
        'exit_Button
        '
        Me.exit_Button.Location = New System.Drawing.Point(412, 337)
        Me.exit_Button.Name = "exit_Button"
        Me.exit_Button.Size = New System.Drawing.Size(75, 23)
        Me.exit_Button.TabIndex = 3
        Me.exit_Button.Text = "Button3"
        Me.exit_Button.UseVisualStyleBackColor = True
        '
        'Maintenance_Type
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 408)
        Me.Controls.Add(Me.exit_Button)
        Me.Controls.Add(Me.del_Button)
        Me.Controls.Add(Me.signin_Button)
        Me.Controls.Add(Me.type_DataGridView)
        Me.Name = "Maintenance_Type"
        Me.Text = "Maintenance_Type"
        CType(Me.type_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents type_DataGridView As DataGridView
    Friend WithEvents signin_Button As Button
    Friend WithEvents del_Button As Button
    Friend WithEvents exit_Button As Button
End Class
