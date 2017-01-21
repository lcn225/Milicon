Imports System.Data.OleDb
Public Class SearchData

    Public TestLots As String = 0

    Private Sub TextFormat()

        Me.Text = ini.GetIniString("SearchData", "Title", "N/A")
        Me.Search_Button.Text = ini.GetIniString("SearchData", "Button1", "N/A")
        Me.OK_Button.Text = ini.GetIniString("SearchData", "Button2", "N/A")
        Me.Clear_Button.Text = ini.GetIniString("SearchData", "Button3", "N/A")
        Me.Del_Button.Text = ini.GetIniString("SearchData", "Button4", "N/A")
        Me.Exit_Button.Text = ini.GetIniString("SearchData", "Button5", "N/A")
        Me.RadioButton1.Text = ini.GetIniString("SearchData", "RadioButton1", "N/A")
        Me.RadioButton2.Text = ini.GetIniString("SearchData", "RadioButton2", "N/A")
        Me.Label5.Text = ini.GetIniString("SearchData", "Label5", "N/A")
    End Sub
    'UI文本初始化

    Private Sub Top20()
        DBcon()

        Dim sql As String = "Select Top 20 * from Data_List order by LoginNo desc"
        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "TOP20")

        TestList_DataGridView.DataSource = ds.Tables(0)
        '应插入连接关系查询

        cn.Close()

    End Sub
    '在DGV中显示最新20条结果

    Private Sub CountDGV()
        Dim qty As String = TestList_DataGridView.RowCount
        Me.Label6.Text = "共" + qty + "条记录"
    End Sub
    '显示DGV行数

    Private Function SearchTestData() As DataSet
        Dim sql = StrOfSearch()
        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet

        da.Fill(ds, "SearchTestData")

        Return ds
    End Function
    '根据搜索条件，返回搜索结果dataset

    Private Sub FillComboBox()
        Me.ObjectType_ComboBox.Items.Add("所有材料")
        '在下拉列表中增加第一行，全部材料

        'cn.Open()

        Dim sql As String = "select Obj_Type from ObjectType_List"
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(sql, cn)
        Dim ds As DataSet = New DataSet
        '准备查询所有材料类型

        da.Fill(ds, "FillComboBoxByObjType")
        Dim RowsCount = ds.Tables(0).Rows.Count
        '建立数据集，统计记录数

        Dim i
        For i = 0 To RowsCount - 1
            Dim Type As String = ds.Tables(0).Rows(i)(0)
            Me.ObjectType_ComboBox.Items.Add(Type)
        Next
        '将查询结果（数据集）添加到Combobox中

        ObjectType_ComboBox.SelectedIndex = 0
        '默认选中第一个

        cn.Close()
    End Sub
    '用材料类型列表填充下拉列表

    Private Function StrOfSearch() As String
        Dim TestDate As String = Nothing
        Dim TestLots As String = Nothing
        Dim TestType As String = Nothing

        Dim DateStart = Format(Me.DateStart_DateTimePicker.Value, "yyyy/MM/dd")
        Dim DateEnd = Format(Me.DateEnd_DateTimePicker.Value, "yyyy/MM/dd")
        Dim LotsStart As String = Me.LotsStart_TextBox.Text
        Dim LotsEnd As String = Me.LotsEnd_TextBox.Text
        Dim Obj_Type As String = Me.ObjectType_ComboBox.SelectedItem.ToString
        '获取搜索条件

        Dim sql As String = "Select Data_List.LoginNo As 测试编号, ObjectType_List.Obj_Type As 材料类型, Data_List.ProDate As 生产日期, Data_List.Lots As 批号, Data_List.TestDate As 测试日期, Data_List.Tester As 测试人 from Data_List, ObjectType_List where "
        'sql前置指令

        If Me.RadioButton1.Checked = True Then
            TestDate = "TestDate >= #" + DateStart + "# and TestDate <= #" + DateEnd + "#"
        ElseIf Me.RadioButton2.Checked = True Then
            TestLots = "LoginNo >= " + LotsStart + " and LoginNo <= " + LotsEnd
        Else
            MessageBox.Show("搜索条件错误")
        End If
        '如果单选日期搜索，赋值TestDate，TestLots为空；反之则反

        If Obj_Type = "所有材料" Then
            TestType = Nothing
        Else
            TestType = " and Obj_Type= '" + Obj_Type + "'"
        End If
        '如果材料不是选择所有材料，则进行筛选

        sql = sql + TestDate + TestLots + TestType
        '获得查询语句

        Return sql
    End Function
    '根据搜索条件获得查询语句

    Private Sub SearchData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextFormat()
        'UI文本初始化

        Top20()
        '在DGV中显示最新20条结果

        FillComboBox()
        '用材料类型列表填充下拉列表

        CountDGV()
        '更新结果数量统计

    End Sub
    '载入时初始化

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
        MainMenu.Show()
    End Sub
    '点击关闭按钮退出

    Private Sub Search_Button_Click(sender As Object, e As EventArgs) Handles Search_Button.Click
        Dim TestData As DataSet = New DataSet
        TestData = SearchTestData()
        TestList_DataGridView.DataSource = TestData.Tables(0)
        '搜索并在DGV中显示

        CountDGV()
        '更新结果数量统计

    End Sub
    '查询

    Private Sub TestList_DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TestList_DataGridView.CellDoubleClick
        Dim SelectRowNumber
        SelectRowNumber = Me.TestList_DataGridView.CurrentRow.Index
        Me.TestLots = Me.TestList_DataGridView.Rows(SelectRowNumber).Cells(0).Value

        TestResult.Show()
        Me.Hide()

    End Sub
    '双击打开测试结果

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click

        Dim SelectRowNumber
        SelectRowNumber = Me.TestList_DataGridView.CurrentRow.Index
        Me.TestLots = Me.TestList_DataGridView.Rows(SelectRowNumber).Cells(0).Value

        TestResult.Show()
        Me.Hide()
    End Sub
    '点击OK打开测试结果

End Class