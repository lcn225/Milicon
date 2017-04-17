Imports System.ComponentModel
Imports System.Data.OleDb

Public Class ObjectList

    Dim SelectRowNumber As String
    Dim Sender As Object

    Public Sub ObjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Sender = sender

        SelectRowNumber = 0
        '默认选中第一行

        FillDGVbyObjecList(Me.ObjectList_DataGridView)

        Me.Text = ini.GetIniString("ObjectList", "Title", "Title")
        Me.OK_Button.Text = ini.GetIniString("ObjectList", "Button1", "OK")
        Me.Cancel_Button.Text = ini.GetIniString("ObjectList", "Button2", "Cancel")

        FillComboBoxByObjType(ObjectType_ComboBox)
        '填充ComboBox
        'FillDGV(Me.ObjectList_DataGridView)
        '填充DGV

        filter_TextBox.Focus()

    End Sub
    '窗体初始化

    Private Sub PassSelected()
        SelectRowNumber = Me.ObjectList_DataGridView.CurrentRow.Index
        Me.Sender.ID_Object = ObjectList_DataGridView.Rows(SelectRowNumber).Cells(0).Value
        '将选中材料的ID赋予Sender的ID参数（查询用）
        Me.Sender.NameInput_TextBox.Text = ObjectList_DataGridView.Rows(SelectRowNumber).Cells(2).Value
        '按OK后将选中行的第三单元格数据传输至规格值输入框
        Me.Sender.DisplayTI()
        '直接在Sender的DGV中显示TI
    End Sub
    '将选中数据传给Signin窗口相关

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        PassSelected()
        Me.Close()
    End Sub
    '点击OK选中材料名称

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click

        Me.Close()
    End Sub
    '点取消按钮后直接退出

    Private Sub ObjectList_DataGridView_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ObjectList_DataGridView.MouseDoubleClick
        PassSelected()
        Me.Close()
    End Sub
    '双击选中材料名称

    Private Sub ObjectType_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ObjectType_ComboBox.SelectedIndexChanged

        Dim selected As String = ObjectType_ComboBox.SelectedItem.ToString
        '获取变更后所选字符串

        If selected = "所有材料" Then
            FillDGVbyObjecList(Me.ObjectList_DataGridView)
            '如果所选为所有材料时，DGV显示所有材料
        Else
            FillDGVbyObjecList(selected, Me.ObjectList_DataGridView)
            '否则显示所选种类材料
        End If
    End Sub
    '当改变下拉列表选择时，改变DGV显示

    Private Sub ObjectList_Close() Handles MyBase.Closing
        'Signin.Temp_Label.Text = Signin.ID_Object
        '临时调试刷新用，完成后可删除上行
    End Sub

    '快速检索过滤
    Private Sub filter_TextBox_TextChanged(sender As Object, e As EventArgs) Handles filter_TextBox.TextChanged

        ObjectType_ComboBox_SelectedIndexChanged(Me, e)
        '变更后重新填充

        If filter_TextBox.Text = "" Then
            Exit Sub
            '如果TEXT为空则跳出
        Else
            For i = 0 To ObjectList_DataGridView.RowCount - 1
                Dim ins As Integer = InStr(ObjectList_DataGridView.Rows(i).Cells("材料名").Value, filter_TextBox.Text, CompareMethod.Text)
                '搜索关键词是否在材料名中出现
                If ins = 0 Then

                    Dim myCurrencyManager As CurrencyManager

                    myCurrencyManager = CType(Me.BindingContext(ObjectList_DataGridView.DataSource), CurrencyManager)
                    ObjectList_DataGridView.CurrentCell = Nothing
                    myCurrencyManager.SuspendBinding() '挂起数据绑定
                    ObjectList_DataGridView.Rows(i).Visible = False
                    myCurrencyManager.ResumeBinding() '恢复数据绑定

                End If
                '将不包含关键词的行隐藏
            Next

        End If

    End Sub

    '设置快捷键
    Private Sub Signin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Up Then
            MsgBox(1)
        End If

    End Sub


End Class

