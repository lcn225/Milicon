Imports System.Data.OleDb

Public Class Maintenance_Type

    Private Sub TextFormat()
        Me.Text = ini.GetIniString("Maintenance_Type", "Title", "N/A")
        Me.signin_Button.Text = ini.GetIniString("Maintenance_Type", "Button1", "N/A")
        Me.del_Button.Text = ini.GetIniString("Maintenance_Type", "Button2", "N/A")
        Me.exit_Button.Text = ini.GetIniString("Maintenance_Type", "Button3", "N/A")
    End Sub
    'UI文本初始化

    Private Sub displayType()

        DBcon()

        ResetDGV(Me)

        Dim sql As String = "select Type_ID, Obj_Type as 材料类型 from ObjectType_List Order By Type_ID"
        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "displayType")
        '准备查询所有材料类型

        Me.type_DataGridView.DataSource = ds.Tables(0)
        Me.type_DataGridView.Columns(0).Visible = False
        '隐藏第一列“ID”

        disenableSort(Me.type_DataGridView)
        '禁止点击排序

        cn.Close()

    End Sub
    '在DGV内显示材料种类

    Private Sub Maintenance_Type_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ResetDGV(Me)
        TextFormat()
        displayType()

    End Sub

    Private Sub exit_Button_Click(sender As Object, e As EventArgs) Handles exit_Button.Click
        Me.Close()
    End Sub
    '按退出按钮关闭窗口

    Private Sub Maintenance_Type_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MaintenanceMainMenu.Show()
    End Sub

    Private Sub signin_Button_Click(sender As Object, e As EventArgs) Handles signin_Button.Click

        Dim num As Integer = Maintenance_ObjectList.DB_RowCount("ObjectType_List")
        '统计DS内类型数

        Dim num_now As Integer = Me.type_DataGridView.Rows.Count

        For i = num To num_now - 2
            If Me.type_DataGridView.Rows(i).Cells(0).ToString = "" Then
                '判断是否填入新行
                Exit For
            Else
                Dim tempStr As String = "INSERT INTO ObjectType_List (Obj_Type) VALUES ('" & Me.type_DataGridView.Rows(i).Cells(1).Value & "')"
                'INSERT INTO table_name (列1, 列2,...) VALUES (值1, 值2,....)

                Dim cmd As OleDbCommand = New OleDbCommand(tempStr, cn)
                cn.Open()
                cmd.ExecuteNonQuery()

            End If

        Next

        MessageBox.Show("保存成功", "信息")
        cn.Close()

    End Sub
    '增加新行

    Private Sub delSelectedType(ByVal Type As String)
        DBcon()

        Dim sql As String = "DELETE FROM ObjectType_List WHERE Obj_Type = '" & Type & "'"

        Dim cmd As OleDbCommand = New OleDbCommand(sql, cn)
        cn.Open()
        cmd.ExecuteNonQuery()

    End Sub
    '运行SQL命令，删除选中材料种类

    Private Sub del_Button_Click(sender As Object, e As EventArgs) Handles del_Button.Click

        Dim selectType As String = type_DataGridView.CurrentCell.Value.ToString
        '获取选中材料种类字符串

        Dim sql1 As String = "Select count(Obj_Type) from Object_List Where Obj_Type = '" & selectType & "'"
        da = New OleDbDataAdapter(sql1, cn)
        ds = New DataSet
        da.Fill(ds, "count(Obj_Type)")
        Dim num As String = ds.Tables(0).Rows(0)(0).ToString
        '检测选中材料种类是否有材料

        If num <> "0" Then
            MessageBox.Show("此类型材料不为空，禁止删除")
            '有材料时禁止删除并警告
        Else
            Dim cho As String = MessageBox.Show("是否确定要删除该材料类型？", "删除确认", MessageBoxButtons.YesNo)
            '确认是否删除
            If cho = 6 Then
                delSelectedType(selectType)
                '删除选中材料种类
                MessageBox.Show("删除成功")
                displayType()
                '如果选择是则删除并reload
            End If
        End If

    End Sub
    '点击删除按钮删除选中行

    Private Sub type_DataGridView_CurrentCellChanged(sender As Object, e As EventArgs) Handles type_DataGridView.CurrentCellChanged
        Dim row As Integer = type_DataGridView.CurrentCellAddress.Y.ToString
        If row >= 0 Then
            del_Button.Enabled = True
        Else
            del_Button.Enabled = False
        End If
    End Sub
    '如果选中了某行，则启用删除按钮，否则禁用

End Class