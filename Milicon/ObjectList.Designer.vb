<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectList
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
        Me.ObjNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObejctListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiliconObjectList_DataSet = New WindowsApplication1.MiliconObjectList_DataSet()
        Me.Obejct_ListTableAdapter = New WindowsApplication1.MiliconObjectList_DataSetTableAdapters.Obejct_ListTableAdapter()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        CType(Me.ObjectList_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObejctListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiliconObjectList_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ObjectList_DataGridView
        '
        Me.ObjectList_DataGridView.AllowUserToAddRows = False
        Me.ObjectList_DataGridView.AllowUserToDeleteRows = False
        Me.ObjectList_DataGridView.AutoGenerateColumns = False
        Me.ObjectList_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ObjectList_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ObjNameDataGridViewTextBoxColumn, Me.SupDataGridViewTextBoxColumn})
        Me.ObjectList_DataGridView.DataSource = Me.ObejctListBindingSource
        Me.ObjectList_DataGridView.Location = New System.Drawing.Point(49, 41)
        Me.ObjectList_DataGridView.Name = "ObjectList_DataGridView"
        Me.ObjectList_DataGridView.ReadOnly = True
        Me.ObjectList_DataGridView.RowTemplate.Height = 23
        Me.ObjectList_DataGridView.Size = New System.Drawing.Size(394, 150)
        Me.ObjectList_DataGridView.TabIndex = 0
        '
        'ObjNameDataGridViewTextBoxColumn
        '
        Me.ObjNameDataGridViewTextBoxColumn.DataPropertyName = "Obj_Name"
        Me.ObjNameDataGridViewTextBoxColumn.HeaderText = "名字"
        Me.ObjNameDataGridViewTextBoxColumn.Name = "ObjNameDataGridViewTextBoxColumn"
        Me.ObjNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObjNameDataGridViewTextBoxColumn.Width = 150
        '
        'SupDataGridViewTextBoxColumn
        '
        Me.SupDataGridViewTextBoxColumn.DataPropertyName = "Sup"
        Me.SupDataGridViewTextBoxColumn.HeaderText = "厂商"
        Me.SupDataGridViewTextBoxColumn.Name = "SupDataGridViewTextBoxColumn"
        Me.SupDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupDataGridViewTextBoxColumn.Width = 200
        '
        'ObejctListBindingSource
        '
        Me.ObejctListBindingSource.DataMember = "Obejct_List"
        Me.ObejctListBindingSource.DataSource = Me.MiliconObjectList_DataSet
        '
        'MiliconObjectList_DataSet
        '
        Me.MiliconObjectList_DataSet.DataSetName = "MiliconObjectList_DataSet"
        Me.MiliconObjectList_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Obejct_ListTableAdapter
        '
        Me.Obejct_ListTableAdapter.ClearBeforeFill = True
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(483, 41)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(75, 23)
        Me.OK_Button.TabIndex = 1
        Me.OK_Button.Text = "Button1"
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(483, 85)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_Button.TabIndex = 2
        Me.Cancel_Button.Text = "Button2"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'ObjectList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 270)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.ObjectList_DataGridView)
        Me.Name = "ObjectList"
        Me.Text = "ObjectList"
        CType(Me.ObjectList_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObejctListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiliconObjectList_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ObjectList_DataGridView As DataGridView
    Friend WithEvents MiliconObjectList_DataSet As MiliconObjectList_DataSet
    Friend WithEvents ObejctListBindingSource As BindingSource
    Friend WithEvents Obejct_ListTableAdapter As MiliconObjectList_DataSetTableAdapters.Obejct_ListTableAdapter
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents ObjNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
