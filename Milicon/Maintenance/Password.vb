Public Class Password
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click

        Dim PW = ini.GetIniString("SW", "Set_PW", "NAini")
        Dim PW_IN = encryption(TextBox1.Text)
        '加密输入值

        If PW = PW_IN Then
            '对比ini中的PW
            MaintenanceMainMenu.Show()
            MainMenu.Hide()
            Me.Hide()
            '相同则进入维护窗口
        Else
            Dim text1 = MessageBox.Show("密码错误，请重新输入", "错误")
            '不同则报错
        End If

    End Sub
    '按OK确认密码，正确则进入维护窗口

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        'MainMenu.Show()
        Me.Hide()
    End Sub
End Class