Imports System.Data.OleDb

Public Class Maintenance_ObjectList
    Private Sub Maintenance_ObjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“ObjectList_DataSet.Object_List”中。您可以根据需要移动或删除它。
        Me.Object_ListTableAdapter.Fill(Me.ObjectList_DataSet.Object_List)

    End Sub

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
        DBcon()

        Dim tempStrSQL As String
        Dim i As Integer = 0

        For i = DB_RowCount("Object_List") To Me.ObjectList_DataGridView.Rows.Count
            'i从数据库记录数到DGV行数递增
            If ObjectList_DataGridView.Rows(i).Cells(2).Value = "" Then
                '判断是否填入新行
                Exit For
            ElseIf True Then
                Dim Code4 As String = ObjectList_DataGridView.Rows(i).Cells(0).Value.ToString.Trim
                Dim Code9 As String = ObjectList_DataGridView.Rows(i).Cells(1).Value.ToString.Trim
                Dim Obj_Name As String = ObjectList_DataGridView.Rows(i).Cells(2).Value.ToString.Trim
                Dim Obj_Sup As String = ObjectList_DataGridView.Rows(i).Cells(3).Value.ToString.Trim
                Dim Obj_Type As String = ObjectList_DataGridView.Rows(i).Cells(4).Value.ToString.Trim

                Dim SendValues = "('" + Code4 + "','" + Code9 + "','" + Obj_Name + "','" + Obj_Sup + "','" + Obj_Type + "')"
                tempStrSQL = "INSERT INTO Object_List VALUES " + SendValues

                Dim cmd As OleDbCommand = New OleDbCommand(tempStrSQL, cn)
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
        MaintenanceMainMenu.Show()
    End Sub
    '点击关闭按钮关闭

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Object_ListTableAdapter.Fill(Me.ObjectList_DataSet.Object_List)

    End Sub
    '点击取消按钮取消输入（重新读取）

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateNewDate()
    End Sub
    '点击登录按钮，将新增数据填入DB中

End Class