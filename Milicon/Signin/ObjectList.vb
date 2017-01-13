Imports System.ComponentModel
Imports System.Data.OleDb

Public Class ObjectList

    Dim SelectRowNumber As String = 0
    '默认选中第一行

    Private Sub FillComboBoxByObjType()
        Me.ObjectType_ComboBox.Items.Add("所有材料")
        '在下拉列表中增加第一行，全部材料

        'Signin.cn.Open()

        Dim sql As String = "select Obj_Type from ObjectType_List"
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(sql, Signin.cn)
        Dim ds As DataSet = New DataSet
        '准备查询所有材料类型

        da.Fill(ds, "result")
        Dim RowsCount = ds.Tables(0).Rows.Count
        '建立数据集，统计记录数

        Dim i
        For i = 0 To RowsCount - 1
            Dim Type As String = ds.Tables(0).Rows(i)(0)
            Me.ObjectType_ComboBox.Items.Add(Type)
        Next
        '将查询结果（数据集）添加到Combobox中

        Signin.cn.Close()

    End Sub
    '用材料类型列表填充下拉列表

    Private Sub FillDGV()
        Dim sql As String = "select ID,Obj_Type as 材料类型,Obj_Name as 材料名,Obj_Sup as 厂商 from Object_List ORDER  by Obj_Type, Obj_Name, Obj_Sup"
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(sql, Signin.cn)
        Dim ds As DataSet = New DataSet
        '准备查询所有材料的ID与名称与厂商

        da.Fill(ds, "result")

        ObjectList_DataGridView.DataSource = ds.Tables(0)
        ObjectList_DataGridView.Columns(0).Visible = False
        '隐藏第一列“ID”

    End Sub
    '参数为空时，该方法用TYPE表内全部数据填充DGV

    Private Sub FillDGV(ByVal Type As String)

        Dim sql As String = "select ID,Obj_Type as 材料类型,Obj_Name as 材料名,Obj_Sup as 厂商 from Object_List where Obj_Type = '" + Type + "' ORDER  by Obj_Type, Obj_Name, Obj_Sup"
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(sql, Signin.cn)
        Dim ds As DataSet = New DataSet
        '准备查询所有材料名称与厂商

        da.Fill(ds, "result")

        ObjectList_DataGridView.DataSource = ds.Tables(0)
        ObjectList_DataGridView.Columns(0).Visible = False
        '隐藏第一列“ID”

    End Sub
    '参数为材料种类时，该方法使DGV仅显示全部该种类材料

    Private Sub ObjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: 这行代码将数据加载到表“ObjectList_DataSet.Object_List”中。您可以根据需要移动或删除它。
        Me.Object_ListTableAdapter.Fill(Me.ObjectList_DataSet.Object_List)

        Me.Text = ini.GetIniString("ObjectList", "Title", "Title")
        Me.OK_Button.Text = ini.GetIniString("ObjectList", "Button1", "OK")
        Me.Cancel_Button.Text = ini.GetIniString("ObjectList", "Button2", "Cancel")

        Signin.DBcon()

        FillComboBoxByObjType()
        FillDGV()

    End Sub
    '窗体初始化

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        SelectRowNumber = Me.ObjectList_DataGridView.CurrentRow.Index
        Signin.NameInput_TextBox.Text = ObjectList_DataGridView.Rows(SelectRowNumber).Cells(2).Value
        '按OK后将选中行的第三单元格数据传输至规格值输入框
        Signin.ID_Object = ObjectList_DataGridView.Rows(SelectRowNumber).Cells(0).Value
        '将选中材料的ID赋予Signin的ID参数（查询用）
        Me.Close()
    End Sub
    '点击OK选中材料名称

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
    '点取消按钮直接退出

    Private Sub ObjectList_DataGridView_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ObjectList_DataGridView.MouseDoubleClick
        SelectRowNumber = Me.ObjectList_DataGridView.CurrentRow.Index
        Signin.NameInput_TextBox.Text = ObjectList_DataGridView.Rows(SelectRowNumber).Cells(2).Value
        '按OK后将选中行的第三单元格数据传输至规格值输入框
        Signin.ID_Object = ObjectList_DataGridView.Rows(SelectRowNumber).Cells(0).Value
        '将选中材料的ID赋予Signin的ID参数（查询用）
        Me.Close()
    End Sub
    '双击选中材料名称

    Private Sub ObjectType_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ObjectType_ComboBox.SelectedIndexChanged

        Dim selected As String = ObjectType_ComboBox.SelectedItem.ToString
        '获取变更后所选字符串

        If selected = "所有材料" Then
            FillDGV()
            '如果所选为所有材料时，DGV显示所有材料
        Else
            FillDGV(selected)
            '否则显示所选种类材料
        End If
    End Sub
    '当改变下拉列表选择时，改变DGV显示

    Private Sub ObjectList_Close() Handles MyBase.Closing
        Signin.Temp_Label.Text = Signin.ID_Object
    End Sub

End Class