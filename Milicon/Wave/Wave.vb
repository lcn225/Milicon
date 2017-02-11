Imports System.Data.OleDb

Public Class Wave

    Public ID_Object As String = 0

    Private Sub fillCheckedListBoxByTI(ByVal ID_Obj As String)

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

    End Sub
    '将实验项目填充到CLB中

    Public Sub DisplayTI()
        fillCheckedListBoxByTI(ID_Object)
    End Sub

    Private Sub ObjectList_Button_Click(sender As Object, e As EventArgs) Handles ObjectList_Button.Click
        ObjectList.Show()
        ObjectList.ObjectList_Load(Me, e)
    End Sub
    '点击一览打开材料列表

    Private Sub Wave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBcon()

        'TI_CheckedListBox.DataSource = vbNull

    End Sub


    Private Sub Wave_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainMenu.Show()
    End Sub
    '关闭时显示主菜单

End Class