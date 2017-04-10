Imports System.Data.OleDb

Public Class Maintenance_ObjectList

    Private Sub ComboBoxData(ByRef c As DataGridViewComboBoxColumn)
        c.HeaderText = "材料类型"
        c.Name = "Obj_Name"
        '定义DGV下拉列表列

        Dim Type_Combobox_Datatable As DataTable = New DataTable
        Type_Combobox_Datatable.Columns.Add("id", Type.GetType("System.String"))
        Type_Combobox_Datatable.Columns.Add("name", Type.GetType("System.String"))
        '建立数据表

        Dim sql As String = "select Type_ID, Obj_Type from ObjectType_List"
        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet
        '准备查询所有材料类型

        da.Fill(ds, "FillComboBoxByObjType")
        Dim RowsCount = ds.Tables(0).Rows.Count
        '建立数据集，统计记录数

        Dim i
        For i = 0 To RowsCount - 1
            Dim Type_ID As String = ds.Tables(0).Rows(i)(0).ToString
            Dim Obj_Type As String = ds.Tables(0).Rows(i)(1).ToString
            'Type_Combobox_Datatable.Rows.Add(Type_ID, Obj_Type)
            Type_Combobox_Datatable.Rows.Add(Obj_Type, Obj_Type)
        Next
        '将查询结果（数据集）添加到数据表中

        c.DataSource = Type_Combobox_Datatable
        c.ValueMember = "id"
        c.DisplayMember = "name"
        c.DataPropertyName = "Type"
        '将下拉列表绑定数据源

    End Sub
    '绑给combobox绑定数据源

    Private Sub ChangeDGVWithCombobox()

        Dim Type_Column As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn
        ComboBoxData(Type_Column)
        '为该列绑定数据源

        ObjectList_DataGridView.Columns.Insert(0, Type_Column)
        '将下拉列表列插入到DGV第一列

        For i = 0 To ObjectList_DataGridView.Rows.Count - 1
            Dim type As String = ObjectList_DataGridView.Rows(i).Cells(2).Value
            If type <> "" Then
                'ObjectList_DataGridView.Rows(i).Cells(0).Value = GetIDByType(type)
                ObjectList_DataGridView.Rows(i).Cells(0).Value = type
            End If
        Next
        '将下拉列表的默认值设为与DS中材料类型一致
        '之后考虑用枚举优化

        ObjectList_DataGridView.Columns.RemoveAt(2)
        '删除材料类型列，用combobox替换

    End Sub
    '用Combobox替换DGV中材料类型列

    Private Sub Maintenance_ObjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ResetDGV(Me)
        FillDGVbyObjecList(Me.ObjectList_DataGridView)
        disenableSort(Me.ObjectList_DataGridView)
        '以材料列表填充DGV

        ChangeDGVWithCombobox()
        '用Combobox替换DGV中材料类型列

    End Sub
    '窗口加载时填充DGV

    Public Function DB_RowCount(ByVal TableName As String) As Integer
        Dim Max As Integer = 0
        Dim da As OleDbDataAdapter
        Dim ds As DataSet
        'Dim sql As String = "SELECT Count(Object_List.Code4) AS [Row Count] FROM Object_List"
        Dim sql As String = "SELECT * FROM " + TableName

        DBcon()

        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet

        da.Fill(ds, "result")

        'Max = ds.Tables(0).Rows(0)(0).ToString
        Max = ds.Tables(0).Rows.Count

        Return Max
        cn.Close()

    End Function
    '输入表名，返回记录数

    Private Sub UpdateNewDate()

        Dim tempStrSQL As String
        Dim i As Integer = 0

        For i = DB_RowCount("Object_List") To Me.ObjectList_DataGridView.Rows.Count - 2
            'i从数据库记录数到DGV行数递增
            If ObjectList_DataGridView.Rows(i).Cells(1).ToString = "" Then
                '判断是否填入新行
                Exit For
            ElseIf True Then

                Dim Obj_Type As String = ObjectList_DataGridView.Rows(i).Cells(0).Value.ToString.Trim
                Dim Obj_Name As String = ObjectList_DataGridView.Rows(i).Cells(2).Value.ToString.Trim
                Dim Obj_Sup As String = ObjectList_DataGridView.Rows(i).Cells(3).Value.ToString.Trim

                Dim SendValues = "('" + Obj_Type + "','" + Obj_Name + "','" + Obj_Sup + "')"
                tempStrSQL = "INSERT INTO Object_List (Obj_Type, Obj_Name, Obj_Sup) VALUES " + SendValues

                Dim cmd As OleDbCommand = New OleDbCommand(tempStrSQL, cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                '依次将DGV每行数据填入cmd中
            End If
        Next
        MessageBox.Show("保存成功", "信息")
        cn.Close()
    End Sub
    '将新增数据填入DB中

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    '点击关闭按钮关闭

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ResetDGV(Me)
        FillDGVbyObjecList(Me.ObjectList_DataGridView)
        disenableSort(Me.ObjectList_DataGridView)
        '以材料列表填充DGV

        ChangeDGVWithCombobox()
        '用Combobox替换DGV中材料类型列
    End Sub
    '点击取消按钮取消输入（重新读取）

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateNewDate()
    End Sub
    '点击登录按钮，将新增数据填入DB中

    Private Sub Maintenance_ObjectList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        MaintenanceMainMenu.Show()
    End Sub

    '点击删除按钮删除选中材料
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim num = ObjectList_DataGridView.CurrentRow.Cells("材料ID").Value
        '获取选中材料的ID

        Dim sel = MsgBox("确定要删除'" & ObjectList_DataGridView.CurrentRow.Cells("材料名").Value & "'？", 4, "确认删除")
        If sel <> 6 Then
            Exit Sub
        End If
        '如果不点确定，跳过

        Dim sql As String = "DELETE FROM Object_List Where Obj_ID = " & num
        'DELETE FROM Person WHERE LastName = 'Wilson' 

        Dim cmd As OleDbCommand = New OleDbCommand(sql, cn)

        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("删除成功！")

        ResetDGV(Me)
        FillDGVbyObjecList(Me.ObjectList_DataGridView)
        disenableSort(Me.ObjectList_DataGridView)
        '以材料列表填充DGV

        ChangeDGVWithCombobox()
        '用Combobox替换DGV中材料类型列

    End Sub
End Class