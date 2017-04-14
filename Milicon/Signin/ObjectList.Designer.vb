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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ObjectList))
        Me.ObjectList_DataGridView = New System.Windows.Forms.DataGridView()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.ObjectType_ComboBox = New System.Windows.Forms.ComboBox()
        Me.filter_TextBox = New System.Windows.Forms.TextBox()
        CType(Me.ObjectList_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'filter_TextBox
        '
        Me.filter_TextBox.Location = New System.Drawing.Point(276, 26)
        Me.filter_TextBox.Name = "filter_TextBox"
        Me.filter_TextBox.Size = New System.Drawing.Size(160, 21)
        Me.filter_TextBox.TabIndex = 4
        '
        'ObjectList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 319)
        Me.Controls.Add(Me.filter_TextBox)
        Me.Controls.Add(Me.ObjectType_ComboBox)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.ObjectList_DataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ObjectList"
        Me.Text = "ObjectList"
        CType(Me.ObjectList_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ObjectList_DataGridView As DataGridView
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents ObjectType_ComboBox As ComboBox
    Friend WithEvents filter_TextBox As TextBox
End Class
