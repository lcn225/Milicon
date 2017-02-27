<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchData))
        Me.TestList_DataGridView = New System.Windows.Forms.DataGridView()
        Me.Search_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.Del_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.DateStart_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateEnd_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LotsStart_TextBox = New System.Windows.Forms.TextBox()
        Me.LotsEnd_TextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ObjectType_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        CType(Me.TestList_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TestList_DataGridView
        '
        Me.TestList_DataGridView.AllowUserToAddRows = False
        Me.TestList_DataGridView.AllowUserToDeleteRows = False
        Me.TestList_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TestList_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestList_DataGridView.Location = New System.Drawing.Point(31, 140)
        Me.TestList_DataGridView.Name = "TestList_DataGridView"
        Me.TestList_DataGridView.ReadOnly = True
        Me.TestList_DataGridView.RowTemplate.Height = 23
        Me.TestList_DataGridView.Size = New System.Drawing.Size(746, 252)
        Me.TestList_DataGridView.TabIndex = 0
        '
        'Search_Button
        '
        Me.Search_Button.Location = New System.Drawing.Point(671, 67)
        Me.Search_Button.Name = "Search_Button"
        Me.Search_Button.Size = New System.Drawing.Size(104, 51)
        Me.Search_Button.TabIndex = 1
        Me.Search_Button.Text = "搜索"
        Me.Search_Button.UseVisualStyleBackColor = True
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(31, 418)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(126, 51)
        Me.OK_Button.TabIndex = 2
        Me.OK_Button.Text = "确认"
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'Clear_Button
        '
        Me.Clear_Button.Location = New System.Drawing.Point(241, 418)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(122, 51)
        Me.Clear_Button.TabIndex = 3
        Me.Clear_Button.Text = "重置"
        Me.Clear_Button.UseVisualStyleBackColor = True
        '
        'Del_Button
        '
        Me.Del_Button.Location = New System.Drawing.Point(447, 418)
        Me.Del_Button.Name = "Del_Button"
        Me.Del_Button.Size = New System.Drawing.Size(122, 51)
        Me.Del_Button.TabIndex = 4
        Me.Del_Button.Text = "删除"
        Me.Del_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(653, 418)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(122, 51)
        Me.Exit_Button.TabIndex = 5
        Me.Exit_Button.Text = "退出"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'DateStart_DateTimePicker
        '
        Me.DateStart_DateTimePicker.Location = New System.Drawing.Point(109, 30)
        Me.DateStart_DateTimePicker.Name = "DateStart_DateTimePicker"
        Me.DateStart_DateTimePicker.Size = New System.Drawing.Size(105, 21)
        Me.DateStart_DateTimePicker.TabIndex = 7
        Me.DateStart_DateTimePicker.Value = New Date(2017, 1, 6, 0, 0, 0, 0)
        '
        'DateEnd_DateTimePicker
        '
        Me.DateEnd_DateTimePicker.Location = New System.Drawing.Point(252, 30)
        Me.DateEnd_DateTimePicker.Name = "DateEnd_DateTimePicker"
        Me.DateEnd_DateTimePicker.Size = New System.Drawing.Size(105, 21)
        Me.DateEnd_DateTimePicker.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(226, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "～"
        '
        'LotsStart_TextBox
        '
        Me.LotsStart_TextBox.Location = New System.Drawing.Point(109, 67)
        Me.LotsStart_TextBox.Name = "LotsStart_TextBox"
        Me.LotsStart_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.LotsStart_TextBox.TabIndex = 11
        '
        'LotsEnd_TextBox
        '
        Me.LotsEnd_TextBox.Location = New System.Drawing.Point(252, 67)
        Me.LotsEnd_TextBox.Name = "LotsEnd_TextBox"
        Me.LotsEnd_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.LotsEnd_TextBox.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(226, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 12)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "～"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(414, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Label5"
        '
        'ObjectType_ComboBox
        '
        Me.ObjectType_ComboBox.FormattingEnabled = True
        Me.ObjectType_ComboBox.Location = New System.Drawing.Point(472, 30)
        Me.ObjectType_ComboBox.Name = "ObjectType_ComboBox"
        Me.ObjectType_ComboBox.Size = New System.Drawing.Size(140, 20)
        Me.ObjectType_ComboBox.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Label6"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(31, 32)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton1.TabIndex = 17
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "测试日期"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(31, 72)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton2.TabIndex = 18
        Me.RadioButton2.Text = "测试批号"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'SearchData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 504)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ObjectType_ComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LotsEnd_TextBox)
        Me.Controls.Add(Me.LotsStart_TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateEnd_DateTimePicker)
        Me.Controls.Add(Me.DateStart_DateTimePicker)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Del_Button)
        Me.Controls.Add(Me.Clear_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Search_Button)
        Me.Controls.Add(Me.TestList_DataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SearchData"
        Me.Text = "SearchData"
        CType(Me.TestList_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TestList_DataGridView As DataGridView
    Friend WithEvents Search_Button As Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents Clear_Button As Button
    Friend WithEvents Del_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents DateStart_DateTimePicker As DateTimePicker
    Friend WithEvents DateEnd_DateTimePicker As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents LotsStart_TextBox As TextBox
    Friend WithEvents LotsEnd_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ObjectType_ComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
