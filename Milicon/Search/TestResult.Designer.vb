<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestResult
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
        Me.TestLots_Label = New System.Windows.Forms.Label()
        Me.TestData_DataGridView = New System.Windows.Forms.DataGridView()
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
        Me.TestData_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestData_DataGridView.Location = New System.Drawing.Point(48, 90)
        Me.TestData_DataGridView.Name = "TestData_DataGridView"
        Me.TestData_DataGridView.RowHeadersVisible = False
        Me.TestData_DataGridView.RowTemplate.Height = 23
        Me.TestData_DataGridView.Size = New System.Drawing.Size(482, 390)
        Me.TestData_DataGridView.TabIndex = 1
        '
        'TestResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 583)
        Me.Controls.Add(Me.TestData_DataGridView)
        Me.Controls.Add(Me.TestLots_Label)
        Me.Name = "TestResult"
        Me.Text = "TestResult"
        CType(Me.TestData_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TestLots_Label As Label
    Friend WithEvents TestData_DataGridView As DataGridView
End Class
