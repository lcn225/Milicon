<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wave
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ObjectList_Button = New System.Windows.Forms.Button()
        Me.NameInput_TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateEnd_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateStart_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Data_Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TI_CheckedListBox = New System.Windows.Forms.CheckedListBox()
        CType(Me.Data_Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ObjectList_Button
        '
        Me.ObjectList_Button.Location = New System.Drawing.Point(212, 29)
        Me.ObjectList_Button.Name = "ObjectList_Button"
        Me.ObjectList_Button.Size = New System.Drawing.Size(75, 23)
        Me.ObjectList_Button.TabIndex = 3
        Me.ObjectList_Button.Text = "一览"
        Me.ObjectList_Button.UseVisualStyleBackColor = True
        '
        'NameInput_TextBox
        '
        Me.NameInput_TextBox.Location = New System.Drawing.Point(35, 29)
        Me.NameInput_TextBox.Name = "NameInput_TextBox"
        Me.NameInput_TextBox.ReadOnly = True
        Me.NameInput_TextBox.Size = New System.Drawing.Size(140, 21)
        Me.NameInput_TextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(551, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "～"
        '
        'DateEnd_DateTimePicker
        '
        Me.DateEnd_DateTimePicker.Location = New System.Drawing.Point(577, 31)
        Me.DateEnd_DateTimePicker.Name = "DateEnd_DateTimePicker"
        Me.DateEnd_DateTimePicker.Size = New System.Drawing.Size(105, 21)
        Me.DateEnd_DateTimePicker.TabIndex = 19
        '
        'DateStart_DateTimePicker
        '
        Me.DateStart_DateTimePicker.Location = New System.Drawing.Point(434, 31)
        Me.DateStart_DateTimePicker.Name = "DateStart_DateTimePicker"
        Me.DateStart_DateTimePicker.Size = New System.Drawing.Size(105, 21)
        Me.DateStart_DateTimePicker.TabIndex = 18
        Me.DateStart_DateTimePicker.Value = New Date(2017, 2, 10, 0, 0, 0, 0)
        '
        'Data_Chart
        '
        ChartArea2.Name = "ChartArea1"
        Me.Data_Chart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Data_Chart.Legends.Add(Legend2)
        Me.Data_Chart.Location = New System.Drawing.Point(193, 90)
        Me.Data_Chart.Name = "Data_Chart"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Data_Chart.Series.Add(Series2)
        Me.Data_Chart.Size = New System.Drawing.Size(571, 347)
        Me.Data_Chart.TabIndex = 22
        Me.Data_Chart.Text = "Chart1"
        '
        'TI_CheckedListBox
        '
        Me.TI_CheckedListBox.CheckOnClick = True
        Me.TI_CheckedListBox.FormattingEnabled = True
        Me.TI_CheckedListBox.Location = New System.Drawing.Point(35, 90)
        Me.TI_CheckedListBox.Name = "TI_CheckedListBox"
        Me.TI_CheckedListBox.Size = New System.Drawing.Size(122, 340)
        Me.TI_CheckedListBox.TabIndex = 24
        '
        'Wave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 514)
        Me.Controls.Add(Me.TI_CheckedListBox)
        Me.Controls.Add(Me.Data_Chart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateEnd_DateTimePicker)
        Me.Controls.Add(Me.DateStart_DateTimePicker)
        Me.Controls.Add(Me.ObjectList_Button)
        Me.Controls.Add(Me.NameInput_TextBox)
        Me.Name = "Wave"
        Me.Text = "Wave"
        CType(Me.Data_Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ObjectList_Button As Button
    Public WithEvents NameInput_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateEnd_DateTimePicker As DateTimePicker
    Friend WithEvents DateStart_DateTimePicker As DateTimePicker
    Friend WithEvents Data_Chart As DataVisualization.Charting.Chart
    Friend WithEvents TI_CheckedListBox As CheckedListBox
End Class
