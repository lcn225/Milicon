Imports System.ComponentModel
Imports System.Data.OleDb

Public Class TestResult

    Private Function GetTestData(ByVal TestID As String) As DataSet

        DBcon()

        Dim TableName_DS As DataSet = New DataSet
        Dim result As DataSet = New DataSet
        Dim DataTableName As String

        TableName_DS = GetTableNameByLoginNo(TestID)
        '根据测试批号获取表名DS
        DataTableName = TableName_DS.Tables(0).Rows(0)("DataTableName").ToString
        '获取测试数据表表名

        Dim sql = "select * from " + DataTableName + " where LoginNo = " + TestID
        da = New OleDbDataAdapter(sql, cn)
        da.Fill(result, "GetTestData")

        Return result
    End Function
    '根据测试ID，返回测试数据DS

    Private Function GetTestItem(ByVal TestID As String) As DataSet

        DBcon()

        Dim TableName_DS As DataSet = New DataSet
        Dim result As DataSet = New DataSet
        Dim TableName As String

        TableName_DS = GetTableNameByLoginNo(TestID)
        '根据测试批号获取表名DS
        TableName = TableName_DS.Tables(0).Rows(0)("TableName").ToString
        '获取测试数据表表名

        Dim sql = "select * from " + TableName + " where LoginNo = " + TestID
        da = New OleDbDataAdapter(sql, cn)
        da.Fill(result, "GetTestData")

        Return result
    End Function
    '根据测试ID，返回测试项目DS

    Private Sub FillByTestData(ByVal LoginNo As String)
        DBcon()

        Dim sql As String = ""
        Dim TestData As DataSet = New DataSet
        TestData = GetTestData(LoginNo)
        '根据ID检索测试数据

        TestData_DataGridView.DataSource = TestData.Tables(0)

    End Sub
    '填充DGV

    Private Sub TestResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TestLots_Label.Text = SearchData.TestLots

        FillByTestData(Me.TestLots_Label.Text)


    End Sub

    Private Sub TestResult_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SearchData.Show()
    End Sub

End Class