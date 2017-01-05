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

    Private Sub SignReset()
        Me.NameInput_TextBox.Text = ""
        Me.ProDate_TextBox.Text = ""
        Me.TestDate_TextBox.Text = ""
        Me.Tester_TextBox.Text = ""
    End Sub

    Private Sub DBcon()
        Dim cnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\192.168.2.100\DataBase\Milicon.mdb;Persist Security Info=False"
        '定义链接字符串
        cn = New OleDbConnection(cnStr)
        '建立链接
        Dim sql As String = "select Sup from Object_List where Obj_name='J22'"

        da = New OleDbDataAdapter(sql, cn)

        ds = New DataSet

        da.Fill(ds, "result")

        TestDateInput_DataGridView.DataSource = ds.Tables(0)

        Temp_Label.Text = ds.Tables(0).Rows(0)(0).ToString
    End Sub

    Private Function GetObjectFormat(Type As String, TestObject As Integer) As String


        DBcon()
    End Function

    Private Function GetTestLots() As String
        Dim TestLots As String = System.DateTime.Today.Year & System.DateTime.Today.Month & System.DateTime.Today.Day
        'Dim TodayLots As String = 0
        Return TestLots
        '生成yyyymmdd形式的测试编号
    End Function

    Private Sub Signin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextFormat()
        '初始化界面文本
        Me.TestLots_Label.Text = "测试编号： " & GetTestLots() '获得测试编号

    End Sub


    Private Sub Signin_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        MainMenu.Show()
    End Sub

    Private Sub ObjectList_Button_Click(sender As Object, e As EventArgs) Handles ObjectList_Button.Click
        ObjectList.Show()
    End Sub

    Private Sub ObjectInput_Button_Click(sender As Object, e As EventArgs) Handles ObjectInput_Button.Click
        TestDateInput_DataGridView.Rows.Clear()
        TestDateInput_DataGridView.Rows.Add(2)
        TestDateInput_DataGridView.Rows(0).Cells(0).Value = GetObjectFormat("HX11", 1)
    End Sub

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

        DBcon()

    End Sub
End Class