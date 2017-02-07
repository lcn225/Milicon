Public Class MainMenu

    Private TestMode = True

    Private Sub MainMenu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ini.GetIniString("MainMenu", "Title", "NAini") & " " & ini.GetIniString("SW", "Ver", "NAini")
        Me.SWName_Label.Text = ini.GetIniString("MainMenu", "Label", "SWName")
        Me.Signin_Button.Text = ini.GetIniString("MainMenu", "Button1", "Signin")
        Me.SearchData_Button.Text = ini.GetIniString("MainMenu", "Button2", "SearchData")
        Me.FormatMaintenance_Button.Text = ini.GetIniString("MainMenu", "Button3", "FormatMaintenance")

    End Sub

    Private Sub Signin_Click(sender As Object, e As EventArgs) Handles Signin_Button.Click
        Signin.Show()
        Me.Hide()

    End Sub

    Private Sub operation_Button_Click(sender As Object, e As EventArgs) Handles operation_Button.Click

        If TestMode Then
            MaintenanceMainMenu.Show()
            Me.Hide()
        Else
            Password.Show()
        End If
        '如果是测试模式，免输密码
    End Sub
    '点击设置时输入密码

    Private Sub SearchData_Button_Click(sender As Object, e As EventArgs) Handles SearchData_Button.Click
        SearchData.Show()
        Me.Hide()

    End Sub

End Class