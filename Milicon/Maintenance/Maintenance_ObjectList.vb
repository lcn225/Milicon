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
            Type_Combobox_Datatable.Rows.Add(Type_ID, Obj_Type)
        Next
        '将查询结果（数据集）添加到数据表中

        c.DataSource = Type_Combobox_Datatable
        c.ValueMember = "id"
        c.DisplayMember = "name"
        c.DataPropertyName = "Type"
        '将下拉列表绑定数据源

    End Sub

    Private Sub ChangeDGVWithCombobox()

        Dim Type_Column As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn

        ComboBoxData(Type_Column)

        ObjectList_DataGridView.Columns.Insert(0, Type_Column)
        '将下拉列表列插入到DGV第一列



        For i = 0 To ObjectList_DataGridView.Rows.Count - 1
            Dim type As String = ObjectList_DataGridView.Rows(i).Cells(2).Value
            If type <> "" Then
                ObjectList_DataGridView.Rows(i).Cells(0).Value = GetIDByType(type)
            End If
        Next
        '将下拉列表的默认值设为与DS中材料类型一致

        ObjectList_DataGridView.Columns.RemoveAt(2)
        '删除材料类型列，用combobox替换

    End Sub
    '用Combobox替换DGV中材料类型列

    Private Sub Maintenance_ObjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FillDGVbyObjecList(Me.ObjectList_DataGridView)
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

        For i = DB_RowCount("Object_List") To Me.ObjectList_DataGridView.Rows.Count
            'i从数据库记录数到DGV行数递增
            If ObjectList_DataGridView.Rows(i).Cells(1).Value = "" Then
                '判断是否填入新行
                Exit For
            ElseIf True Then

                Dim Obj_Type As String = ObjectList_DataGridView.Rows(i).Cells(1).Value.ToString.Trim
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
        FillDGVbyObjecList(Me.ObjectList_DataGridView)

    End Sub
    '点击取消按钮取消输入（重新读取）

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateNewDate()
    End Sub
    '点击登录按钮，将新增数据填入DB中

    Private Sub Maintenance_ObjectList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        MaintenanceMainMenu.Show()
    End Sub



End Class