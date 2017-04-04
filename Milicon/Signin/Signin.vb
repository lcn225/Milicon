Imports System.Data.OleDb
Public Class Signin

    Public ID_Object As Integer = 0
    Private TI_ds As DataSet = New DataSet
    Dim TestLots As String

    Private Sub TextFormat()

        Me.Text = ini.GetIniString("Signin", "Title", "N/A")
        Me.ObjectList_Button.Text = ini.GetIniString("Signin", "Button1", "N/A")
        Me.Signin_Button.Text = "F1" & vbLf & ini.GetIniString("Signin", "Button3", "N/A")
        Me.Cancel_Button.Text = "F10" & vbLf & ini.GetIniString("Signin", "Button4", "N/A")
        Me.Exit_Button.Text = "F12" & vbLf & ini.GetIniString("Signin", "Button5", "N/A")
        Me.ProDate_Label.Text = ini.GetIniString("Signin", "Label1", "N/A")
        Me.Lots_Label.Text = ini.GetIniString("Signin", "Label2", "N/A")
        Me.TestDate_Label.Text = ini.GetIniString("Signin", "Label3", "N/A")
        Me.Tester_Label.Text = ini.GetIniString("Signin", "Label4", "N/A")
    End Sub
    'UI文本初始化

    Private Sub SignReset()

        ResetFormText(Me)
        '清除所有text

        ResetDGV(Me)
        '清除DGV

    End Sub
    '重置输入（配合确定/取消按钮）

    Private Sub ADD_TestDateInput_DataGridView(ByVal i As Integer)
        DBcon()

        Dim TI_Name As String
        Dim sql_ds_TIName As String

        sql_ds_TIName = "TI" + i.ToString + "_Name"
        TI_Name = TI_ds.Tables(0).Rows(0)(sql_ds_TIName).ToString
        '获取字段名为"TIi_Name"的值，i为参数

        Dim TI_Type As String = TI_ds.Tables(0).Rows(0)("TI" + i.ToString + "_Type")
        Dim TI_Stand As String = TI_ds.Tables(0).Rows(0)("TI" + i.ToString + "_Stand")
        Dim TI_Range As String = TI_ds.Tables(0).Rows(0)("TI" + i.ToString + "_Range")
        '获取规格值相关

        Dim TI_Acc As Integer = TI_ds.Tables(0).Rows(0)("TI" + i.ToString + "_Acc")
        '获取精度

        Dim Acc As String = "F" & TI_Acc
        '定义精度字符串

        TestDataInput_DataGridView.Rows.Add()
        TestDataInput_DataGridView.Rows(i - 1).DefaultCellStyle.Format = Acc
        '设定该行单元格精度
        TestDataInput_DataGridView.Rows(i - 1).HeaderCell.Value = TI_Name
        '增添一行，标题为测试项目
        TestDataInput_DataGridView.Rows(i - 1).Cells("Stand").Value = standAndRange(TI_Type, TI_Stand, TI_Range)
        '第一列为规格值

        cn.Close()

    End Sub
    'DGV添加行，每一行标题为各测试项目

    Private Sub DisaplyObjectFormat(ByVal ID_Obj As String)
        DBcon()

        Dim i As Integer
        Dim TI_Num As String = TI_ds.Tables(0).Rows(0)("TI_Num").ToString
        '获得测试项目数量

        Dim MAXQty As Integer = getMAXQtyByID(ID_Obj)
        '获取该测试批号对应规格各TI最大样本数

        'TestDateInput_DataGridView.DataSource = ds.Tables(0)


        TestDataInput_DataGridView.RowHeadersWidth = 120
        TestDataInput_DataGridView.Columns.Add("Stand", "规格值")
        TestDataInput_DataGridView.Columns("Stand").Width = 80
        TestDataInput_DataGridView.Columns("Stand").ReadOnly = True
        '新增规格值列

        Dim width As Single = 300 / MAXQty
        '设定列宽度
        For i = 1 To MAXQty
            TestDataInput_DataGridView.Columns.Add(i, Chr(i - 23848))
            TestDataInput_DataGridView.Columns(i).Width = width
        Next
        '根据样本数添加若干列

        If TI_Num = "" Then
            MessageBox.Show("测试项目出错，请确认")
            ResetDGV(Me)
            Exit Sub
        End If

        For i = 1 To TI_Num
            ADD_TestDateInput_DataGridView(i)
            TestDataInput_DataGridView.Rows(i - 1).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
        '添加若干行，每一行标题为各测试项目

        TestDataInput_DataGridView.AutoResizeRows()

        'TestDataInput_DataGridView.Rows(1).DefaultCellStyle.WrapMode = DataGridViewTriState.True

        'TestDataInput_DataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
        'TestDataInput_DataGridView.AutoResizeRows()

        'mergeCell(ID_Obj, Me.TestDataInput_DataGridView)
        '根据样本数量合并单元格

    End Sub
    '输入测试材料规格，显示登录界面

    Private cmb As CmbDatagridbiew

    Private Function GetTI(ByVal ID_Obj As String) As DataSet

        DBcon()
        Dim sql As String = "select * from Object_List where Obj_ID=" + ID_Obj
        '根据ID在材料测试项目表中查询记录
        da = New OleDbDataAdapter(sql, cn)
        TI_ds = New DataSet
        da.Fill(Me.TI_ds, "GetTIInfo")

        Return Me.TI_ds

        cn.Close()
    End Function
    '根据ID返回测试信息ds

    Private Function SigninTestData() As String
        DBcon()

        Dim sql As String

        Dim LoginNo As String = Me.TestLots
        Dim Obj_ID As String = ID_Object
        Dim ProDate As String = Me.ProDate_DateTimePicker.Text
        Dim Lots As String = Me.Lots_TextBox.Text
        Dim TestDate As String = Me.TestDate_DateTimePicker.Text
        Dim Tester As String = Me.Tester_TextBox.Text
        '获取测试信息

        Dim Value(3) As String
        Dim Str_Col As String = "LoginNo, Obj_ID, ProDate, Lots, TestDate, Tester"
        Dim Str_Val As String = "'" + LoginNo + "','" + Obj_ID + "','" + ProDate + "','" + Lots + "','" + TestDate + "','" + Tester + "'"
        '先写入测试信息相关信息
        Dim RowsCount As Integer = TestDataInput_DataGridView.RowCount
        '获取DGV总行数

        cn.Open()

        For i = 0 To RowsCount - 1
            For j = 0 To 2
                Str_Col = Str_Col + ",Value" + （i + 1）.ToString + "_" + （j + 1）.ToString
                If TestDataInput_DataGridView.Rows(i).Cells(j).Value = "" Then
                    Str_Val = Str_Val + ",'0'"
                Else
                    Str_Val = Str_Val + ",'" + TestDataInput_DataGridView.Rows(i).Cells(j + 1).Value + "'"
                End If
            Next
        Next
        sql = "INSERT INTO Data_List (" + Str_Col + ") VALUES (" + Str_Val + ")"

        Return sql

    End Function
    '登录测试实验数据，返回SQL语句

    Private Function GetTestLots() As String
        'Dim TestLots As String = System.DateTime.Today.Year & System.DateTime.Today.Month & System.DateTime.Today.Day
        Dim TodayLots As String
        Dim today As String = Format(Date.Today, "yyMMdd")
        Dim Lots As String = 0

        DBcon()

        '获取当日日期
        'Dim today As String = Format(DateAdd(DateInterval.Day, -1, Date.Today), "yyyy/MM/dd")
        '调整日期，测试用
        'Dim sql As String = "SELECT COUNT(LoginNo) AS LoginNoDate FROM Data_list WHERE (LoginNo LIKE '170401*')"
        Dim sql As String = "SELECT COUNT(LoginNo) AS LoginNoDate FROM Data_list WHERE LoginNo LIKE '" & today & "%'"
        'access中通配符用*，但是vb.net中用%？坑爹啊
        Dim TestLots_da = New OleDbDataAdapter(sql, cn)
        Dim TestLots_DS = New DataSet
        TestLots_da.Fill(TestLots_DS, "TestLots")
        '查询并统计Data_List表中，本日已登录多少数据

        Lots = Format(Val(TestLots_DS.Tables(0).Rows(0)(0).ToString + 1), "00")
        '批号Lots为本日已登录数据量+1

        TodayLots = Format(Date.Today, "yyMMdd") & Lots
        Return TodayLots
        '生成并返回yymmdd00形式的测试编号，其中00为批号

        cn.Close()

    End Function
    '获取该次登录的批号

    Private Sub RefTestLots()
        Me.TestLots = GetTestLots()
        Me.TestLots_Label.Text = "测试编号： " & Me.TestLots '获得测试编号
    End Sub
    '刷新测试批号

    Private Sub Signin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextFormat()
        '初始化界面文本

        Signin_Button.Enabled = False
        '确认材料名之前禁用登录按钮

        RefTestLots()
        '刷新测试批号

    End Sub
    '加载登录功能窗口时初始化UI，获得并显示测试编号

    Private Sub Signin_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        SignReset()
        MainMenu.Show()
    End Sub
    '关闭登录功能窗口时重置并打开主菜单

    Private Sub ObjectList_Button_Click(sender As Object, e As EventArgs) Handles ObjectList_Button.Click
        ObjectList.Show()
        ObjectList.ObjectList_Load(Me, e)
    End Sub
    '点击浏览打开原材料列表进行选择

    Public Sub DisplayTI()

        Me.TI_ds = GetTI(ID_Object)
        '将TI相关信息填入TI_DS

        Dim Object_Name = NameInput_TextBox.Text
        If Object_Name = "" Then
            MessageBox.Show("请输入材料名称")
            '如果未填材料名，报错提示
        Else
            ResetDGV(Me)
            '重置DGV
            DisaplyObjectFormat(ID_Object)
            '否则显示实验相关项目
        End If

        disenableSort(Me.TestDataInput_DataGridView)

        Me.Signin_Button.Enabled = True
        '确定材料名后启用登录按钮

    End Sub
    '在DGV中显示各种TI

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
        MainMenu.Show()
    End Sub
    '点击退出按钮关闭登录窗口

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        SignReset()
    End Sub
    '点击重置按钮重置所有textbox

    Private Sub Signin()

        Dim sql As String
        Dim cmd As OleDbCommand

        sql = SigninTestData()

        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteNonQuery()

        MessageBox.Show("登录成功")

        '之后加一个成功一个失败时的防错

    End Sub
    '之后加一个成功一个失败时的防错

    Private Sub Signin_Button_Click(sender As Object, e As EventArgs) Handles Signin_Button.Click
        Dim SigninCheck As String = ""

        '之后可以加一个检测未输入项目的方法，在messagebox中显示未输入项目

        SigninCheck = MessageBox.Show(“是否输入完毕？”, “登录确认”, MessageBoxButtons.YesNo)
        If SigninCheck = 6 Then
            '如果返回值为6，则为选择“是”
            Signin()
        End If

        'TestDataInput_DataGridView.DataSource = vbNull
        ResetDGV(Me)

        Signin_Button.Enabled = False
        '确认材料名之前禁用登录按钮

        RefTestLots()
        '刷新测试批号

    End Sub
    '点击登录按钮登录数据

    '设置快捷键
    Private Sub Signin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.F1 And Signin_Button.Enabled = True Then
            Signin_Button_Click(Me, e)
        End If

        If e.KeyCode = Keys.F10 Then
            Cancel_Button_Click(Me, e)
        End If

        If e.KeyCode = Keys.F12 Then
            Exit_Button_Click(Me, e)
        End If
    End Sub

    '输入数值时检测是否合法
    Private Sub TestDataInput_DataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles TestDataInput_DataGridView.CellValueChanged

        Dim num = TestDataInput_DataGridView.RowCount
        Dim qty = getMAXQtyByID(ID_Object)
        Dim type As String
        Dim stand As String
        Dim range As String

        For i = 0 To num - 1
            type = TI_ds.Tables(0).Rows(0)("TI" & (i + 1) & "_Type")
            stand = TI_ds.Tables(0).Rows(0)("TI" & (i + 1) & "_Stand")
            range = TI_ds.Tables(0).Rows(0)("TI" & (i + 1) & "_Range")
            For j = 1 To qty
                '如果是单边范围类型

                If type = 1 Then
                    '如果是大于的情况
                    If range = 1 Then
                        '如果大于等于0，则正常
                        If TestDataInput_DataGridView.Rows(i).Cells(j).Value >= stand Then
                            TestDataInput_DataGridView.Rows(i).Cells(j).Style.BackColor = Color.White
                            '否贼背景变红
                        Else
                            TestDataInput_DataGridView.Rows(i).Cells(j).Style.BackColor = Color.Red
                        End If
                        '如果是小于的情况
                    ElseIf range = 0 Then
                        If TestDataInput_DataGridView.Rows(i).Cells(j).Value <= stand Then
                            TestDataInput_DataGridView.Rows(i).Cells(j).Style.BackColor = Color.White
                        Else
                            TestDataInput_DataGridView.Rows(i).Cells(j).Style.BackColor = Color.Red
                        End If
                    Else

                    End If

                ElseIf type = 2 Then
                    If (Val(TestDataInput_DataGridView.Rows(i).Cells(j).Value) <= Val(stand) + Val(range)) And (Val(TestDataInput_DataGridView.Rows(i).Cells(j).Value) >= Val(stand) - Val(range)) Then
                        TestDataInput_DataGridView.Rows(i).Cells(j).Style.BackColor = Color.White
                    Else
                        TestDataInput_DataGridView.Rows(i).Cells(j).Style.BackColor = Color.Red
                    End If

                End If
            Next
        Next

    End Sub
End Class