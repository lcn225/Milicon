Imports System.Data.OleDb

Public Class Maintenance_Object

    Public ID_Object As Integer = 0

    Private Sub TextFormat()
        Me.Text = ini.GetIniString("Maintenance_Object", "Title", "N/A")
        Me.Signin_Button.Text = ini.GetIniString("Maintenance_Object", "Button1", "N/A")
        Me.Add_Button.Text = ini.GetIniString("Maintenance_Object", "Button1.5", "N/A")
        Me.Cancel_Button.Text = ini.GetIniString("Maintenance_Object", "Button2", "N/A")
        Me.Exit_Button.Text = ini.GetIniString("Maintenance_Object", "Button3", "N/A")
        Me.Label1.Text = ini.GetIniString("Maintenance_Object", "Label", "N/A")
    End Sub
    'UI文本初始化

    Private Sub Maintenance_Object_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DBcon()

        ResetDGV(Me)

        TextFormat()

        cn.Close()

        disenableSort(Me.TestItem_DataGridView)

        Me.Signin_Button.Enabled = False

    End Sub

    Private Sub ObjectList_Button_Click(sender As Object, e As EventArgs) Handles ObjectList_Button.Click
        ObjectList.Show()
        ObjectList.ObjectList_Load(Me, e)
    End Sub
    '点击浏览打开原材料列表进行选择

    Private Sub addTrueFalseCBL()

        Dim TF_Column As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn
        TF_Column.HeaderText = "重要性"
        TF_Column.Name = "TF"
        TF_Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        Dim TF_Combobox_Datatable As DataTable = New DataTable
        TF_Combobox_Datatable.Columns.Add("id", Type.GetType("System.String"))
        TF_Combobox_Datatable.Columns.Add("TF", Type.GetType("System.String"))
        '建立数据表

        TF_Combobox_Datatable.Rows.Add("True", "True")
        TF_Combobox_Datatable.Rows.Add("False", "False")

        TF_Column.DataSource = TF_Combobox_Datatable
        TF_Column.ValueMember = "id"
        TF_Column.DisplayMember = "TF"
        TF_Column.DataPropertyName = "Type"

        Me.TestItem_DataGridView.Columns.Insert(Me.TestItem_DataGridView.ColumnCount, TF_Column)

    End Sub
    '增加一列CBL用来选择Ture或False

    Public Sub DisplayTI()

        ResetDGV(Me)

        Dim sql As String = "Select * from Object_List where Obj_ID = " + Me.ID_Object.ToString
        da = New OleDb.OleDbDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "result")

        Me.sup_TextBox.Text = ds.Tables(0).Rows(0)("Obj_Sup").ToString
        '显示厂商名

        TestItem_DataGridView.Columns.Add("TI_Name", "测试项目")
        TestItem_DataGridView.Columns.Add("TI_Type", "测试种类")
        TestItem_DataGridView.Columns.Add("TI_Stand", "标准值")
        TestItem_DataGridView.Columns.Add("TI_Range", "偏差范围")
        TestItem_DataGridView.Columns.Add("TI_Acc", "精度")
        TestItem_DataGridView.Columns.Add("TI_Unit", "单位")
        TestItem_DataGridView.Columns.Add("TI_Qty", "样本数量")
        TestItem_DataGridView.Columns.Add("TI_Ref", "重要性")
        addTrueFalseCBL()
        '增加各列

        Dim RowsCount As Integer
        If ds.Tables(0).Rows(0)("TI_Num").ToString <> "" Then
            RowsCount = ds.Tables(0).Rows(0)("TI_Num").ToString
        Else
            RowsCount = 0
        End If
        '获取TI数目

        Dim TI_Name As String = ""
        Dim TI_Type As String = ""
        Dim TI_Stand As String = ""
        Dim TI_Range As String = ""
        Dim TI_Acc As String = ""
        Dim TI_Unit As String = ""
        Dim TI_Qty As String = ""
        Dim TI_Ref As String = ""


        For i = 1 To RowsCount
            TI_Name = "TI" & i & "_Name"
            TI_Type = "TI" & i & "_Type"
            TI_Stand = "TI" & i & "_Stand"
            TI_Range = "TI" & i & "_Range"
            TI_Acc = "TI" & i & "_Acc"
            TI_Unit = "TI" & i & "_Unit"
            TI_Qty = "TI" & i & "_Qty"
            TI_Ref = "TI" & i & "_Ref"

            TestItem_DataGridView.Rows.Add()
            TestItem_DataGridView.Rows(i - 1).Cells("TI_Name").Value = ds.Tables(0).Rows(0)(TI_Name).ToString
            TestItem_DataGridView.Rows(i - 1).Cells("TI_Type").Value = ds.Tables(0).Rows(0)(TI_Type).ToString
            TestItem_DataGridView.Rows(i - 1).Cells("TI_Stand").Value = ds.Tables(0).Rows(0)(TI_Stand).ToString
            TestItem_DataGridView.Rows(i - 1).Cells("TI_Range").Value = ds.Tables(0).Rows(0)(TI_Range).ToString
            TestItem_DataGridView.Rows(i - 1).Cells("TI_Acc").Value = ds.Tables(0).Rows(0)(TI_Acc).ToString
            TestItem_DataGridView.Rows(i - 1).Cells("TI_Unit").Value = ds.Tables(0).Rows(0)(TI_Unit).ToString
            TestItem_DataGridView.Rows(i - 1).Cells("TI_Qty").Value = ds.Tables(0).Rows(0)(TI_Qty).ToString
            TestItem_DataGridView.Rows(i - 1).Cells("TI_Ref").Value = ds.Tables(0).Rows(0)(TI_Ref).ToString

            TestItem_DataGridView.Rows(i - 1).Cells("TF").Value = TestItem_DataGridView.Rows(i - 1).Cells("TI_Ref").Value
            '给CBL赋值
        Next

        TestItem_DataGridView.Columns.RemoveAt(7)
        '删除重复列以完成CBL的替换

        disenableSort(Me.TestItem_DataGridView)
        '禁用排序

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
        str = str & vbLf & "精度：精确到小数点后多少位"
        str = str & vbLf & "单位：计量单位"
        str = str & vbLf & "样本数量：一般为1或3"
        str = str & vbLf & "重要性：True为必须符合，False为仅作参考"

        MessageBox.Show(str, "维护说明")

    End Sub
    '点击说明按钮显示说明

    Private Sub changeObject(ByVal obj_ID As String)

        DBcon()

        Dim num As Integer = Me.TestItem_DataGridView.RowCount
        '获得行数（即TI个数）

        Dim colName As String = "Obj_Sup"
        Dim val As String = sup_TextBox.Text
        Dim str As String = colName & " = '" & val & "', "
        '更新供应商

        str = str & "TI_Num = '" & num - 1 & "'"
        '更新TI数，减1是为了消除新增时的空行

        For i = 0 To num - 2
            str = str & ", TI" & (i + 1) & "_Name= '" & Me.TestItem_DataGridView.Rows(i).Cells(0).Value.ToString & "'"
            str = str & ", TI" & (i + 1) & "_Type= '" & Me.TestItem_DataGridView.Rows(i).Cells(1).Value.ToString & "'"
            str = str & ", TI" & (i + 1) & "_Stand= '" & Me.TestItem_DataGridView.Rows(i).Cells(2).Value.ToString & "'"
            str = str & ", TI" & (i + 1) & "_Range= '" & Me.TestItem_DataGridView.Rows(i).Cells(3).Value.ToString & "'"
            str = str & ", TI" & (i + 1) & "_Acc= " & Me.TestItem_DataGridView.Rows(i).Cells(4).Value.ToString
            str = str & ", TI" & (i + 1) & "_Unit= '" & Me.TestItem_DataGridView.Rows(i).Cells(5).Value.ToString & "'"
            str = str & ", TI" & (i + 1) & "_Qty= '" & Me.TestItem_DataGridView.Rows(i).Cells(6).Value.ToString & "'"
            str = str & ", TI" & (i + 1) & "_Ref= '" & Me.TestItem_DataGridView.Rows(i).Cells(7).Value.ToString & "'"
        Next
        '将所有有效数据输入

        For i = num - 1 To 14
            str = str & ", TI" & (i + 1) & "_Name= Null"
            str = str & ", TI" & (i + 1) & "_Type= Null"
            str = str & ", TI" & (i + 1) & "_Stand= Null"
            str = str & ", TI" & (i + 1) & "_Range= Null"
            str = str & ", TI" & (i + 1) & "_Acc= Null"
            str = str & ", TI" & (i + 1) & "_Unit= Null"
            str = str & ", TI" & (i + 1) & "_Qty= Null"
            str = str & ", TI" & (i + 1) & "_Ref= Null"
        Next

        str = str.Replace("'True'", "True")
        str = str.Replace("'False'", "False")
        '更改字符串，以输入正确的数据类型

        Dim sql As String = "UPDATE Object_List SET " & str & " WHERE Obj_ID = " & obj_ID
        'UPDATE Person SET Address = 'Zhongshan 23', City = 'Nanjing'        WHERE LastName = 'Wilson'
        '生成输入sql语句

        Dim cmd As OleDbCommand

        cn.Open()
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteNonQuery()
        cn.Close()

    End Sub
    '根据输入的ID号，变更TI

    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        DBcon()

        Dim obj_Name As String = ""
        obj_Name = InputBox("请输入新增规格名称" & vbLf & "新增规格的测试项目将会和现规格相同", "输入名称", "", 10, 10)
        '获取新规格名称

        If obj_Name <> "" Then
            addObject(Me.ID_Object, obj_Name)
            '添加新规格，新规格TI与此时显示的规格相同，新规格名字为输入的名字
            MessageBox.Show("添加成功！")
            NameInput_TextBox.Text = obj_Name
        End If

        cn.Close()

    End Sub
    '点击新增后新增规格

    Private Sub Signin_Button_Click(sender As Object, e As EventArgs) Handles Signin_Button.Click

        If checkDGVNull(Me.TestItem_DataGridView) Then
            changeObject(Me.ID_Object)
            MessageBox.Show("更新成功！")
        Else
            MessageBox.Show("请填完整")
        End If

        cn.Close()
    End Sub
    '点击OK后保存修改

    Private Sub TestItem_DataGridView_CurrentCellChanged(sender As Object, e As EventArgs) Handles TestItem_DataGridView.CurrentCellChanged

        If TestItem_DataGridView.CurrentCellAddress.X = -1 Then
            Exit Sub
        End If
        'DGV重置时防错

        Dim sel As Integer
        sel = TestItem_DataGridView.CurrentCell.ColumnIndex
        '获取当前选中单元格所在列

        Select Case sel
            Case 0
                Info_Label.Text = "测试项目：填入测试项目的名称"
            Case 1
                Info_Label.Text = "测试种类：1为单边范围，2为双边范围"
            Case 2
                Info_Label.Text = "标准值：数据标准值"
            Case 3
                Info_Label.Text = "偏差范围：±值。如果测试种类为2，则此处1表示≥规格值，为0时表示≤规格值"
            Case 4
                Info_Label.Text = "精度：精确到小数点后多少位"
            Case 5
                Info_Label.Text = "单位：计量单位"
            Case 6
                Info_Label.Text = "样本数量：一般为1或3"
            Case 7
                Info_Label.Text = "重要性：True为必须符合，False为仅作参考"
            Case 8
                Info_Label.Text = "精度：-1表示结果不为数值，0及0以上表示小数点后精度"
            Case Else
                Info_Label.Text = "未知：请联络管理员"
        End Select

    End Sub
    '输入新TI时显示注释

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        DisplayTI()
    End Sub

End Class