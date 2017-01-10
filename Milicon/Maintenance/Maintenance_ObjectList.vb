Imports System.Data.OleDb

Public Class Maintenance_ObjectList
    Private Sub Maintenance_ObjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“ObjectList_DataSet.Object_List”中。您可以根据需要移动或删除它。
        Me.Object_ListTableAdapter.Fill(Me.ObjectList_DataSet.Object_List)

    End Sub

    Private Function RowMax() As Integer

        Dim Max As Integer = 0
        Dim da As OleDbDataAdapter
        Dim ds As DataSet
        Dim cn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\192.168.2.100\DataBase\Milicon.mdb")
        Dim sql As String = "SELECT Count(Object_List.Code4) AS [Row Count] FROM Object_List"

        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet

        da.Fill(ds, "result")

        Max = ds.Tables(0).Rows(0)(0).ToString

        Return Max
    End Function
    '获取数据库当前记录数

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        MaintenanceMainMenu.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Object_ListTableAdapter.Fill(Me.ObjectList_DataSet.Object_List)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim tempStrSQL As String
        Dim cn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\192.168.2.100\DataBase\Milicon.mdb")
        cn.Open()
        Dim i As Integer = 0

        'RowMax为当前DataGridView中最大行号

        For i = RowMax() To Me.ObjectList_DataGridView.Rows.Count
            If ObjectList_DataGridView.Rows(i).Cells(2).Value = "" Then
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
            End If
        Next
        MessageBox.Show("保存成功", "信息")
        cn.Close()
    End Sub
End Class