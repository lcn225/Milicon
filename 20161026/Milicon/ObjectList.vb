Public Class ObjectList

    Dim SelectRowNumber As String = 0

    Private Sub ObjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“MiliconObjectList_DataSet.Obejct_List”中。您可以根据需要移动或删除它。
        Me.Obejct_ListTableAdapter.Fill(Me.MiliconObjectList_DataSet.Obejct_List)

        Me.Text = ini.GetIniString("ObjectList", "Title", "Title")
        Me.OK_Button.Text = ini.GetIniString("ObjectList", "Button1", "OK")
        Me.Cancel_Button.Text = ini.GetIniString("ObjectList", "Button2", "Cancel")

    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        SelectRowNumber = Me.ObjectList_DataGridView.CurrentRow.Index
        Signin.NameInput_TextBox.Text = ObjectList_DataGridView.Rows(SelectRowNumber).Cells(0).Value
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

End Class