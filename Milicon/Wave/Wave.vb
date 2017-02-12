Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Wave

    Public ID_Object As String = 0

    Private Sub fillCheckedListBoxByTI(ByVal ID_Obj As String)

        Dim sql As String = "Select * from Object_List Where Obj_ID = " + ID_Obj
        Dim TI_ds As DataSet = New DataSet

        da = New OleDbDataAdapter(sql, cn)
        da.Fill(TI_ds, "GetTIInfo")
        '获取指定材料的所有TI信息

        Dim num As Integer = TI_ds.Tables(0).Rows(0)("TI_Num").ToString
        Dim TI_Name As String = ""

        For i = 0 To num - 1
            TI_Name = TI_ds.Tables(0).Rows(0)("TI" & (i + 1) & "_Name").ToString
            TI_CheckedListBox.Items.Add(TI_Name)
        Next
        '添加TI至CLB中

        TI_CheckedListBox.SetItemChecked(0, True)
        '默认勾选第一项
        OK_Button.Enabled = True
        '启用OK按钮

    End Sub
    '将实验项目填充到CLB中

    Private Function getTestData(ByVal Obj_ID As String,
                                 ByVal TI_index As Integer,
                                 ByVal startDate As Date, ByVal EndendDate As Date) As DataTable

        Dim search_ds As DataSet = New DataSet

        Dim str As String = "LoginNo, TestDate"
        For i = 1 To 9
            str = str & ", Value" & (TI_index + 1) & "_" & i
        Next
        '获取数据所在字段名，格式为str

        Dim sql As String = "Select " & str & " from Data_List Where Obj_ID = " & Obj_ID & " and TestDate >= #" & startDate & "# and TestDate <= #" & EndendDate & "#"
        da = New OleDbDataAdapter(sql, cn)
        da.Fill(search_ds, "getTestData")
        '搜索所有相关数据

        Dim num As Integer = search_ds.Tables(0).Rows.Count
        Dim val_Num As Integer = getQtyByID(Obj_ID, TI_index)
        Dim val_Ave As Double = "0.0"
        '定义相关变量

        Dim result_dt As DataTable = New DataTable
        result_dt.TableName = ""
        result_dt.Columns.Add("日期")
        result_dt.Columns.Add("数据")
        '定义DT列

        For i = 0 To num - 1
            Dim row_Str(val_Num) As String
            For j = 0 To val_Num - 1
                row_Str(j) = search_ds.Tables(0).Rows(i)("Value" & (TI_index + 1) & "_" & (j + 1)).ToString
                val_Ave = ave(row_Str, 2)
            Next
            result_dt.Rows.Add(search_ds.Tables(0).Rows(i)(1), val_Ave)
        Next
        '将日期与平均数据填入DT中

        Return result_dt

    End Function
    '根据材料ID及1项测试内容返回相关信息，返回有DataTable

    Private Function getTestData(ByVal Obj_ID As String,
                                 ByVal TI_index1 As Integer, ByVal TI_index2 As Integer,
                                 ByVal startDate As Date, ByVal EndendDate As Date) As DataSet

        Dim result As DataSet = New DataSet

        Dim sql As String = ""

        Return result
    End Function

    Public Sub DisplayTI()
        fillCheckedListBoxByTI(ID_Object)
    End Sub
    '填充CLB

    Private Sub ObjectList_Button_Click(sender As Object, e As EventArgs) Handles ObjectList_Button.Click
        ObjectList.Show()
        ObjectList.ObjectList_Load(Me, e)
    End Sub
    '点击一览打开材料列表

    Private Sub FillChart(ByVal DT As DataTable)

        Data_Chart.ChartAreas.Clear()

        Data_Chart.ChartAreas.Add("测试数据")
        Data_Chart.ChartAreas("测试数据").BackColor = Color.FromName("GradientInactiveCaption") '设置绘图区颜色
        Data_Chart.ChartAreas("测试数据").AxisX.IsMarginVisible = True
        'Data_Chart.ChartAreas("测试数据").Area3DStyle.Enable3D = True‘启用3D显示
        Data_Chart.ChartAreas("测试数据").AxisX.Title = "时间" 'X轴名称
        Data_Chart.ChartAreas("测试数据").AxisY.Title = "数量" 'Y轴名称

        Data_Chart.Titles.Clear()
        Data_Chart.Titles.Add("测试数据推移图")

        Data_Chart.Series.Clear() '清除所有数据集
        Dim newSeries1 As New Series("标准值") '新增数据集
        newSeries1.ChartType = SeriesChartType.Line '直线
        newSeries1.BorderWidth = 2
        newSeries1.Color = Color.DimGray
        newSeries1.XValueType = ChartValueType.Date
        newSeries1.IsValueShownAsLabel = True
        Data_Chart.Series.Add(newSeries1)

        'Dim xValue As Double
        Dim yValue As Double
        Dim num As Integer = DT.Rows.Count

        For i = 1 To num
            'xValue = DT.Rows(i - 1)("日期")
            yValue = DT.Rows(i - 1)("数据")
            Data_Chart.Series("标准值").Points.AddXY(i, yValue)

        Next

    End Sub
    '输入DataTable，绘制图表

    Private Sub Wave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBcon()

        DateStart_DateTimePicker.Format = DateTimePickerFormat.Custom
        DateStart_DateTimePicker.CustomFormat = "yyyy/MM/dd"
        DateEnd_DateTimePicker.Format = DateTimePickerFormat.Custom
        DateEnd_DateTimePicker.CustomFormat = "yyyy/MM/dd"
        DateEnd_DateTimePicker.Value = Today
        DateStart_DateTimePicker.Value = DateEnd_DateTimePicker.Value.AddMonths(-1)
        '重置DTP为上月和本月


    End Sub
    '加载

    Private Sub Wave_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainMenu.Show()
    End Sub
    '关闭时显示主菜单

    Private Sub cancelSelect_Click(sender As Object, e As EventArgs) Handles cancelSelect_Button.Click

        Dim indexes As CheckedListBox.CheckedIndexCollection = TI_CheckedListBox.CheckedIndices
        '获得所有选中项的索引

        Dim index As Integer
        Dim price As Double = 0.0
        For Each index In indexes
            TI_CheckedListBox.SetItemChecked(index, False)
        Next
        '遍历索引，取消勾选

    End Sub
    '点击取消选择按钮取消所有CLB中的选择

    Private Sub TI_CheckedListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TI_CheckedListBox.SelectedIndexChanged

        Dim num = TI_CheckedListBox.CheckedIndices.Count

        If num > 2 Then
            MessageBox.Show("无法选两项以上")
            TI_CheckedListBox.SetItemChecked(TI_CheckedListBox.SelectedIndex, False)
        End If
        '如果选择两项以上则报警
    End Sub
    '检测CLB动态

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click

        Dim TestData As DataTable = getTestData(Me.ID_Object, TI_CheckedListBox.CheckedIndices(0),
                                                DateStart_DateTimePicker.Value, DateEnd_DateTimePicker.Value)
        FillChart(TestData)

    End Sub
    '点击OK按钮开始画图

End Class