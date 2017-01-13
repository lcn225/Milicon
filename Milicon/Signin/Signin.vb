Imports System.Data.OleDb
Public Class Signin

    Public cn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet

    Public ID_Object As Integer = 0

    Private Sub TextFormat()

        Me.Text = ini.GetIniString("Signin", "Title", "N/A")
        Me.ObjectList_Button.Text = ini.GetIniString("Signin", "Button1", "N/A")
        Me.ObjectInput_Button.Text = ini.GetIniString("Signin", "Button2", "N/A")
        Me.Signin_Button.Text = ini.GetIniString("Signin", "Button3", "N/A")
        Me.Cancel_Button.Text = ini.GetIniString("Signin", "Button4", "N/A")
        Me.Exit_Button.Text = ini.GetIniString("Signin", "Button5", "N/A")
        Me.ProDate_Label.Text = ini.GetIniString("Signin", "Label1", "N/A")
        Me.Lots_Label.Text = ini.GetIniString("Signin", "Label2", "N/A")
        Me.TestDate_Label.Text = ini.GetIniString("Signin", "Label3", "N/A")
        Me.Tester_Label.Text = ini.GetIniString("Signin", "Label4", "N/A")
    End Sub
    'UI文本初始化

    Private Sub SignReset()
        Me.NameInput_TextBox.Text = ""
        Me.ProDate_TextBox.Text = ""
        Me.TestDate_TextBox.Text = ""
        Me.Tester_TextBox.Text = ""
    End Sub
    '重置输入（配合确定/取消按钮）

    Public Sub DBcon()
        Dim cnStr As String = "Provider=" + ini.GetIniString("DBconnect", "Provider", "Microsoft.Jet.OLEDB.4.0") + ";Data Source=" + ini.GetIniString("DBconnect", "Source", "\\192.168.2.100\DataBase\Milicon.mdb") + ";Persist Security Info=" + ini.GetIniString("DBconnect", "Persist Security Info", "False")
        '根据INI内容定义链接字符串
        cn = New OleDbConnection(cnStr)
        '建立链接
    End Sub
    '链接数据库


    Private Sub DisaplyObjectFormat(Object_Name As String)
        DBcon()

        Dim sql As String = "select Obj_name as 材料名称,Obj_Sup as 供应商 from Object_List where Obj_name='" + Object_Name + "'"

        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet

        da.Fill(ds, "result")
        TestDateInput_DataGridView.DataSource = ds.Tables(0)

    End Sub
    '输入测试材料规格，显示登录界面

    Private Function GetObjectTestInfo(Object_Name As String) As String

        Return 0
    End Function

    Private Function GetObjectFormat(Type As String, TestObject As Integer) As String

        DBcon()

        Dim sql As String = "select Sup from Object_List where Obj_name='" + TestObject + "'"

        da = New OleDbDataAdapter(sql, cn)

        ds = New DataSet

        da.Fill(ds, "result")

        Return 0
    End Function
    '此函数暂时搁置

    Private Function GetTestLots() As String
        'Dim TestLots As String = System.DateTime.Today.Year & System.DateTime.Today.Month & System.DateTime.Today.Day
        Dim TodayLots As String
        Dim today As String = Format(Date.Today, "yyyy/MM/dd")
        Dim Lots As String = 0

        DBcon()
        '获取当日日期
        'Dim today As String = Format(DateAdd(DateInterval.Day, -1, Date.Today), "yyyy/MM/dd")
        '调整日期，测试用
        Dim sql As String = "SELECT COUNT(TestDate) AS LoginNoDate FROM Data_list WHERE (((Data_list.[TestDate])=#" & today & "#))"
        Dim TestLots_da = New OleDbDataAdapter(sql, cn)
        Dim TestLots_DS = New DataSet
        TestLots_da.Fill(TestLots_DS, "TestLots")
        '查询并统计Data_List表中，本日已登录多少数据

        Lots = Format(Val(TestLots_DS.Tables(0).Rows(0)(0).ToString) + 1, "00")
        '批号Lots为本日已登录数据量+1

        TodayLots = Format(Date.Today, "yyMMdd") & Lots
        Return TodayLots
        '生成并返回yymmdd00形式的测试编号，其中00为批号

        cn.Close()

    End Function
    '获取该次登录的批号

    Private Sub Signin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextFormat()
        '初始化界面文本
        Me.TestLots_Label.Text = "测试编号： " & GetTestLots() '获得测试编号

    End Sub
    '加载登录功能窗口时初始化UI，获得并显示测试编号

    Private Sub Signin_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        SignReset()
        MainMenu.Show()
    End Sub
    '关闭登录功能窗口时重置并打开主菜单

    Private Sub ObjectList_Button_Click(sender As Object, e As EventArgs) Handles ObjectList_Button.Click
        ObjectList.Show()
    End Sub
    '点击浏览打开原材料列表进行选择

    Private Sub ObjectInput_Button_Click(sender As Object, e As EventArgs) Handles ObjectInput_Button.Click

        Dim Object_Name = NameInput_TextBox.Text

        If Object_Name = "" Then
            MessageBox.Show("请输入材料名称")
        Else
            DisaplyObjectFormat(Object_Name)
        End If

    End Sub
    '根据输入的材料名称显示不同的输入项目

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
        MainMenu.Show()
    End Sub
    '点击退出按钮关闭登录窗口

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        SignReset()
        TestDateInput_DataGridView.Rows.Clear()
    End Sub
    '点击重置按钮重置所有textbox

    Private Sub Signin_Button_Click(sender As Object, e As EventArgs) Handles Signin_Button.Click
        Dim SigninCheck As String = ""
        SigninCheck = MessageBox.Show(“是否输入完毕？”, “登录确认”, MessageBoxButtons.YesNo)
        If SigninCheck = 6 Then
            SignReset()
            TestDateInput_DataGridView.Rows.Clear()
        End If

    End Sub
    '点击登录按钮登录数据

End Class