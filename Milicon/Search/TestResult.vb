Imports System.ComponentModel
Imports System.Data.OleDb

Public Class TestResult

    Private Sub UItxt()

        Me.Text = ini.GetIniString("TestResult", "Title", "N/A")
        Me.OK_Button.Text = ini.GetIniString("TestResult", "Button1", "N/A")
        Me.Cancel_Button.Text = ini.GetIniString("TestResult", "Button2", "N/A")
        Me.Print_Button.Text = ini.GetIniString("TestResult", "Button3", "N/A")
        Me.Exit_Button.Text = ini.GetIniString("TestResult", "Button4", "N/A")
        Me.ProDate_Label.Text = ini.GetIniString("TestResult", "Label1", "N/A")
        Me.Lots_Label.Text = ini.GetIniString("TestResult", "Label2", "N/A")
        Me.TestDate_Label.Text = ini.GetIniString("TestResult", "Label3", "N/A")
        Me.Tester_Label.Text = ini.GetIniString("TestResult", "Label4", "N/A")
    End Sub
    '初始化文本

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

        Dim sql = "Select * from Data_List, Object_List, " + TableName + " where Object_List.Obj_Name=" + TableName + ".Obj_Name and  Data_list.Obj_ID=Object_List.Obj_ID and Data_List.LoginNo = " + TestID
        da = New OleDbDataAdapter(sql, cn)
        da.Fill(result, "GetTestData")

        Return result
    End Function
    '根据测试ID，返回测试项目DS

    Private Sub FillByTestInfo(ByVal LoginNo As String)
        DBcon()

        Dim TestInfo As DataSet = New DataSet
        TestInfo = GetTestInfoByLoginNo(LoginNo)

        Me.ProDate_DateTimePicker.Text = TestInfo.Tables(0).Rows(0)("ProDate")
        Me.Lots_TextBox.Text = TestInfo.Tables(0).Rows(0)("Lots")
        Me.TestDate_DateTimePicker.Text = TestInfo.Tables(0).Rows(0)("TestDate")
        Me.Tester_TextBox.Text = TestInfo.Tables(0).Rows(0)("Tester")

    End Sub
    '根据测试批号查找测试信息

    Private Function FillRowData(ByVal DB As DataSet, ByVal i As Integer)

        Dim Val(3) As String
        Dim Temp As String

        For j = 1 To 3
            Temp = DB.Tables(0).Rows(0)("Value" & i & "_" & j).ToString
            If Temp = "" Then
                Val(j - 1) = "/"
            Else
                Val(j - 1) = Temp
            End If
        Next

        Return Val
    End Function
    '根据行数返回对应的测试数据，用于FillByTestData过程

    Private Sub FillByTestData(ByVal LoginNo As String)
        DBcon()

        Dim TestData As DataSet = New DataSet
        Dim TestItem As DataSet = New DataSet
        Dim TI_Name As String
        Dim Val(3) As String

        TestData = GetTestData(LoginNo)
        '根据ID检索测试数据
        TestItem = GetTestItem(LoginNo)
        '根据ID检索测试项目

        Dim Num = TestItem.Tables(0).Rows(0)("TI_Num")
        '获取测试项目数量

        TestData_DataGridView.Columns.Add("1", "①")
        TestData_DataGridView.Columns.Add("2", "②")
        TestData_DataGridView.Columns.Add("3", "③")
        '加上三列

        For i = 1 To Num
            Val = FillRowData(TestData, i)
            TI_Name = TestItem.Tables(0).Rows(0)("TI" & i & "_Name")
            TestData_DataGridView.Rows.Add(Val(0), Val(1), Val(2))
            TestData_DataGridView.Rows(i - 1).HeaderCell.Value = TI_Name
        Next
        '填充测试数据

        cn.Close()

    End Sub
    '填充DGV

    Private Sub TestResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TestLots_Label.Text = SearchData.TestLots

        UItxt()
        '初始化UI文本

        FillByTestInfo(Me.TestLots_Label.Text)
        '显示测试信息

        FillByTestData(Me.TestLots_Label.Text)

    End Sub
    '载入初始化

    Private Sub TestResult_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SearchData.Show()
    End Sub
    '关闭窗口后显示检索窗口

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click

        FillByTestInfo(Me.TestLots_Label.Text)
        '显示测试信息

        FillByTestData(Me.TestLots_Label.Text)
    End Sub
    '点取消重新加载

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    '点退出按钮退出


End Class