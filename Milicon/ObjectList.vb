Imports System.ComponentModel

Public Class ObjectList

    Dim SelectRowNumber As String = 0
    '默认选中第一行

    Private Sub ObjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“MiliconObjectList_DataSet.Obejct_List”中。您可以根据需要移动或删除它。
        Me.Obejct_ListTableAdapter.Fill(Me.MiliconObjectList_DataSet.Obejct_List)

        Me.Text = ini.GetIniString("ObjectList", "Title", "Title")
        Me.OK_Button.Text = ini.GetIniString("ObjectList", "Button1", "OK")
        Me.Cancel_Button.Text = ini.GetIniString("ObjectList", "Button2", "Cancel")
        '文本初始化

    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        SelectRowNumber = Me.ObjectList_DataGridView.CurrentRow.Index
        Signin.NameInput_TextBox.Text = ObjectList_DataGridView.Rows(SelectRowNumber).Cells(0).Value
        '按OK后将选中行的第一单元格数据传输至规格值输入框
        Me.Close()
    End Sub
    '点击OK选中材料名称

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
    '点取消按钮直接退出

    Private Sub ObjectList_DataGridView_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ObjectList_DataGridView.MouseDoubleClick
        SelectRowNumber = Me.ObjectList_DataGridView.CurrentRow.Index
        Signin.NameInput_TextBox.Text = ObjectList_DataGridView.Rows(SelectRowNumber).Cells(0).Value
        '按OK后将选中行的第一单元格数据传输至规格值输入框
        Me.Close()
    End Sub
    '双击选中材料名称


End Class