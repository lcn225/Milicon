﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestResult))
        Me.TestLots_Label = New System.Windows.Forms.Label()
        Me.TestData_DataGridView = New System.Windows.Forms.DataGridView()
        Me.TestDate_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProDate_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tester_TextBox = New System.Windows.Forms.TextBox()
        Me.Tester_Label = New System.Windows.Forms.Label()
        Me.TestDate_Label = New System.Windows.Forms.Label()
        Me.Lots_TextBox = New System.Windows.Forms.TextBox()
        Me.Lots_Label = New System.Windows.Forms.Label()
        Me.ProDate_Label = New System.Windows.Forms.Label()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Print_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Object_Label = New System.Windows.Forms.Label()
        CType(Me.TestData_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TestLots_Label
        '
        Me.TestLots_Label.AutoSize = True
        Me.TestLots_Label.Location = New System.Drawing.Point(46, 31)
        Me.TestLots_Label.Name = "TestLots_Label"
        Me.TestLots_Label.Size = New System.Drawing.Size(41, 12)
        Me.TestLots_Label.TabIndex = 0
        Me.TestLots_Label.Text = "Label1"
        '
        'TestData_DataGridView
        '
        Me.TestData_DataGridView.AllowUserToAddRows = False
        Me.TestData_DataGridView.AllowUserToDeleteRows = False
        Me.TestData_DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TestData_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestData_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.TestData_DataGridView.Location = New System.Drawing.Point(48, 161)
        Me.TestData_DataGridView.Name = "TestData_DataGridView"
        Me.TestData_DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.TestData_DataGridView.RowTemplate.Height = 23
        Me.TestData_DataGridView.Size = New System.Drawing.Size(687, 331)
        Me.TestData_DataGridView.TabIndex = 1
        '
        'TestDate_DateTimePicker
        '
        Me.TestDate_DateTimePicker.CustomFormat = "yyyy/MM/dd"
        Me.TestDate_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TestDate_DateTimePicker.Location = New System.Drawing.Point(113, 96)
        Me.TestDate_DateTimePicker.Name = "TestDate_DateTimePicker"
        Me.TestDate_DateTimePicker.Size = New System.Drawing.Size(115, 21)
        Me.TestDate_DateTimePicker.TabIndex = 25
        '
        'ProDate_DateTimePicker
        '
        Me.ProDate_DateTimePicker.CustomFormat = "yyyy/MM/dd"
        Me.ProDate_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ProDate_DateTimePicker.Location = New System.Drawing.Point(113, 63)
        Me.ProDate_DateTimePicker.Name = "ProDate_DateTimePicker"
        Me.ProDate_DateTimePicker.Size = New System.Drawing.Size(115, 21)
        Me.ProDate_DateTimePicker.TabIndex = 24
        '
        'Tester_TextBox
        '
        Me.Tester_TextBox.Location = New System.Drawing.Point(349, 96)
        Me.Tester_TextBox.Name = "Tester_TextBox"
        Me.Tester_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.Tester_TextBox.TabIndex = 23
        '
        'Tester_Label
        '
        Me.Tester_Label.AutoSize = True
        Me.Tester_Label.Location = New System.Drawing.Point(290, 105)
        Me.Tester_Label.Name = "Tester_Label"
        Me.Tester_Label.Size = New System.Drawing.Size(41, 12)
        Me.Tester_Label.TabIndex = 22
        Me.Tester_Label.Text = "检测员"
        '
        'TestDate_Label
        '
        Me.TestDate_Label.AutoSize = True
        Me.TestDate_Label.Location = New System.Drawing.Point(54, 105)
        Me.TestDate_Label.Name = "TestDate_Label"
        Me.TestDate_Label.Size = New System.Drawing.Size(53, 12)
        Me.TestDate_Label.TabIndex = 21
        Me.TestDate_Label.Text = "测试日期"
        '
        'Lots_TextBox
        '
        Me.Lots_TextBox.Location = New System.Drawing.Point(349, 60)
        Me.Lots_TextBox.Name = "Lots_TextBox"
        Me.Lots_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.Lots_TextBox.TabIndex = 20
        '
        'Lots_Label
        '
        Me.Lots_Label.AutoSize = True
        Me.Lots_Label.Location = New System.Drawing.Point(290, 69)
        Me.Lots_Label.Name = "Lots_Label"
        Me.Lots_Label.Size = New System.Drawing.Size(53, 12)
        Me.Lots_Label.TabIndex = 19
        Me.Lots_Label.Text = "产品批号"
        '
        'ProDate_Label
        '
        Me.ProDate_Label.AutoSize = True
        Me.ProDate_Label.Location = New System.Drawing.Point(54, 69)
        Me.ProDate_Label.Name = "ProDate_Label"
        Me.ProDate_Label.Size = New System.Drawing.Size(53, 12)
        Me.ProDate_Label.TabIndex = 18
        Me.ProDate_Label.Text = "制造日期"
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(48, 511)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(76, 47)
        Me.OK_Button.TabIndex = 26
        Me.OK_Button.Text = "Button1"
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(252, 511)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(71, 47)
        Me.Cancel_Button.TabIndex = 27
        Me.Cancel_Button.Text = "Button2"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Print_Button
        '
        Me.Print_Button.Location = New System.Drawing.Point(451, 511)
        Me.Print_Button.Name = "Print_Button"
        Me.Print_Button.Size = New System.Drawing.Size(78, 47)
        Me.Print_Button.TabIndex = 28
        Me.Print_Button.Text = "打印"
        Me.Print_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(657, 511)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(76, 47)
        Me.Exit_Button.TabIndex = 29
        Me.Exit_Button.Text = "Button4"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Object_Label
        '
        Me.Object_Label.AutoSize = True
        Me.Object_Label.Font = New System.Drawing.Font("宋体", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Object_Label.Location = New System.Drawing.Point(177, 31)
        Me.Object_Label.Name = "Object_Label"
        Me.Object_Label.Size = New System.Drawing.Size(20, 20)
        Me.Object_Label.TabIndex = 30
        Me.Object_Label.Text = " "
        '
        'TestResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 587)
        Me.Controls.Add(Me.Object_Label)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Print_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.TestDate_DateTimePicker)
        Me.Controls.Add(Me.ProDate_DateTimePicker)
        Me.Controls.Add(Me.Tester_TextBox)
        Me.Controls.Add(Me.Tester_Label)
        Me.Controls.Add(Me.TestDate_Label)
        Me.Controls.Add(Me.Lots_TextBox)
        Me.Controls.Add(Me.Lots_Label)
        Me.Controls.Add(Me.ProDate_Label)
        Me.Controls.Add(Me.TestData_DataGridView)
        Me.Controls.Add(Me.TestLots_Label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TestResult"
        Me.Text = "TestResult"
        CType(Me.TestData_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TestLots_Label As Label
    Friend WithEvents TestData_DataGridView As DataGridView
    Friend WithEvents TestDate_DateTimePicker As DateTimePicker
    Friend WithEvents ProDate_DateTimePicker As DateTimePicker
    Friend WithEvents Tester_TextBox As TextBox
    Friend WithEvents Tester_Label As Label
    Friend WithEvents TestDate_Label As Label
    Friend WithEvents Lots_TextBox As TextBox
    Friend WithEvents Lots_Label As Label
    Friend WithEvents ProDate_Label As Label
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Print_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Object_Label As Label
End Class
