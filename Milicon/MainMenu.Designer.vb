<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.operation_Button = New System.Windows.Forms.Button()
        Me.FormatMaintenance_Button = New System.Windows.Forms.Button()
        Me.SearchData_Button = New System.Windows.Forms.Button()
        Me.Signin_Button = New System.Windows.Forms.Button()
        Me.SWName_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'operation_Button
        '
        Me.operation_Button.BackgroundImage = CType(resources.GetObject("operation_Button.BackgroundImage"), System.Drawing.Image)
        Me.operation_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.operation_Button.Location = New System.Drawing.Point(461, 373)
        Me.operation_Button.Name = "operation_Button"
        Me.operation_Button.Size = New System.Drawing.Size(29, 29)
        Me.operation_Button.TabIndex = 9
        Me.operation_Button.UseVisualStyleBackColor = True
        '
        'FormatMaintenance_Button
        '
        Me.FormatMaintenance_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.FormatMaintenance_Button.Location = New System.Drawing.Point(149, 278)
        Me.FormatMaintenance_Button.Name = "FormatMaintenance_Button"
        Me.FormatMaintenance_Button.Size = New System.Drawing.Size(200, 60)
        Me.FormatMaintenance_Button.TabIndex = 8
        Me.FormatMaintenance_Button.Text = "NA"
        Me.FormatMaintenance_Button.UseVisualStyleBackColor = True
        '
        'SearchData_Button
        '
        Me.SearchData_Button.Location = New System.Drawing.Point(149, 190)
        Me.SearchData_Button.Name = "SearchData_Button"
        Me.SearchData_Button.Size = New System.Drawing.Size(202, 60)
        Me.SearchData_Button.TabIndex = 7
        Me.SearchData_Button.Text = "NA"
        Me.SearchData_Button.UseVisualStyleBackColor = True
        '
        'Signin_Button
        '
        Me.Signin_Button.Location = New System.Drawing.Point(149, 105)
        Me.Signin_Button.Name = "Signin_Button"
        Me.Signin_Button.Size = New System.Drawing.Size(202, 60)
        Me.Signin_Button.TabIndex = 6
        Me.Signin_Button.Text = "NA"
        Me.Signin_Button.UseVisualStyleBackColor = True
        '
        'SWName_Label
        '
        Me.SWName_Label.Font = New System.Drawing.Font("宋体", 24.0!)
        Me.SWName_Label.Location = New System.Drawing.Point(55, 53)
        Me.SWName_Label.Name = "SWName_Label"
        Me.SWName_Label.Size = New System.Drawing.Size(400, 33)
        Me.SWName_Label.TabIndex = 5
        Me.SWName_Label.Text = "NA"
        Me.SWName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 422)
        Me.Controls.Add(Me.operation_Button)
        Me.Controls.Add(Me.FormatMaintenance_Button)
        Me.Controls.Add(Me.SearchData_Button)
        Me.Controls.Add(Me.Signin_Button)
        Me.Controls.Add(Me.SWName_Label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents operation_Button As Button
    Friend WithEvents FormatMaintenance_Button As Button
    Friend WithEvents SearchData_Button As Button
    Friend WithEvents Signin_Button As Button
    Friend WithEvents SWName_Label As Label
End Class
