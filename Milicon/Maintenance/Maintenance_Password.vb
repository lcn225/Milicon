Public Class Maintenance_Password

    Dim sel As String = ""

    Private Sub TextFormat()
        Me.Text = ini.GetIniString("Maintenance_PW", "Title", "N/A")
        Me.RadioButton1.Text = ini.GetIniString("Maintenance_PW", "Radio1", "N/A")
        Me.RadioButton2.Text = ini.GetIniString("Maintenance_PW", "Radio2", "N/A")
        Me.Label1.Text = ini.GetIniString("Maintenance_PW", "Label1", "N/A")
        Me.Label2.Text = ini.GetIniString("Maintenance_PW", "Label2", "N/A")
        Me.Label3.Text = ini.GetIniString("Maintenance_PW", "Label3", "N/A")
        Me.OK_Button.Text = ini.GetIniString("Maintenance_PW", "Button1", "N/A")
        Me.Cancel_Button.Text = ini.GetIniString("Maintenance_PW", "Button2", "N/A")
    End Sub
    'UI文本初始化

    Private Sub Maintenance_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextFormat()
        Me.OK_Button.Enabled = False

    End Sub

    '如果选择了密码类型，启用OK按钮
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        sel = "ChangeData_PW"
        Me.OK_Button.Enabled = True
    End Sub

    '如果选择了密码类型，启用OK按钮
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        sel = "Set_PW"
        Me.OK_Button.Enabled = True
    End Sub

    '关闭窗口时打开维护菜单
    Private Sub Maintenance_Password_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MaintenanceMainMenu.Show()
    End Sub

    '重置输入密码
    Private Sub reset()
        For Each F As Control In Me.Controls
            If TypeOf F Is TextBox Then
                F.Text = ""
            End If
        Next

    End Sub

    '点击OK后开始检验输入字符，没问题则更新密码
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click

        Dim oldPW As String = encryption(oldPW_TextBox.Text)

        If oldPW <> ini.GetIniString("SW", sel, "N/A") Then
            MsgBox("旧密码输入错误")
            reset()
        Else
            If newPW_TextBox.Text <> renewPW_TextBox.Text Then
                MsgBox("两次新密码不一致，请确认")
                reset()
            Else
                '今后加入新密码复杂度确认
                Dim t As New ini
                t.WriteINI("SW", sel, encryption(newPW_TextBox.Text))
                MsgBox("密码修改成功")
                Me.Close()
            End If

        End If

    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
End Class