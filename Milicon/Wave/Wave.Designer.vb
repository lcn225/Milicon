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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ObjectList_Button = New System.Windows.Forms.Button()
        Me.NameInput_TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateEnd_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateStart_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Chart1
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(34, 122)
        Me.Chart1.Name = "Chart1"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(730, 315)
        Me.Chart1.TabIndex = 22
        Me.Chart1.Text = "Chart1"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(35, 76)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 23
        '
        'Wave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 514)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateEnd_DateTimePicker)
        Me.Controls.Add(Me.DateStart_DateTimePicker)
        Me.Controls.Add(Me.ObjectList_Button)
        Me.Controls.Add(Me.NameInput_TextBox)
        Me.Name = "Wave"
        Me.Text = "Wave"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ObjectList_Button As Button
    Public WithEvents NameInput_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateEnd_DateTimePicker As DateTimePicker
    Friend WithEvents DateStart_DateTimePicker As DateTimePicker
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents ComboBox1 As ComboBox
End Class
