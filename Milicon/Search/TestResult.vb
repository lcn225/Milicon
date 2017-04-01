Imports System.ComponentModel
Imports System.Data.OleDb

Public Class TestResult

    Private Sub UItxt()

        Me.Text = ini.GetIniString("TestResult", "Title", "N/A")
        Me.OK_Button.Text = "F1" & vbLf & ini.GetIniString("TestResult", "Button1", "N/A")
        Me.Cancel_Button.Text = "F2" & vbLf & ini.GetIniString("TestResult", "Button2", "N/A")
        Me.Print_Button.Text = "F7" & vbLf & ini.GetIniString("TestResult", "Button3", "N/A")
        Me.Exit_Button.Text = "F12" & vbLf & ini.GetIniString("TestResult", "Button4", "N/A")
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

        Dim sql = "select * from Data_List where LoginNo = " + TestID
        da = New OleDbDataAdapter(sql, cn)
        da.Fill(result, "GetTestData")

        Return result
    End Function
    '根据测试ID，返回测试数据DS

    Private Function GetTestItem(ByVal TestID As String) As DataSet

        DBcon()

        Dim TableName_DS As DataSet = New DataSet
        Dim result As DataSet = New DataSet
        Dim Obj_ID As String = GetObjIDByLoginNo(TestID)

        Dim sql = "Select * from Object_List where Obj_ID = " + Obj_ID
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

    Private Function FillRowData(ByVal DB As DataSet, ByVal i As Integer, ByVal Qty As Integer)

        Dim Val(Qty) As String
        Dim Temp As String

        For j = 1 To Qty
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
        Dim TI_Type As String
        Dim TI_Stand As String
        Dim TI_Range As String
        Dim TI_Acc As Integer

        TestData = GetTestData(LoginNo)
        '根据ID检索测试数据
        TestItem = GetTestItem(LoginNo)
        '根据ID检索测试项目

        Dim Num = TestItem.Tables(0).Rows(0)("TI_Num")
        '获取测试项目数量

        Dim MAXQty As Integer = getMAXQtyByID(GetObjIDByLoginNo(LoginNo))
        'Dim MAXQty As Integer = getMAXQtyByID(TestData.Tables(0).Rows(0)("Obj_ID"))
        '获取该测试批号对应规格各TI最大样本数

        TestData_DataGridView.Columns.Add("Stand", "规格值")
        TestData_DataGridView.Columns("Stand").Width = 80
        TestData_DataGridView.Columns("Stand").ReadOnly = True
        '新增规格值列

        Dim width As Single = 300 / MAXQty
        '设定列宽度
        For i = 1 To MAXQty
            TestData_DataGridView.Columns.Add(i, Chr(i - 23848))
            TestData_DataGridView.Columns(i).Width = width
        Next
        '根据样本数添加若干列

        For i = 1 To Num
            Val = FillRowData(TestData, i, 3)
            '返回测试数据
            TI_Name = TestItem.Tables(0).Rows(0)("TI" & i & "_Name")
            TI_Type = TestItem.Tables(0).Rows(0)("TI" + i.ToString + "_Type")
            TI_Stand = TestItem.Tables(0).Rows(0)("TI" + i.ToString + "_Stand")
            TI_Range = TestItem.Tables(0).Rows(0)("TI" + i.ToString + "_Range")
            TI_Acc = TestItem.Tables(0).Rows(0)("TI" + i.ToString + "_Acc")
            '获取字段名为"TIi_Stand"与"TIi_Range"的值，i为参数
            TestData_DataGridView.Rows.Add(standAndRange(TI_Type, TI_Stand, TI_Range), Val(0), Val(1), Val(2))
            '增加一行
            TestData_DataGridView.Rows(i - 1).DefaultCellStyle.Format = "F" & TI_Acc
            '设精度
            TestData_DataGridView.Rows(i - 1).HeaderCell.Value = TI_Name
            '改每行标题
        Next
        '填充测试数据

        Dim Obj_ID As String = TestData.Tables(0).Rows(0)("Obj_ID").ToString

        'mergeCell(Obj_ID, Me.TestData_DataGridView)
        '根据样本数量合并单元格

        disenableSort(Me.TestData_DataGridView)
        '禁用点击排序

        cn.Close()

    End Sub
    '填充DGV

    Private Function UpdateTestInfo() As String

        DBcon()

        Dim LoginNo As String = Me.TestLots_Label.Text
        Dim ProDate As String = Me.ProDate_DateTimePicker.Text
        Dim Lots As String = Me.Lots_TextBox.Text
        Dim TestDate As String = Me.TestDate_DateTimePicker.Text
        Dim Tester As String = Me.Tester_TextBox.Text

        Dim sql As String = "UPDATE Data_List SET ProDate = '" + ProDate + "',Lots = '" + Lots + "',TestDate = '" + TestDate + "',Tester = '" + Tester + "' WHERE LoginNo= " + LoginNo

        Return sql

    End Function
    '更新测试信息至数据库（返回字符串）

    Private Function UpDateTestData() As String
        DBcon()

        Dim sql As String

        Dim TestLots As String = Me.TestLots_Label.Text
        Dim Str_Col As String = ""
        Dim Str_Val As String = ""
        Dim Str As String = ""
        '用Str_Col和Str_Val分别获取字段名与字段，再组合到Str中

        Dim RowsCount As Integer = TestData_DataGridView.RowCount
        '获取DGV总行数

        For i = 0 To RowsCount - 1
            For j = 0 To 2
                Str_Col = "Value" + （i + 1）.ToString + "_" + （j + 1）.ToString
                If TestData_DataGridView.Rows(i).Cells(j).Value = "" Then
                    Str_Val = "'0'"
                Else
                    Str_Val = "'" + TestData_DataGridView.Rows(i).Cells(j + 1).Value + "'"
                End If
                Str = Str + Str_Col + " = " + Str_Val + ", "
                '生成"ValueI_J='X', "的连续字符串
            Next
        Next
        Str = Mid(Str, 1, Len(Str) - 2)
        '删去最后两位（即多出来的", "）

        sql = "UPDATE Data_List SET " + Str + " WHERE LoginNo = " + TestLots
        'UPDATE Person SET FirstName = 'Fred' WHERE LastName = 'Wilson' 

        Return sql

    End Function
    '更新测试数据至数据库（返回字符串）

    Private Sub ClearForReset()

        ResetFormText(Me)

        ResetDGV(Me)

    End Sub
    '清空所有输入控件信息以备重置

    Private Sub TestResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TestLots_Label.Text = SearchData.TestLots

        UItxt()
        '初始化UI文本

        FillByTestInfo(Me.TestLots_Label.Text)
        '显示测试信息

        FillByTestData(Me.TestLots_Label.Text)
        '显示测试数据

    End Sub
    '载入初始化

    Private Sub TestResult_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SearchData.Show()
    End Sub
    '关闭窗口后显示检索窗口

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click

        ClearForReset()

        FillByTestInfo(Me.TestLots_Label.Text)
        '显示测试信息

        FillByTestData(Me.TestLots_Label.Text)
        '显示测试数据
    End Sub
    '点取消重新加载

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    '点退出按钮退出

    Public Sub UpdateChange()


        Dim sql1 As String
        Dim sql2 As String
        Dim cmd As OleDbCommand

        sql1 = UpdateTestInfo()
        sql2 = UpDateTestData()

        cn.Open()

        cmd = New OleDbCommand(sql1, cn)
        cmd.ExecuteNonQuery()
        cmd = New OleDbCommand(sql2, cn)
        cmd.ExecuteNonQuery()

        MessageBox.Show("变更成功")

        cn.Close()

        '之后加一个成功一个失败时的防错

    End Sub
    '更新DGV变动至DB（配合确认按钮）

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Dim SigninCheck As String = ""

        SigninCheck = MessageBox.Show(“是否输入完毕？”, “登录确认”, MessageBoxButtons.YesNo)
        If SigninCheck = 6 Then
            '如果返回值为6，则为选择“是”
            Password_Change.Show()
            '提交变动至DB
        End If

    End Sub
    '点确定保存修改

    Private Sub Print_Button_Click(sender As Object, e As EventArgs) Handles Print_Button.Click

    End Sub
    '点击打印开始打印

    '设置快捷键
    Private Sub Signin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.F1 And OK_Button.Enabled = True Then
            OK_Button_Click(Me, e)
        End If

        If e.KeyCode = Keys.F2 Then
            Cancel_Button_Click(Me, e)
        End If

        If e.KeyCode = Keys.F7 Then
            print_Button_Click(Me, e)
        End If

        If e.KeyCode = Keys.F12 Then
            Exit_Button_Click(Me, e)
        End If
    End Sub

End Class