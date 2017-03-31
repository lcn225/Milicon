Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Wave

    Public ID_Object As String = 0

    Private Sub fillCheckedListBoxByTI(ByVal ID_Obj As String)

        ResetCLB(Me)

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
                                 ByRef CLB As CheckedListBox,
                                 ByVal startDate As Date, ByVal endDate As Date) As DataTable

        Dim search_ds As DataSet = New DataSet
        Dim checkedNum As Integer = CLB.CheckedIndices.Count

        Dim str As String = "LoginNo"

        For index = 0 To checkedNum - 1
            For i = 1 To 9
                str = str & ", Value" & (CLB.CheckedIndices(index) + 1) & "_" & i
            Next
        Next
        '获取数据所在字段名，格式为str

        Dim sql As String = "Select " & str & " from Data_List Where Obj_ID = " & Obj_ID & " and TestDate >= #" & startDate & "# and TestDate <= #" & endDate & "#"
        da = New OleDbDataAdapter(sql, cn)
        da.Fill(search_ds, "getTestData")
        '搜索所有相关数据

        Dim num As Integer = search_ds.Tables(0).Rows.Count
        '统计数据表中行数量（即搜索结果数量）

        Dim val_Num(checkedNum - 1) As Integer
        For i = 0 To checkedNum - 1
            val_Num(i) = getQtyByID(Obj_ID, CLB.CheckedIndices(i) + 1)
        Next
        '定义数组val_Num，填充每一个勾选TI的qty进入数组

        Dim val_Ave(checkedNum - 1) As Double
        '定义数组val_Ave

        Dim result_dt As DataTable = New DataTable
        result_dt.TableName = ""
        result_dt.Columns.Add("测试编号")
        '增加日期列
        For i = 1 To checkedNum
            result_dt.Columns.Add("数据" & i)
        Next
        '定义DT，增加对应数量的数据列

        For i = 0 To num - 1
            '每循环一次添加一行数据
            Dim dr As DataRow = result_dt.NewRow
            dr("测试编号") = search_ds.Tables(0).Rows(i)(0)
            '定义dataRow

            For j = 0 To checkedNum - 1
                '每循环一次获得一个系列的平均数

                Dim row_Str(val_Num(j) - 1) As String
                '定义数组，数组长度为对应TI的qty

                Dim temp As String
                For k = 0 To val_Num(j) - 1
                    temp = search_ds.Tables(0).Rows(i)("Value" & (CLB.CheckedIndices(j) + 1) & "_" & (k + 1)).ToString
                    If IsNumeric(temp) Then
                        '判断是否为数字，不是则赋0
                        row_Str(k) = temp
                    Else
                        row_Str(k) = 0
                    End If
                Next
                '将若干个实验数据填入row_Str数组

                val_Ave(j) = ave(row_Str, 2)
                dr("数据" & (j + 1)) = Format(val_Ave(j), "0.00")
                '取平均数并填入dr对应字段

            Next
            result_dt.Rows.Add(dr)
        Next
        '将日期与平均数据填入DT中

        delMulRowFromDataTable(result_dt, "测试编号")
        '

        Return result_dt

    End Function
    '根据材料ID及测试内容返回相关信息，返回有DataTable

    Public Sub DisplayTI()
        fillCheckedListBoxByTI(ID_Object)
    End Sub
    '填充CLB

    Private Sub ObjectList_Button_Click(sender As Object, e As EventArgs) Handles ObjectList_Button.Click
        ObjectList.Show()
        ObjectList.ObjectList_Load(Me, e)
    End Sub
    '点击一览打开材料列表

    Private Sub setCHartAreas(ByRef Ch As Chart)

        Ch.ChartAreas.Clear()
        Ch.ChartAreas.Add("测试数据")
        Ch.ChartAreas("测试数据").BackColor = Color.White '设置绘图区颜色
        Ch.ChartAreas("测试数据").AxisX.IsMarginVisible = True
        'ch.ChartAreas("测试数据").Area3DStyle.Enable3D = True‘启用3D显示
        Ch.ChartAreas("测试数据").AxisX.Title = "日期" 'X轴名称
        Ch.ChartAreas("测试数据").AxisX.MajorGrid.Enabled = False '取消X轴网格线
        Ch.ChartAreas("测试数据").AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount
        Ch.ChartAreas("测试数据").AxisX.LabelStyle.Angle = -90
        Ch.ChartAreas("测试数据").AxisY.Title = Me.TI_CheckedListBox.CheckedItems(0).ToString 'Y轴名称
        Ch.ChartAreas("测试数据").AxisY.MajorGrid.LineColor = Color.FromArgb(217, 217, 217) '淡灰
        '设置绘图区相关

    End Sub
    '设置绘图区相关

    Private Sub setSeries(ByRef Ch As Chart, ByVal n As Integer)

        Dim colorset(3) As Integer
        colorset(0) = &HFF4F81BD '蓝色
        colorset(1) = &HFFC0504D '红色
        colorset(2) = &HFF9BBB59 '绿色


        Dim newSeries As New Series(Me.TI_CheckedListBox.CheckedItems(n).ToString) '新增数据集
        newSeries.ChartType = SeriesChartType.Line '直线
        newSeries.BorderWidth = 3
        newSeries.Color = Color.FromArgb(colorset(n))
        '定义线条颜色
        newSeries.XValueType = ChartValueType.String
        newSeries.IsValueShownAsLabel = True
        Ch.Series.Add(newSeries)
        '设置系列集相关

    End Sub
    '设置系列集相关

    Private Sub FillChart(ByVal DT As DataTable)

        Dim checkedNum As Integer = DT.Columns.Count - 1
        '获取数据列数（即全部列数减去X轴列数）

        Data_Chart.Visible = True

        setCHartAreas(Data_Chart)
        '设置绘图区相关
        Data_Chart.Titles.Clear()
        Data_Chart.Titles.Add("测试数据推移图")
        '设置标题

        Data_Chart.Series.Clear() '清除所有数据集

        Data_Chart.DataSource = DT
        Data_Chart.DataBind()

        For i = 0 To checkedNum - 1
            '每次循环设置一个系列集
            setSeries(Data_Chart, i)
            '设置系列集i

            If i > 0 Then
                Data_Chart.Series(0).YAxisType = AxisType.Primary
                Data_Chart.Series(i).YAxisType = AxisType.Secondary
            End If
            '如果系列集个数大于1，则设置主副纵坐标

            Data_Chart.Series(i).XValueMember = "测试编号"
            Data_Chart.Series(i).YValueMembers = "数据" & (i + 1)
            '绑定数据
        Next
        '系列集设置完毕

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

        Data_Chart.Visible = False

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

        Dim TestData As DataTable = getTestData(Me.ID_Object,
                                                TI_CheckedListBox,
                                                DateStart_DateTimePicker.Value, DateEnd_DateTimePicker.Value)
        '获取测试数据
        FillChart(TestData)
        '将测试数据画图

    End Sub


End Class