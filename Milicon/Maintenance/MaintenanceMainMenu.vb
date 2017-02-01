Public Class MaintenanceMainMenu
    Private Sub MaintenanceMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ini.GetIniString("MaintenanceMainMenu", "Title", "")
        Me.Label1.Text = ini.GetIniString("MaintenanceMainMenu", "Label", "")
        Me.Button1.Text = ini.GetIniString("MaintenanceMainMenu", "Button1", "")
        Me.Button2.Text = ini.GetIniString("MaintenanceMainMenu", "Button2", "")
        Me.Button3.Text = ini.GetIniString("MaintenanceMainMenu", "Button3", "")
        Me.Button4.Text = ini.GetIniString("MaintenanceMainMenu", "Button4", "")
        Me.Button5.Text = ini.GetIniString("MaintenanceMainMenu", "Button5", "")
    End Sub
    '自动加载UI

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        MainMenu.Show()
    End Sub
    '点击退出按钮退出

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Maintenance_ObjectList.Show()
        Me.Hide()
    End Sub
    '点击按钮1进入材料维护

    Private Sub MaintenanceMainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainMenu.Show()
    End Sub
End Class