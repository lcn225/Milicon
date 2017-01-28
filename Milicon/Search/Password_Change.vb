Public Class Password_Change
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click

        Dim PW = ini.GetIniString("SW", "ChangeData_PW", "NAini")
        Dim PW_IN = encryption(TextBox1.Text)
        '加密输入值

        If PW = PW_IN Then
            '对比ini中的PW
            TestResult.UpdateChange()
            Me.Hide()
            '相同则变更数据
        Else
            MessageBox.Show("密码错误，请重新输入", "错误")
            '不同则报错
        End If

    End Sub
    '按OK确认密码，正确则进入维护窗口

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        'MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class