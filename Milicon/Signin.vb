Imports System.Data.OleDb
Public Class Signin

    Dim cn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet

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

    Private Sub DBcon()
        Dim cnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\192.168.2.100\DataBase\Milicon.mdb;Persist Security Info=False"
        '定义链接字符串
        cn = New OleDbConnection(cnStr)
        '建立链接
    End Sub
    '链接数据库

    Private Sub DisaplyObjectFormat(Object_Name As String)
        DBcon()

        Dim sql As String = "select Obj_name as 材料名称,Sup as 供应商 from Object_List where Obj_name='" + Object_Name + "'"

        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet

        da.Fill(ds, "result")
        TestDateInput_DataGridView.DataSource = ds.Tables(0)

    End Sub

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
        Dim TestLots As String = System.DateTime.Today.Year & System.DateTime.Today.Month & System.DateTime.Today.Day
        Dim TodayLots As String

        Return TestLots
        '生成yyyymmdd形式的测试编号
    End Function

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

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        SignReset()
        TestDateInput_DataGridView.Rows.Clear()
    End Sub

    Private Sub Signin_Button_Click(sender As Object, e As EventArgs) Handles Signin_Button.Click
        Dim SigninCheck As String = ""
        SigninCheck = MessageBox.Show(“是否输入完毕？”, “登录确认”, MessageBoxButtons.YesNo)
        If SigninCheck = 6 Then
            SignReset()
            TestDateInput_DataGridView.Rows.Clear()
        End If

    End Sub
End Class