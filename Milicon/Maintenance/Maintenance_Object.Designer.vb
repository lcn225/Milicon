<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maintenance_Object
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
        Me.TestItem_DataGridView = New System.Windows.Forms.DataGridView()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Signin_Button = New System.Windows.Forms.Button()
        Me.ObjectList_Button = New System.Windows.Forms.Button()
        Me.NameInput_TextBox = New System.Windows.Forms.TextBox()
        CType(Me.TestItem_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TestItem_DataGridView
        '
        Me.TestItem_DataGridView.AllowUserToAddRows = False
        Me.TestItem_DataGridView.AllowUserToDeleteRows = False
        Me.TestItem_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TestItem_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestItem_DataGridView.Location = New System.Drawing.Point(36, 66)
        Me.TestItem_DataGridView.Name = "TestItem_DataGridView"
        Me.TestItem_DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.TestItem_DataGridView.RowTemplate.Height = 23
        Me.TestItem_DataGridView.Size = New System.Drawing.Size(626, 284)
        Me.TestItem_DataGridView.TabIndex = 1
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(526, 380)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(75, 65)
        Me.Exit_Button.TabIndex = 18
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(314, 380)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 65)
        Me.Cancel_Button.TabIndex = 17
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Signin_Button
        '
        Me.Signin_Button.Location = New System.Drawing.Point(102, 380)
        Me.Signin_Button.Name = "Signin_Button"
        Me.Signin_Button.Size = New System.Drawing.Size(75, 65)
        Me.Signin_Button.TabIndex = 16
        Me.Signin_Button.Text = "Signin"
        Me.Signin_Button.UseVisualStyleBackColor = True
        '
        'ObjectList_Button
        '
        Me.ObjectList_Button.Location = New System.Drawing.Point(214, 25)
        Me.ObjectList_Button.Name = "ObjectList_Button"
        Me.ObjectList_Button.Size = New System.Drawing.Size(75, 23)
        Me.ObjectList_Button.TabIndex = 20
        Me.ObjectList_Button.Text = "一览"
        Me.ObjectList_Button.UseVisualStyleBackColor = True
        '
        'NameInput_TextBox
        '
        Me.NameInput_TextBox.Location = New System.Drawing.Point(37, 25)
        Me.NameInput_TextBox.Name = "NameInput_TextBox"
        Me.NameInput_TextBox.ReadOnly = True
        Me.NameInput_TextBox.Size = New System.Drawing.Size(140, 21)
        Me.NameInput_TextBox.TabIndex = 19
        '
        'Maintenance_Object
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 488)
        Me.Controls.Add(Me.ObjectList_Button)
        Me.Controls.Add(Me.NameInput_TextBox)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Signin_Button)
        Me.Controls.Add(Me.TestItem_DataGridView)
        Me.Name = "Maintenance_Object"
        Me.Text = "Maintenance_Object"
        CType(Me.TestItem_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TestItem_DataGridView As DataGridView
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Signin_Button As Button
    Friend WithEvents ObjectList_Button As Button
    Public WithEvents NameInput_TextBox As TextBox
End Class
