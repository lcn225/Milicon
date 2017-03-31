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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Maintenance_Object))
        Me.TestItem_DataGridView = New System.Windows.Forms.DataGridView()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Signin_Button = New System.Windows.Forms.Button()
        Me.ObjectList_Button = New System.Windows.Forms.Button()
        Me.NameInput_TextBox = New System.Windows.Forms.TextBox()
        Me.Help_Button = New System.Windows.Forms.Button()
        Me.Add_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sup_TextBox = New System.Windows.Forms.TextBox()
        Me.Info_Label = New System.Windows.Forms.Label()
        Me.Del_Button = New System.Windows.Forms.Button()
        CType(Me.TestItem_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TestItem_DataGridView
        '
        Me.TestItem_DataGridView.AllowUserToDeleteRows = False
        Me.TestItem_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TestItem_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestItem_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.TestItem_DataGridView.Location = New System.Drawing.Point(54, 108)
        Me.TestItem_DataGridView.Name = "TestItem_DataGridView"
        Me.TestItem_DataGridView.RowHeadersVisible = False
        Me.TestItem_DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.TestItem_DataGridView.RowTemplate.Height = 23
        Me.TestItem_DataGridView.Size = New System.Drawing.Size(582, 313)
        Me.TestItem_DataGridView.TabIndex = 1
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(560, 438)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(75, 65)
        Me.Exit_Button.TabIndex = 18
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(434, 438)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 65)
        Me.Cancel_Button.TabIndex = 17
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Signin_Button
        '
        Me.Signin_Button.Location = New System.Drawing.Point(56, 438)
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
        'Help_Button
        '
        Me.Help_Button.Location = New System.Drawing.Point(526, 25)
        Me.Help_Button.Name = "Help_Button"
        Me.Help_Button.Size = New System.Drawing.Size(75, 23)
        Me.Help_Button.TabIndex = 21
        Me.Help_Button.Text = "说明"
        Me.Help_Button.UseVisualStyleBackColor = True
        '
        'Add_Button
        '
        Me.Add_Button.Enabled = False
        Me.Add_Button.Location = New System.Drawing.Point(182, 438)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(75, 65)
        Me.Add_Button.TabIndex = 22
        Me.Add_Button.Text = "Add"
        Me.Add_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "厂商"
        '
        'sup_TextBox
        '
        Me.sup_TextBox.Location = New System.Drawing.Point(122, 69)
        Me.sup_TextBox.Name = "sup_TextBox"
        Me.sup_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.sup_TextBox.TabIndex = 25
        '
        'Info_Label
        '
        Me.Info_Label.AutoSize = True
        Me.Info_Label.Location = New System.Drawing.Point(258, 78)
        Me.Info_Label.Name = "Info_Label"
        Me.Info_Label.Size = New System.Drawing.Size(59, 12)
        Me.Info_Label.TabIndex = 26
        Me.Info_Label.Text = "         "
        '
        'Del_Button
        '
        Me.Del_Button.Enabled = False
        Me.Del_Button.Location = New System.Drawing.Point(308, 438)
        Me.Del_Button.Name = "Del_Button"
        Me.Del_Button.Size = New System.Drawing.Size(75, 65)
        Me.Del_Button.TabIndex = 27
        Me.Del_Button.Text = "Del"
        Me.Del_Button.UseVisualStyleBackColor = True
        '
        'Maintenance_Object
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 556)
        Me.Controls.Add(Me.Del_Button)
        Me.Controls.Add(Me.Info_Label)
        Me.Controls.Add(Me.sup_TextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Add_Button)
        Me.Controls.Add(Me.Help_Button)
        Me.Controls.Add(Me.ObjectList_Button)
        Me.Controls.Add(Me.NameInput_TextBox)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Signin_Button)
        Me.Controls.Add(Me.TestItem_DataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents Help_Button As Button
    Friend WithEvents Add_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents sup_TextBox As TextBox
    Friend WithEvents Info_Label As Label
    Friend WithEvents Del_Button As Button
End Class
