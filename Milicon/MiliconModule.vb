﻿Imports System.Data.OleDb

Module MiliconModule

    Public cn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet


    Public Sub DBcon()
        Dim cnStr As String = "Provider=" + ini.GetIniString("DBconnect", "Provider", "Microsoft.Jet.OLEDB.4.0") + ";Data Source=" + ini.GetIniString("DBconnect", "Data Source", System.AppDomain.CurrentDomain.BaseDirectory + "Milicon.mdb") + ";Persist Security Info=" + ini.GetIniString("DBconnect", "Persist Security Info", "False")
        '根据INI内容定义链接字符串
        cn = New OleDbConnection(cnStr)
        '建立链接
    End Sub
    '链接数据库

    Public Function GetObjType(ByVal ID_Obj As String) As String
        DBcon()

        Dim sql1 As String = "Select Obj_Type from Object_List where Obj_ID=" + ID_Obj
        da = New OleDbDataAdapter(sql1, cn)
        ds = New DataSet
        da.Fill(ds, "result")
        Dim Type_Obj As String = ds.Tables(0).Rows(0)(0).ToString
        '根据ID查找材料种类

        Return Type_Obj

        cn.Close()
    End Function
    '根据材料ID查找材料种类，输入ID，返回字符串

    Public Function getQtyByID(ByVal ID_Obj As String, ByVal TI As String) As Integer

        DBcon()

        Dim sql As String = "Select TI" & TI & "_Qty From Object_List Where Obj_ID = " & ID_Obj
        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "getQtyByID")
        Dim Unit As String = ds.Tables(0).Rows(0)(0).ToString

        Return Unit

        cn.Close()
    End Function
    '根据材料ID与测试项目号查找样本数，返回整数

    Public Function getNumByID(ByVal ID_Obj As String) As Integer

        DBcon()

        Dim sql As String = "Select TI_Num From Object_List Where Obj_ID = " & ID_Obj
        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "getNumByID")
        Dim Unit As String = ds.Tables(0).Rows(0)(0).ToString

        Return Unit

        cn.Close()
    End Function
    '根据材料ID查找TI数目，返回整数

    Public Function getMAXQtyByID(ByVal ID_Obj As String) As Integer

        DBcon()

        Dim Num = getNumByID(ID_Obj)
        '获取TI数目

        Dim d As String = "select TI1_Qty as d from Object_List  where Obj_ID = " & ID_Obj & " "
        For i = 2 To Num
            d = d & "union select TI" & i & "_Qty as d from Object_List where Obj_ID = " & ID_Obj & " "
        Next

        Dim sql As String = "select max(t.d) from (" & d & ")t"
        'select max(t.d) from (select TI1_Qty as d from Object_List  where Obj_ID = 28 union select TI2_Qty as d from Object_List where Obj_ID = 28 union select TI3_Qty as d from Object_List where Obj_ID = 28 union select TI4_Qty as d from Object_List where Obj_ID = 28 union select TI5_Qty as d from Object_List where Obj_ID = 28 union select TI6_Qty as d from Object_List where Obj_ID = 28 union select TI7_Qty as d from Object_List where Obj_ID = 28 union select TI8_Qty as d from Object_List where Obj_ID = 28 union select TI9_Qty as d from Object_List where Obj_ID = 28 )t

        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "getMAXQtyByID")
        Dim Unit As String = ds.Tables(0).Rows(0)(0).ToString

        Return Unit

        cn.Close()
    End Function
    '根据材料ID与测试项目号查找样本数，返回整数

    Public Function GetObjTypeByLoginNo(ByVal LoginNo As String) As String
        DBcon()

        Dim sql1 As String = "Select ObjectType_List.Obj_Type from Data_List, ObjectType_List where Data_List.LoginNo=" + LoginNo
        da = New OleDbDataAdapter(sql1, cn)
        ds = New DataSet
        da.Fill(ds, "GetObjTypeByLoginNo")
        Dim Type_Obj As String = ds.Tables(0).Rows(0)(0).ToString
        '根据测试批号查找材料种类

        Return Type_Obj

        cn.Close()
    End Function
    '根据测试批号查找材料种类，输入LoginNo，返回字符串

    Public Function GetObjNameByLoginNo(ByVal LoginNo As String) As String
        DBcon()

        Dim sql As String = "Select Object_List.Obj_Name from Data_List, Object_List where Data_List.LoginNo=" + LoginNo + " and Data_List.Obj_ID = Object_List.Obj_ID"
        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "GetObjTypeByLoginNo")
        Dim Type_Obj As String = ds.Tables(0).Rows(0)(0).ToString
        '根据测试批号查找材料种类

        Return Type_Obj

        cn.Close()
    End Function
    '根据测试批号查找材料名称，输入LoginNo，返回字符串

    Public Function GetObjIDByLoginNo(ByVal LoginNo As String) As String
        DBcon()

        Dim sql As String = "Select Object_List.Obj_ID from Data_List, Object_List where Data_List.LoginNo=" + LoginNo + " and Data_List.Obj_ID = Object_List.Obj_ID"
        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "GetObjTypeByLoginNo")
        Dim Type_Obj As String = ds.Tables(0).Rows(0)(0).ToString
        '根据测试批号查找材料种类

        Return Type_Obj

        cn.Close()
    End Function
    '根据测试批号查找材料ID，输入ID，返回字符串

    Public Function GetIDByType(ByVal Obj_Type As String) As String
        DBcon()

        Dim sql As String = "Select Type_ID from ObjectType_List where Obj_Type = '" + Obj_Type + "'"
        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "GetIDByType")
        Dim Type_ID As String = ds.Tables(0).Rows(0)(0).ToString

        Return Type_ID
    End Function
    '根据材料类型查询类型ID，输入类型名称，返回字符串

    Public Function GetTestInfoByLoginNo(ByVal LoginNo As String) As DataSet

        DBcon()
        Dim result As DataSet

        Dim sql As String = "Select * from Data_List where LoginNo=" + LoginNo
        da = New OleDbDataAdapter(sql, cn)
        result = New DataSet
        da.Fill(result, "GetTestInfo")

        Return result
    End Function
    '根据测试批号查找测试信息，返回DS

    Public Function encryption(ByVal Raw As String)

        Dim Result As String = ""
        Dim lng As Integer = Len(Raw)
        Dim MidOfRaw As Integer = Int(lng / 4)
        Dim Dra

        If lng > 4 Then
            Raw = Mid(Raw, 1, MidOfRaw) & "L" & Mid(Raw, MidOfRaw + 1, MidOfRaw) & "C" & Mid(Raw, MidOfRaw * 2 + 1, MidOfRaw) & "N" & Mid(Raw, MidOfRaw * 3 + 1, lng - MidOfRaw * 3)
        Else
            Raw = Raw & "LCN"
        End If
        '加盐

        For i = 1 To Len(Raw)
            Dra = Int((i + 26) * i Mod (Len(Raw)))
            Result = Result & ChrW(AscW(Mid(Raw, Len(Raw) - i + 1, 1)) + Dra)
        Next
        '凯撒并倒序

        Return Result
    End Function
    '对字符串简单加密，输出密文

    Public Function ave(ByVal num() As String, ByVal rnd As Integer) As Double
        Dim sum As Double = 0.0
        Dim n As Integer = 0
        Dim result As Double = 0.0

        For i = 0 To num.Length - 1
            If num(i) <> "" Then
                sum += num(i)
                n += 1
            End If
        Next

        result = System.Math.Round(sum / n, rnd)

        Return result
    End Function
    '计算平均数，删除空白值

    Public Sub ResetDGV(ByRef F As Form)

        Dim DGV_Name As String = ""

        For Each con As Control In F.Controls
            If TypeOf con Is DataGridView Then
                '如果当前控件是DGV的时候
                DGV_Name = con.Name
                '获取DGV名称
            End If
        Next con

        Dim DGV As DataGridView = F.Controls(DGV_Name)
        '引用该F的DGV

        Dim CountColumns As Integer = DGV.Columns.Count
        '获取该DGV列数

        'DGV.DataSource = vbNull
        '清除DGV所有数据
        For i = CountColumns - 1 To 0 Step -1
            DGV.Columns.RemoveAt(i)
        Next
        '清除DGV所有列
        '重置DGV

    End Sub
    '重置DGV

    Public Sub ResetCLB(ByRef F As Form)

        Dim CLB_Name As String = ""

        For Each con As Control In F.Controls
            If TypeOf con Is CheckedListBox Then
                '如果当前控件是CLB的时候
                CLB_Name = con.Name
                '获取CLB名称
            End If
        Next con

        Dim CLB As CheckedListBox = F.Controls(CLB_Name)
        '引用该F的CLB

        Dim Rows As Integer = CLB.Items.Count
        '获取该CLB行数

        'CLB.DataSource = vbNull
        '清除CLB所有数据
        For i = Rows - 1 To 0 Step -1
            CLB.Items.RemoveAt(i)
        Next
        '清除CLB所有行
        '重置CLB

    End Sub
    '重置CLB

    Public Sub disenableSort(ByRef DGV As DataGridView)

        Dim ColNum As String = DGV.ColumnCount
        Dim i As Integer

        For i = 0 To ColNum - 1
            DGV.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next

    End Sub
    '禁用DGV的点击排序功能

    Public Function checkDGVNull(ByRef DGV As DataGridView) As Boolean

        Dim num = DGV.RowCount
        '获取行数
        Dim col = DGV.ColumnCount
        '获取列数
        Dim result As Boolean = False

        For i = 0 To num - 1
            If DGV.Rows(i).Cells(0).Value <> "" Then
                '如果某行首值不为空时才继续判断该行（筛选新增空行）
                For j = 0 To col - 1
                    If DGV.Rows(i).Cells(j).Value = "" Then
                        '如果某个单元格为空
                        result = False
                        MessageBox.Show("第" & i + 1 & "行第" & j + 1 & "列为空值")
                        GoTo Exitall
                    End If
                Next
            End If
        Next

        result = True
        '如果以上全过，返回true

