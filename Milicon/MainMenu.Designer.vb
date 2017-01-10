<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.SWName_Label = New System.Windows.Forms.Label()
        Me.Signin_Button = New System.Windows.Forms.Button()
        Me.SearchData_Button = New System.Windows.Forms.Button()
        Me.FormatMaintenance_Button = New System.Windows.Forms.Button()
        Me.operation_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SWName_Label
        '
        Me.SWName_Label.Font = New System.Drawing.Font("宋体", 24.0!)
        Me.SWName_Label.Location = New System.Drawing.Point(194, 67)
        Me.SWName_Label.Name = "SWName_Label"
        Me.SWName_Label.Size = New System.Drawing.Size(400, 33)
        Me.SWName_Label.TabIndex = 0
        Me.SWName_Label.Text = "NA"
        Me.SWName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Signin_Button
        '
        Me.Signin_Button.Location = New System.Drawing.Point(194, 97)
        Me.Signin_Button.Name = "Signin_Button"
        Me.Signin_Button.Size = New System.Drawing.Size(202, 60)
        Me.Signin_Button.TabIndex = 1
        Me.Signin_Button.Text = "NA"
        Me.Signin_Button.UseVisualStyleBackColor = True
        '
        'SearchData_Button
        '
        Me.SearchData_Button.Location = New System.Drawing.Point(194, 182)
        Me.SearchData_Button.Name = "SearchData_Button"
        Me.SearchData_Button.Size = New System.Drawing.Size(202, 60)
        Me.SearchData_Button.TabIndex = 2
        Me.SearchData_Button.Text = "NA"
        Me.SearchData_Button.UseVisualStyleBackColor = True
        '
        'FormatMaintenance_Button
        '
        Me.FormatMaintenance_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.FormatMaintenance_Button.Location = New System.Drawing.Point(194, 267)
        Me.FormatMaintenance_Button.Name = "FormatMaintenance_Button"
        Me.FormatMaintenance_Button.Size = New System.Drawing.Size(200, 60)
        Me.FormatMaintenance_Button.TabIndex = 3
        Me.FormatMaintenance_Button.Text = "NA"
        Me.FormatMaintenance_Button.UseVisualStyleBackColor = True
        '
        'operation_Button
        '
        Me.operation_Button.BackgroundImage = CType(resources.GetObject("operation_Button.BackgroundImage"), System.Drawing.Image)
        Me.operation_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.operation_Button.Location = New System.Drawing.Point(506, 365)
        Me.operation_Button.Name = "operation_Button"
        Me.operation_Button.Size = New System.Drawing.Size(29, 29)
        Me.operation_Button.TabIndex = 4
        Me.operation_Button.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 434)
        Me.Controls.Add(Me.operation_Button)
        Me.Controls.Add(Me.FormatMaintenance_Button)
        Me.Controls.Add(Me.SearchData_Button)
        Me.Controls.Add(Me.Signin_Button)
        Me.Controls.Add(Me.SWName_Label)
        Me.Name = "MainMenu"
        Me.Text = "NA"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SWName_Label As Label
    Friend WithEvents Signin_Button As Button
    Friend WithEvents SearchData_Button As Button
    Friend WithEvents FormatMaintenance_Button As Button

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ini.GetIniString("SWName", "Title", "NAini") & " " & ini.GetIniString("SWName", "Ver", "NAini")
        Me.SWName_Label.Text = ini.GetIniString("MainMenu", "Label", "SWName")
        Me.Signin_Button.Text = ini.GetIniString("MainMenu", "Button1", "Signin")
        Me.SearchData_Button.Text = ini.GetIniString("MainMenu", "Button2", "SearchData")
        Me.FormatMaintenance_Button.Text = ini.GetIniString("MainMenu", "Button3", "FormatMaintenance")
    End Sub

    Private Sub MainMenu_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim HorizonEdge = 200
        Dim BottomEdge = 100
        Dim ButtonEdge = 20
        Dim ButtonWidth = Me.Width - HorizonEdge * 2
        Dim ButtonHeight = 60

        Me.FormatMaintenance_Button.Location = New System.Drawing.Point(HorizonEdge, Me.Height - ButtonHeight - BottomEdge)
        Me.FormatMaintenance_Button.Size = New System.Drawing.Size(ButtonWidth, ButtonHeight)


        Me.SearchData_Button.Location = New System.Drawing.Point(HorizonEdge, Me.FormatMaintenance_Button.Location.Y - ButtonHeight - ButtonEdge)
        Me.SearchData_Button.Size = New System.Drawing.Size(ButtonWidth, ButtonHeight)


        Me.Signin_Button.Location = New System.Drawing.Point(HorizonEdge, Me.SearchData_Button.Location.Y - ButtonHeight - ButtonEdge)
        Me.Signin_Button.Size = New System.Drawing.Size(ButtonWidth, ButtonHeight)

        Me.SWName_Label.Location = New System.Drawing.Point((Me.Width - SWName_Label.Width) / 2, (Me.Signin_Button.Location.Y - SWName_Label.Height) / 2)

    End Sub

    Private Sub Signin_Click(sender As Object, e As EventArgs) Handles Signin_Button.Click
        Signin.Show()
        Me.Hide()

    End Sub

    Friend WithEvents operation_Button As Button

    Private Sub operation_Button_Click(sender As Object, e As EventArgs) Handles operation_Button.Click
        MaintenanceMainMenu.Show()
        Me.Hide()
    End Sub
End Class
