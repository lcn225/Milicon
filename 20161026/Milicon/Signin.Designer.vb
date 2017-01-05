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
        Me.components = New System.ComponentModel.Container()
        Me.NameInput_TextBox = New System.Windows.Forms.TextBox()
        Me.ObjectList_Button = New System.Windows.Forms.Button()
        Me.ObjectInput_Button = New System.Windows.Forms.Button()
        Me.ProDate_Label = New System.Windows.Forms.Label()
        Me.ProDate_TextBox = New System.Windows.Forms.TextBox()
        Me.Lots_TextBox = New System.Windows.Forms.TextBox()
        Me.Lots_Label = New System.Windows.Forms.Label()
        Me.Tester_TextBox = New System.Windows.Forms.TextBox()
        Me.Tester_Label = New System.Windows.Forms.Label()
        Me.TestDate_TextBox = New System.Windows.Forms.TextBox()
        Me.TestDate_Label = New System.Windows.Forms.Label()
        Me.TestLots_Label = New System.Windows.Forms.Label()
        Me.TestDateInput_DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataList_DataSet = New WindowsApplication1.DataList_DataSet()
        Me.DataListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data_ListTableAdapter = New WindowsApplication1.DataList_DataSetTableAdapters.Data_ListTableAdapter()
        Me.TestObject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TestDateInput_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataList_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameInput_TextBox
        '
        Me.NameInput_TextBox.Location = New System.Drawing.Point(61, 39)
        Me.NameInput_TextBox.Name = "NameInput_TextBox"
        Me.NameInput_TextBox.Size = New System.Drawing.Size(140, 21)
        Me.NameInput_TextBox.TabIndex = 0
        '
        'ObjectList_Button
        '
        Me.ObjectList_Button.Location = New System.Drawing.Point(238, 39)
        Me.ObjectList_Button.Name = "ObjectList_Button"
        Me.ObjectList_Button.Size = New System.Drawing.Size(75, 23)
        Me.ObjectList_Button.TabIndex = 1
        Me.ObjectList_Button.Text = "一览"
        Me.ObjectList_Button.UseVisualStyleBackColor = True
        '
        'ObjectInput_Button
        '
        Me.ObjectInput_Button.Location = New System.Drawing.Point(332, 39)
        Me.ObjectInput_Button.Name = "ObjectInput_Button"
        Me.ObjectInput_Button.Size = New System.Drawing.Size(75, 23)
        Me.ObjectInput_Button.TabIndex = 2
        Me.ObjectInput_Button.Text = "确认"
        Me.ObjectInput_Button.UseVisualStyleBackColor = True
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
        'ProDate_TextBox
        '
        Me.ProDate_TextBox.Location = New System.Drawing.Point(120, 84)
        Me.ProDate_TextBox.Name = "ProDate_TextBox"
        Me.ProDate_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.ProDate_TextBox.TabIndex = 4
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
        'TestDate_TextBox
        '
        Me.TestDate_TextBox.Location = New System.Drawing.Point(120, 120)
        Me.TestDate_TextBox.Name = "TestDate_TextBox"
        Me.TestDate_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.TestDate_TextBox.TabIndex = 8
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
        Me.TestLots_Label.Location = New System.Drawing.Point(457, 39)
        Me.TestLots_Label.Name = "TestLots_Label"
        Me.TestLots_Label.Size = New System.Drawing.Size(41, 12)
        Me.TestLots_Label.TabIndex = 11
        Me.TestLots_Label.Text = "Label1"
        '
        'TestDateInput_DataGridView
        '
        Me.TestDateInput_DataGridView.AllowUserToAddRows = False
        Me.TestDateInput_DataGridView.AllowUserToDeleteRows = False
        Me.TestDateInput_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestDateInput_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TestObject})
        Me.TestDateInput_DataGridView.Location = New System.Drawing.Point(38, 204)
        Me.TestDateInput_DataGridView.Name = "TestDateInput_DataGridView"
        Me.TestDateInput_DataGridView.RowTemplate.Height = 23
        Me.TestDateInput_DataGridView.Size = New System.Drawing.Size(499, 252)
        Me.TestDateInput_DataGridView.TabIndex = 12
        '
        'DataList_DataSet
        '
        Me.DataList_DataSet.DataSetName = "DataList_DataSet"
        Me.DataList_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataListBindingSource
        '
        Me.DataListBindingSource.DataMember = "Data_List"
        Me.DataListBindingSource.DataSource = Me.DataList_DataSet
        '
        'Data_ListTableAdapter
        '
        Me.Data_ListTableAdapter.ClearBeforeFill = True
        '
        'TestObject
        '
        Me.TestObject.HeaderText = "项目"
        Me.TestObject.Name = "TestObject"
        Me.TestObject.ReadOnly = True
        '
        'Signin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 511)
        Me.Controls.Add(Me.TestDateInput_DataGridView)
        Me.Controls.Add(Me.TestLots_Label)
        Me.Controls.Add(Me.Tester_TextBox)
        Me.Controls.Add(Me.Tester_Label)
        Me.Controls.Add(Me.TestDate_TextBox)
        Me.Controls.Add(Me.TestDate_Label)
        Me.Controls.Add(Me.Lots_TextBox)
        Me.Controls.Add(Me.Lots_Label)
        Me.Controls.Add(Me.ProDate_TextBox)
        Me.Controls.Add(Me.ProDate_Label)
        Me.Controls.Add(Me.ObjectInput_Button)
        Me.Controls.Add(Me.ObjectList_Button)
        Me.Controls.Add(Me.NameInput_TextBox)
        Me.Name = "Signin"
        Me.Text = "Signin"
        CType(Me.TestDateInput_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataList_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents NameInput_TextBox As TextBox
    Friend WithEvents ObjectList_Button As Button
    Friend WithEvents ObjectInput_Button As Button
    Friend WithEvents ProDate_Label As Label
    Friend WithEvents ProDate_TextBox As TextBox
    Friend WithEvents Lots_TextBox As TextBox
    Friend WithEvents Lots_Label As Label
    Friend WithEvents Tester_TextBox As TextBox
    Friend WithEvents Tester_Label As Label
    Friend WithEvents TestDate_TextBox As TextBox
    Friend WithEvents TestDate_Label As Label
    Friend WithEvents TestLots_Label As Label
    Friend WithEvents TestDateInput_DataGridView As DataGridView
    Friend WithEvents DataList_DataSet As DataList_DataSet
    Friend WithEvents DataListBindingSource As BindingSource
    Friend WithEvents Data_ListTableAdapter As DataList_DataSetTableAdapters.Data_ListTableAdapter
    Friend WithEvents TestObject As DataGridViewTextBoxColumn
End Class
