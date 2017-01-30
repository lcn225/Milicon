Public Class ObjectMaintenance

    Private Sub TextFormat()

        Me.Text = ini.GetIniString("ObjectMaintenance", "Title", "N/A")
        Me.ObjectList_Button.Text = ini.GetIniString("ObjectMaintenance", "Button1", "N/A")
        Me.Signin_Button.Text = ini.GetIniString("ObjectMaintenance", "Button2", "N/A")
        Me.Cancel_Button.Text = ini.GetIniString("ObjectMaintenance", "Button3", "N/A")
        Me.Exit_Button.Text = ini.GetIniString("ObjectMaintenance", "Button4", "N/A")
    End Sub
    'UI文本初始化

    Private Sub ObjectMaintenance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainMenu.Show()
    End Sub

    Private Sub ObjectMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextFormat()
    End Sub
End Class

