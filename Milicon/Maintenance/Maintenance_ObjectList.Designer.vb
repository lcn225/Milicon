<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maintenance_ObjectList
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
        Me.components = New System.ComponentModel.Container()
        Me.ObjectList_DataGridView = New System.Windows.Forms.DataGridView()
        Me.Code4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObjTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObjNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObjSupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObjectListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ObjectList_DataSet = New WindowsApplication1.ObjectList_DataSet()
        Me.Object_ListTableAdapter = New WindowsApplication1.ObjectList_DataSetTableAdapters.Object_ListTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ObjectList_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectList_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ObjectList_DataGridView
        '
        Me.ObjectList_DataGridView.AutoGenerateColumns = False
        Me.ObjectList_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ObjectList_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code4DataGridViewTextBoxColumn, Me.Code9DataGridViewTextBoxColumn, Me.ObjTypeDataGridViewTextBoxColumn, Me.ObjNameDataGridViewTextBoxColumn, Me.ObjSupDataGridViewTextBoxColumn})
        Me.ObjectList_DataGridView.DataSource = Me.ObjectListBindingSource
        Me.ObjectList_DataGridView.Location = New System.Drawing.Point(43, 30)
        Me.ObjectList_DataGridView.Name = "ObjectList_DataGridView"
        Me.ObjectList_DataGridView.RowTemplate.Height = 23
        Me.ObjectList_DataGridView.Size = New System.Drawing.Size(484, 224)
        Me.ObjectList_DataGridView.TabIndex = 0
        '
        'Code4DataGridViewTextBoxColumn
        '
        Me.Code4DataGridViewTextBoxColumn.DataPropertyName = "Code4"
        Me.Code4DataGridViewTextBoxColumn.HeaderText = "四位代码"
        Me.Code4DataGridViewTextBoxColumn.Name = "Code4DataGridViewTextBoxColumn"
        Me.Code4DataGridViewTextBoxColumn.Width = 80
        '
        'Code9DataGridViewTextBoxColumn
        '
        Me.Code9DataGridViewTextBoxColumn.DataPropertyName = "Code9"
        Me.Code9DataGridViewTextBoxColumn.HeaderText = "九位代码"
        Me.Code9DataGridViewTextBoxColumn.Name = "Code9DataGridViewTextBoxColumn"
        '
        'ObjTypeDataGridViewTextBoxColumn
        '
        Me.ObjTypeDataGridViewTextBoxColumn.DataPropertyName = "Obj_Type"
        Me.ObjTypeDataGridViewTextBoxColumn.HeaderText = "材料类型"
        Me.ObjTypeDataGridViewTextBoxColumn.Name = "ObjTypeDataGridViewTextBoxColumn"
        Me.ObjTypeDataGridViewTextBoxColumn.Width = 80
        '
        'ObjNameDataGridViewTextBoxColumn
        '
        Me.ObjNameDataGridViewTextBoxColumn.DataPropertyName = "Obj_Name"
        Me.ObjNameDataGridViewTextBoxColumn.HeaderText = "材料名称"
        Me.ObjNameDataGridViewTextBoxColumn.Name = "ObjNameDataGridViewTextBoxColumn"
        Me.ObjNameDataGridViewTextBoxColumn.Width = 80
        '
        'ObjSupDataGridViewTextBoxColumn
        '
        Me.ObjSupDataGridViewTextBoxColumn.DataPropertyName = "Obj_Sup"
        Me.ObjSupDataGridViewTextBoxColumn.HeaderText = "厂商"
        Me.ObjSupDataGridViewTextBoxColumn.Name = "ObjSupDataGridViewTextBoxColumn"
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(452, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "退出"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(280, 319)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "确定"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(366, 319)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "取消"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Maintenance_ObjectList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 393)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ObjectList_DataGridView)
        Me.Name = "Maintenance_ObjectList"
        Me.Text = "Maintenance_ObjectList"
        CType(Me.ObjectList_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectList_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ObjectList_DataGridView As DataGridView
    Friend WithEvents ObjectList_DataSet As ObjectList_DataSet
    Friend WithEvents ObjectListBindingSource As BindingSource
    Friend WithEvents Object_ListTableAdapter As ObjectList_DataSetTableAdapters.Object_ListTableAdapter
    Friend WithEvents Code4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Code9DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObjTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObjNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObjSupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
End Class
