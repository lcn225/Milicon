Public Class Signin

    Private Sub TextFormat()

        Me.Text = ini.GetIniString("Signin", "Title", "N/A")
        Me.ObjectList_Button.Text = ini.GetIniString("Signin", "Button1", "N/A")
        Me.ObjectInput_Button.Text = ini.GetIniString("Signin", "Button2", "N/A")
        Me.ProDate_Label.Text = ini.GetIniString("Signin", "Label1", "N/A")
        Me.Lots_Label.Text = ini.GetIniString("Signin", "Label2", "N/A")
        Me.TestDate_Label.Text = ini.GetIniString("Signin", "Label3", "N/A")
        Me.Tester_Label.Text = ini.GetIniString("Signin", "Label4", "N/A")
    End Sub


    Private Sub Signin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“DataList_DataSet.Data_List”中。您可以根据需要移动或删除它。
        Me.Data_ListTableAdapter.Fill(Me.DataList_DataSet.Data_List)

        TextFormat()
        '初始化界面文本


    End Sub


    Private Sub Signin_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        MainMenu.Show()
    End Sub

    Private Sub ObjectList_Button_Click(sender As Object, e As EventArgs) Handles ObjectList_Button.Click
        ObjectList.Show()
    End Sub

    Private Sub ObjectInput_Button_Click(sender As Object, e As EventArgs) Handles ObjectInput_Button.Click
        TestDateInput_DataGridView.Rows.Add(2)
    End Sub
End Class