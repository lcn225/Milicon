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

        Dim sql As String = "select * from ObjectType_List Order By Type_ID"
        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "displayType")
        '准备查询所有材料类型

        Me.type_DataGridView.DataSource = ds.Tables(0)
        Me.type_DataGridView.Columns(0).Visible = False
        '隐藏第一列“ID”

    End Sub

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
End Class