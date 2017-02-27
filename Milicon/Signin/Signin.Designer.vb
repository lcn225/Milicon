<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Signin
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signin))
        Me.NameInput_TextBox = New System.Windows.Forms.TextBox()
        Me.ObjectList_Button = New System.Windows.Forms.Button()
        Me.ProDate_Label = New System.Windows.Forms.Label()
        Me.Lots_TextBox = New System.Windows.Forms.TextBox()
        Me.Lots_Label = New System.Windows.Forms.Label()
        Me.Tester_TextBox = New System.Windows.Forms.TextBox()
        Me.Tester_Label = New System.Windows.Forms.Label()
        Me.TestDate_Label = New System.Windows.Forms.Label()
        Me.TestLots_Label = New System.Windows.Forms.Label()
        Me.TestDataInput_DataGridView = New System.Windows.Forms.DataGridView()
        Me.Signin_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.ProDate_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TestDate_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        CType(Me.TestDataInput_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameInput_TextBox
        '
        Me.NameInput_TextBox.Location = New System.Drawing.Point(62, 30)
        Me.NameInput_TextBox.Name = "NameInput_TextBox"
        Me.NameInput_TextBox.ReadOnly = True
        Me.NameInput_TextBox.Size = New System.Drawing.Size(140, 21)
        Me.NameInput_TextBox.TabIndex = 0
        '
        'ObjectList_Button
        '
        Me.ObjectList_Button.Location = New System.Drawing.Point(239, 30)
        Me.ObjectList_Button.Name = "ObjectList_Button"
        Me.ObjectList_Button.Size = New System.Drawing.Size(75, 23)
        Me.ObjectList_Button.TabIndex = 1
        Me.ObjectList_Button.Text = "一览"
        Me.ObjectList_Button.UseVisualStyleBackColor = True
        '
        'ProDate_Label
        '
        Me.ProDate_Label.AutoSize = True
        Me.ProDate_Label.Location = New System.Drawing.Point(61, 93)
        Me.ProDate_Label.Name = "ProDate_Label"
        Me.ProDate_Label.Size = New System.Drawing.Size(41, 12)
        Me.ProDate_Label.TabIndex = 3
        Me.ProDate_Label.Text = "Label1"
        '
        'Lots_TextBox
        '
        Me.Lots_TextBox.Location = New System.Drawing.Point(356, 84)
        Me.Lots_TextBox.Name = "Lots_TextBox"
        Me.Lots_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.Lots_TextBox.TabIndex = 6
        '
        'Lots_Label
        '
        Me.Lots_Label.AutoSize = True
        Me.Lots_Label.Location = New System.Drawing.Point(297, 93)
        Me.Lots_Label.Name = "Lots_Label"
        Me.Lots_Label.Size = New System.Drawing.Size(41, 12)
        Me.Lots_Label.TabIndex = 5
        Me.Lots_Label.Text = "Label1"
        '
        'Tester_TextBox
        '
        Me.Tester_TextBox.Location = New System.Drawing.Point(356, 120)
        Me.Tester_TextBox.Name = "Tester_TextBox"
        Me.Tester_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.Tester_TextBox.TabIndex = 10
        '
        'Tester_Label
        '
        Me.Tester_Label.AutoSize = True
        Me.Tester_Label.Location = New System.Drawing.Point(297, 129)
        Me.Tester_Label.Name = "Tester_Label"
        Me.Tester_Label.Size = New System.Drawing.Size(41, 12)
        Me.Tester_Label.TabIndex = 9
        Me.Tester_Label.Text = "Label1"
        '
        'TestDate_Label
        '
        Me.TestDate_Label.AutoSize = True
        Me.TestDate_Label.Location = New System.Drawing.Point(61, 129)
        Me.TestDate_Label.Name = "TestDate_Label"
        Me.TestDate_Label.Size = New System.Drawing.Size(41, 12)
        Me.TestDate_Label.TabIndex = 7
        Me.TestDate_Label.Text = "Label1"
        '
        'TestLots_Label
        '
        Me.TestLots_Label.AutoSize = True
        Me.TestLots_Label.Location = New System.Drawing.Point(449, 9)
        Me.TestLots_Label.Name = "TestLots_Label"
        Me.TestLots_Label.Size = New System.Drawing.Size(41, 12)
        Me.TestLots_Label.TabIndex = 11
        Me.TestLots_Label.Text = "Label1"
        '
        'TestDataInput_DataGridView
        '
        Me.TestDataInput_DataGridView.AllowUserToAddRows = False
        Me.TestDataInput_DataGridView.AllowUserToDeleteRows = False
        Me.TestDataInput_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestDataInput_DataGridView.Location = New System.Drawing.Point(51, 161)
        Me.TestDataInput_DataGridView.Name = "TestDataInput_DataGridView"
        Me.TestDataInput_DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.TestDataInput_DataGridView.RowTemplate.Height = 23
        Me.TestDataInput_DataGridView.Size = New System.Drawing.Size(499, 252)
        Me.TestDataInput_DataGridView.TabIndex = 12
        '
        'Signin_Button
        '
        Me.Signin_Button.Location = New System.Drawing.Point(51, 434)
        Me.Signin_Button.Name = "Signin_Button"
        Me.Signin_Button.Size = New System.Drawing.Size(75, 65)
        Me.Signin_Button.TabIndex = 13
        Me.Signin_Button.Text = "Signin"
        Me.Signin_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(263, 434)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 65)
        Me.Cancel_Button.TabIndex = 14
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(475, 434)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(75, 65)
        Me.Exit_Button.TabIndex = 15
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'ProDate_DateTimePicker
        '
        Me.ProDate_DateTimePicker.Location = New System.Drawing.Point(120, 87)
        Me.ProDate_DateTimePicker.Name = "ProDate_DateTimePicker"
        Me.ProDate_DateTimePicker.Size = New System.Drawing.Size(115, 21)
        Me.ProDate_DateTimePicker.TabIndex = 16
        '
        'TestDate_DateTimePicker
        '
        Me.TestDate_DateTimePicker.Location = New System.Drawing.Point(120, 120)
        Me.TestDate_DateTimePicker.Name = "TestDate_DateTimePicker"
        Me.TestDate_DateTimePicker.Size = New System.Drawing.Size(115, 21)
        Me.TestDate_DateTimePicker.TabIndex = 17
        '
        'Signin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 511)
        Me.Controls.Add(Me.TestDate_DateTimePicker)
        Me.Controls.Add(Me.ProDate_DateTimePicker)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Signin_Button)
        Me.Controls.Add(Me.TestDataInput_DataGridView)
        Me.Controls.Add(Me.TestLots_Label)
        Me.Controls.Add(Me.Tester_TextBox)
        Me.Controls.Add(Me.Tester_Label)
        Me.Controls.Add(Me.TestDate_Label)
        Me.Controls.Add(Me.Lots_TextBox)
        Me.Controls.Add(Me.Lots_Label)
        Me.Controls.Add(Me.ProDate_Label)
        Me.Controls.Add(Me.ObjectList_Button)
        Me.Controls.Add(Me.NameInput_TextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Signin"
        Me.Text = "Signin"
        CType(Me.TestDataInput_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents NameInput_TextBox As TextBox
    Friend WithEvents ObjectList_Button As Button
    Friend WithEvents ProDate_Label As Label
    Friend WithEvents Lots_TextBox As TextBox
    Friend WithEvents Lots_Label As Label
    Friend WithEvents Tester_TextBox As TextBox
    Friend WithEvents Tester_Label As Label
    Friend WithEvents TestDate_Label As Label
    Friend WithEvents TestLots_Label As Label
    Friend WithEvents TestDataInput_DataGridView As DataGridView
    Friend WithEvents Signin_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents ProDate_DateTimePicker As DateTimePicker
    Friend WithEvents TestDate_DateTimePicker As DateTimePicker
End Class