Exitall:
        Return result

    End Function
    '确认DGV中是否有空值，有的话返回True，没有的话返回False

    Public Sub delMulRowFromDataTable(ByRef DT As DataTable, ByVal field As String)

        Dim count As Integer = DT.Rows.Count
        Dim val
        Dim last = DT.Rows(count - 1)(field)
        '获取最后一行该字段数值

        For i = count - 2 To 0 Step -1
            '从倒数第二行开始到第一行
            val = DT.Rows(i)(field)
            If val = last Then
                '如果该行该字段数值等于下一行
                DT.Rows(i + 1).Delete()
                '删除下一行
            Else
                last = val
            End If
        Next

    End Sub
    '删除DataTable中指定字段重复行

    Public Sub FillComboBoxByObjType(ByRef cb As ComboBox)

        cb.Items.Clear()
        '重置该列表

        cb.Items.Add("所有材料")
        '在下拉列表中增加第一行，全部材料

        'cn.Open()

        Dim sql As String = "select Obj_Type from ObjectType_List"
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(sql, cn)
        Dim ds As DataSet = New DataSet
        '准备查询所有材料类型

        da.Fill(ds, "FillComboBoxByObjType")
        Dim RowsCount = ds.Tables(0).Rows.Count
        '建立数据集，统计记录数

        Dim i
        For i = 0 To RowsCount - 1
            Dim Type As String = ds.Tables(0).Rows(i)(0)
            cb.Items.Add(Type)
        Next
        '将查询结果（数据集）添加到Combobox中

        cb.SelectedIndex = 0
        '默认选中第一个

        cn.Close()

    End Sub
    '用材料类型列表填充下拉列表

    Public Sub FillDGVbyObjecList(ByRef DGV As DataGridView)

        DBcon()

        Dim sql As String = "select Obj_ID as 材料ID,Obj_Type as 材料类型,Obj_Name as 材料名,Obj_Sup as 厂商 from Object_List ORDER  by Obj_Type, Obj_Name, Obj_Sup"
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(sql, cn)
        Dim ds As DataSet = New DataSet
        '准备查询所有材料的ID与名称与厂商

        da.Fill(ds, "FillDGV")

        DGV.DataSource = ds.Tables(0)
        DGV.Columns(0).Visible = False
        '隐藏第一列“ID”

        cn.Close()

    End Sub
    '参数为空时，该方法用TYPE表内全部数据填充DGV

    Public Sub FillDGVbyObjecList(ByVal Type As String, ByRef DGV As DataGridView)

        Dim sql As String = "select Obj_ID as 材料ID,Obj_Type as 材料类型,Obj_Name as 材料名,Obj_Sup as 厂商 from Object_List where Obj_Type = '" + Type + "' ORDER  by Obj_Type, Obj_Name, Obj_Sup"
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(sql, cn)
        Dim ds As DataSet = New DataSet
        '准备查询所有材料名称与厂商

        cn.Open()

        da.Fill(ds, "FillDGV")

        DGV.DataSource = ds.Tables(0)
        DGV.Columns(0).Visible = False
        '隐藏第一列“ID”

        cn.Close()

    End Sub
    '参数为材料种类时，该方法使DGV仅显示全部该种类材料

    Public Sub ResetFormText(ByRef F As Form)

        For Each con As Control In F.Controls
            If TypeOf con Is TextBox Then
                '如果当前控件是TextBox的时候
                con.Text = ""
                '改变TextBox的Text属性
            End If
        Next con

        For Each con As Control In F.Controls
            If TypeOf con Is DateTimePicker Then
                '如果当前控件是Label的时候
                con.Text = Date.Today
                '改变Label的Text属性
            End If
        Next con


    End Sub
    '清除当前窗口的所有text

    Public Sub addObject(ByVal obj_ID As String, ByVal obj_Name As String, ByVal obj_Sup As String)
        DBcon()

        Dim sql1 As String = "Select * from Object_List Where Obj_ID = " & obj_ID
        da = New OleDbDataAdapter(sql1, cn)
        ds = New DataSet
        da.Fill(ds, "object_Info")

        Dim num As Integer = ds.Tables(0).Columns.Count
        '获得列数
        Dim colName As String = ""
        Dim str As String = ""

        For i = 1 To num - 1
            Dim temp As String = ds.Tables(0).Rows(0)(i).ToString
            '遍历第二之后的每个字段
            If temp <> "" Then
                '如果该字段为空值，则跳过
                colName = colName & " ," & ds.Tables(0).Columns(i).ColumnName
                str = str & " ,'" & temp & "'"
            End If
        Next
        '将所有数据输入
        colName = Mid(colName, 3)
        str = Mid(str, 3)
        '删除头部多余字符
        str = str.Replace(ds.Tables(0).Rows(0)("Obj_Name").ToString, obj_Name)
        '替换名称为新名称
        str = str.Replace("'" & ds.Tables(0).Rows(0)("Obj_Sup").ToString & "'", "'" & obj_Sup & "'")
        '替换厂商为新厂商
        str = str.Replace("'True'", "True")
        str = str.Replace("'False'", "False")
        '更改字符串，以输入正确的数据类型

        Dim sql2 As String = "INSERT INTO Object_List (" & colName & ") VALUES (" & str & ")"
        '生成输入sql语句

        Dim cmd As OleDbCommand

        cn.Open()
        cmd = New OleDbCommand(sql2, cn)
        cmd.ExecuteNonQuery()
        cn.Close()

    End Sub
    '根据输入的ID号，新增相同TI的材料

    Public Sub mergeCell(ByVal Obj_ID As String, ByRef DGV As DataGridView)
        DBcon()

        Dim sql As String = "Select * from Object_List WHERE Obj_ID = " & Obj_ID
        da = New OleDbDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "mergeCell")
        '查找ID对应信息

        Dim num As Integer = DGV.RowCount
        Dim Qty As Integer

        Dim cmb = New CmbDatagridbiew(DGV)
        '准备合并单元格

        For i = 0 To num - 1
            '遍历每一行
            Qty = ds.Tables(0).Rows(0)("TI" & (i + 1) & "_Qty").ToString
            If Qty = 1 Then
                cmb.Add(i, 1, i, 3)
                '如果样本数量为1，则合并单元格为1
                DGV.Rows(i).Cells(1).ReadOnly = False
                '使第一个单元格为可读
            End If
        Next

    End Sub
    '根据样本数量合并DGV单元格

    Public Function standAndRange(ByVal type As String, ByVal stand As String, ByVal range As String) As String

        Dim TI_Stand As String

        If type = 2 Then
            '如果TI类型为双边比较
            TI_Stand = stand & "±" & range
            '则规格值形式为“Stand±Range”
        ElseIf type = 1 Then
            '如果TI类型为单边比较
            If range = 1 Then
                '如果比较类型为1
                TI_Stand = "≥" & stand
                '则规格值形式为“≥Stand”
            ElseIf range = 0 Then
                TI_Stand = "≤" & stand
                '如果是0，则规格值形式为“≤Stand”
            Else
                TI_Stand = "规格值出错，请联络管理员确认"
                '都不是的话就报错
            End If
        Else
            TI_Stand = "无"
            '都不是的话就报错
        End If
        '获取字段名为"TIi_Stand"与"TIi_Range"的值，i为参数

        Return TI_Stand
    End Function
    '输入TI相关参数，返回规格范围

    Public Function ACCC(ByVal val As String, ByVal acc As Integer) As String

        Dim result As String
        If IsNumeric(val) Then

            result = FormatNumber(val, acc)
        Else
            result = val
        End If

        Return result
    End Function
    '控制小数点精度



End Module
