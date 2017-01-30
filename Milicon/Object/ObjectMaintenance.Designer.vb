<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectMaintenance
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
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Signin_Button = New System.Windows.Forms.Button()
        Me.TestDataInput_DataGridView = New System.Windows.Forms.DataGridView()
        Me.ObjectList_Button = New System.Windows.Forms.Button()
        Me.NameInput_TextBox = New System.Windows.Forms.TextBox()
        CType(Me.TestDataInput_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(474, 428)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(75, 65)
        Me.Exit_Button.TabIndex = 21
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(262, 428)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 65)
        Me.Cancel_Button.TabIndex = 20
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Signin_Button
        '
        Me.Signin_Button.Location = New System.Drawing.Point(50, 428)
        Me.Signin_Button.Name = "Signin_Button"
        Me.Signin_Button.Size = New System.Drawing.Size(75, 65)
        Me.Signin_Button.TabIndex = 19
        Me.Signin_Button.Text = "Signin"
        Me.Signin_Button.UseVisualStyleBackColor = True
        '
        'TestDataInput_DataGridView
        '
        Me.TestDataInput_DataGridView.AllowUserToAddRows = False
        Me.TestDataInput_DataGridView.AllowUserToDeleteRows = False
        Me.TestDataInput_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestDataInput_DataGridView.Location = New System.Drawing.Point(50, 82)
        Me.TestDataInput_DataGridView.Name = "TestDataInput_DataGridView"
        Me.TestDataInput_DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.TestDataInput_DataGridView.RowTemplate.Height = 23
        Me.TestDataInput_DataGridView.Size = New System.Drawing.Size(499, 325)
        Me.TestDataInput_DataGridView.TabIndex = 18
        '
        'ObjectList_Button
        '
        Me.ObjectList_Button.Location = New System.Drawing.Point(238, 24)
        Me.ObjectList_Button.Name = "ObjectList_Button"
        Me.ObjectList_Button.Size = New System.Drawing.Size(75, 23)
        Me.ObjectList_Button.TabIndex = 17
        Me.ObjectList_Button.Text = "一览"
        Me.ObjectList_Button.UseVisualStyleBackColor = True
        '
        'NameInput_TextBox
        '
        Me.NameInput_TextBox.Location = New System.Drawing.Point(50, 26)
        Me.NameInput_TextBox.Name = "NameInput_TextBox"
        Me.NameInput_TextBox.ReadOnly = True
        Me.NameInput_TextBox.Size = New System.Drawing.Size(140, 21)
        Me.NameInput_TextBox.TabIndex = 16
        '
        'ObjectMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 516)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Signin_Button)
        Me.Controls.Add(Me.TestDataInput_DataGridView)
        Me.Controls.Add(Me.ObjectList_Button)
        Me.Controls.Add(Me.NameInput_TextBox)
        Me.Name = "ObjectMaintenance"
        Me.Text = "ObjectMaintenance"
        CType(Me.TestDataInput_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Exit_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Signin_Button As Button
    Friend WithEvents TestDataInput_DataGridView As DataGridView
    Friend WithEvents ObjectList_Button As Button
    Public WithEvents NameInput_TextBox As TextBox
End Class
