<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ObjectList
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
        Me.ObjectList_DataGridView = New System.Windows.Forms.DataGridView()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.ObjectType_ComboBox = New System.Windows.Forms.ComboBox()
        Me.ObjectListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ObjectList_DataSet = New WindowsApplication1.ObjectList_DataSet()
        Me.Object_ListTableAdapter = New WindowsApplication1.ObjectList_DataSetTableAdapters.Object_ListTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ObjectList_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectList_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ObjectList_DataGridView
        '
        Me.ObjectList_DataGridView.AllowUserToAddRows = False
        Me.ObjectList_DataGridView.AllowUserToDeleteRows = False
        Me.ObjectList_DataGridView.AllowUserToOrderColumns = True
        Me.ObjectList_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ObjectList_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ObjectList_DataGridView.Location = New System.Drawing.Point(59, 79)
        Me.ObjectList_DataGridView.Name = "ObjectList_DataGridView"
        Me.ObjectList_DataGridView.ReadOnly = True
        Me.ObjectList_DataGridView.RowHeadersVisible = False
        Me.ObjectList_DataGridView.RowTemplate.Height = 23
        Me.ObjectList_DataGridView.Size = New System.Drawing.Size(425, 193)
        Me.ObjectList_DataGridView.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(531, 61)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(75, 23)
        Me.OK_Button.TabIndex = 1
        Me.OK_Button.Text = "Button1"
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(531, 106)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_Button.TabIndex = 2
        Me.Cancel_Button.Text = "Button2"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'ObjectType_ComboBox
        '
        Me.ObjectType_ComboBox.FormattingEnabled = True
        Me.ObjectType_ComboBox.Location = New System.Drawing.Point(59, 26)
        Me.ObjectType_ComboBox.Name = "ObjectType_ComboBox"
        Me.ObjectType_ComboBox.Size = New System.Drawing.Size(177, 20)
        Me.ObjectType_ComboBox.TabIndex = 3
        Me.ObjectType_ComboBox.Text = "所有材料"
        '
        'ObjectListBindingSource
        '
        Me.ObjectListBindingSource.DataMember = "Object_List"
        Me.ObjectListBindingSource.DataSource = Me.ObjectList_DataSet
        '
        'ObjectList_DataSet
        '
        Me.ObjectList_DataSet.DataSetName = "ObjectList_DataSet"
        Me.ObjectList_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Object_ListTableAdapter
        '
        Me.Object_ListTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(363, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'ObjectList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 319)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ObjectType_ComboBox)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.ObjectList_DataGridView)
        Me.Name = "ObjectList"
        Me.Text = "ObjectList"
        CType(Me.ObjectList_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectList_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ObjectList_DataGridView As DataGridView
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents ObjectType_ComboBox As ComboBox
    Friend WithEvents ObjectList_DataSet As ObjectList_DataSet
    Friend WithEvents ObjectListBindingSource As BindingSource
    Friend WithEvents Object_ListTableAdapter As ObjectList_DataSetTableAdapters.Object_ListTableAdapter
    Friend WithEvents Label1 As Label
End Class
