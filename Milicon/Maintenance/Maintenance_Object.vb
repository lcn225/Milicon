Public Class Maintenance_Object

    Public ID_Object As Integer = 0

    Private Sub TextFormat()
        Me.Text = ini.GetIniString("Maintenance_Object", "Title", "N/A")
        Me.Signin_Button.Text = ini.GetIniString("Maintenance_Object", "Button1", "N/A")
        Me.Add_Button.Text = ini.GetIniString("Maintenance_Object", "Button1.5", "N/A")
        Me.Cancel_Button.Text = ini.GetIniString("Maintenance_Object", "Button2", "N/A")
        Me.Exit_Button.Text = ini.GetIniString("Maintenance_Object", "Button3", "N/A")
    End Sub
    'UI文本初始化


    Private Sub Maintenance_Object_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DBcon()

        ResetDGV(Me)

        TextFormat()

        cn.Close()

        Me.Signin_Button.Enabled = False

    End Sub

    Private Sub ObjectList_Button_Click(sender As Object, e As EventArgs) Handles ObjectList_Button.Click
        ObjectList.Show()
        ObjectList.ObjectList_Load(Me, e)
    End Sub
    '点击浏览打开原材料列表进行选择


    Public Sub DisplayTI()

        Dim sql As String = "Select * from Object_List where Obj_ID = " + Me.ID_Object.ToString
        da = New OleDb.OleDbDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "result")

        'TestItem_DataGridView.DataSource = ds.Tables(0)

        TestItem_DataGridView.Columns.Add("TI_Name", "测试项目")
        TestItem_DataGridView.Columns.Add("TI_Type", "测试种类")
        TestItem_DataGridView.Columns.Add("TI_Stand", "标准值")
        TestItem_DataGridView.Columns.Add("TI_Range", "偏差范围")
        TestItem_DataGridView.Columns.Add("TI_Qty", "样本数量")
        TestItem_DataGridView.Columns.Add("TI_Ref", "重要性")

        Dim RowsCount As Integer = ds.Tables(0).Rows(0)("TI_Num").ToString
        Dim TI_Name As String = ""
        Dim TI_Type As String = ""
        Dim TI_Stand As String = ""
        Dim TI_Range As String = ""
        Dim TI_Qty As String = ""
        Dim TI_Ref As String = ""


        For i = 1 To RowsCount
            TI_Name = "TI" & i & "_Name"
            TI_Type = "TI" & i & "_Type"
            TI_Stand = "TI" & i & "_Stand"
            TI_Range = "TI" & i & "_Range"
            TI_Qty = "TI" & i & "_Qty"
            TI_Ref = "TI" & i & "_Ref"

            TestItem_DataGridView.Rows.Add()
            TestItem_DataGridView.Rows(i - 1).Cells("TI_Name").Value = ds.Tables(0).Rows(0)(TI_Name).ToString
            TestItem_DataGridView.Rows(i - 1).Cells("TI_Type").Value = ds.Tables(0).Rows(0)(TI_Type).ToString
            TestItem_DataGridView.Rows(i - 1).Cells("TI_Stand").Value = ds.Tables(0).Rows(0)(TI_Stand).ToString
            TestItem_DataGridView.Rows(i - 1).Cells("TI_Range").Value = ds.Tables(0).Rows(0)(TI_Range).ToString
            TestItem_DataGridView.Rows(i - 1).Cells("TI_Qty").Value = ds.Tables(0).Rows(0)(TI_Qty).ToString
            TestItem_DataGridView.Rows(i - 1).Cells("TI_Ref").Value = ds.Tables(0).Rows(0)(TI_Ref).ToString

        Next

        Me.Signin_Button.Enabled = True
        '确定材料名后启用登录按钮
        Me.Add_Button.Enabled = True
        '确定材料名后启用增加按钮

    End Sub
    '在DGV中显示各种TI

    Private Sub Maintenance_Object_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MaintenanceMainMenu.Show()
    End Sub
    '关闭窗口时显示维护主菜单

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    '点击关闭按钮关闭窗口

    Private Sub Help_Button_Click(sender As Object, e As EventArgs) Handles Help_Button.Click

        Dim str As String = ""
        str = "测试项目：填入测试项目的名称"
        str = str & vbLf & "测试种类：1为单边范围，2为双边范围"
        str = str & vbLf & "标准值：数据标准值"
        str = str & vbLf & "偏差范围：±值。如果测试种类为2，则此处1表示≥规格值，为0时表示≤规格值"
        str = str & vbLf & "样本数量：一般为1或3"
        str = str & vbLf & "重要性：Yes为必须符合，No为仅作参考"

        MessageBox.Show(str, "维护说明")

    End Sub
    '点击说明按钮显示说明

    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        DBcon()

        Dim obj_Name As String = ""
        obj_Name = InputBox("请输入新增规格名称" & vbLf & "新增规格的测试项目将会和现规格相同", "输入名称", "", 10, 10)

        If obj_Name <> "" Then
            addObject(Me.ID_Object, obj_Name)
            MessageBox.Show("添加成功！")
            NameInput_TextBox.Text = obj_Name
        End If

    End Sub

End Class