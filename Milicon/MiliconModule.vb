Imports System.Data.OleDb

Module MiliconModule

    Public cn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet


    Public Sub DBcon()
        Dim cnStr As String = "Provider=" + ini.GetIniString("DBconnect", "Provider", "Microsoft.Jet.OLEDB.4.0") + ";Data Source=" + ini.GetIniString("DBconnect", "Source", "\\192.168.2.100\DataBase\Milicon.mdb") + ";Persist Security Info=" + ini.GetIniString("DBconnect", "Persist Security Info", "False")
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

    Public Function GetTableName_Type(ByVal ID_Obj As String) As DataSet
        DBcon()
        Dim result As DataSet

        Dim Type_Obj As String = GetObjType(ID_Obj)
        '根据ID查找材料种类

        Dim sql2 As String = "Select * from ObjectType_List where Obj_Type='" + Type_Obj + "'"
        da = New OleDbDataAdapter(sql2, cn)
        result = New DataSet
        da.Fill(result, "GetTableName_Type")
        'Dim Type As String = ds.Tables(0).Rows(0)(0).ToString

        '根据材料种类查找表名
        Return result
        cn.Close()

    End Function
    '根据材料ID查找表名，返回DS

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
    '根据测试批号查找材料种类，输入ID，返回字符串

    Public Function GetTableNameByLoginNo(ByVal LoginNo As String) As DataSet

        DBcon()
        Dim result As DataSet

        Dim Type_Obj As String = GetObjTypeByLoginNo(LoginNo)
        '根据ID查找材料种类

        Dim sql2 As String = "Select * from ObjectType_List where Obj_Type='" + Type_Obj + "'"
        da = New OleDbDataAdapter(sql2, cn)
        result = New DataSet
        da.Fill(result, "GetTableName")

        Return result
    End Function
    '根据测试批号查找表名，返回DS

    Public Function GetDateTableNameByLoginNo(ByVal LoginNo As String) As String
        DBcon()
        Dim result As DataSet
        Dim TableName As String

        result = GetTableNameByLoginNo(LoginNo)
        '根据LoginNo返回DS

        TableName = result.Tables(0).Rows(0)("DataTableName").ToString
        '从DS中获取DataTableName

        Return TableName
    End Function
    '根据测试批号查找测试数据表名，返回字符串

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
            Raw = Mid(Raw, 1, MidOfRaw) & "L" & Mid(Raw, MidOfRaw + 1, MidOfRaw) & "C" & Mid(Raw, MidOfRaw * 2 + 1, MidOfRaw) & "N" & Mid(Raw, MidOfRaw * 3 + 1, MidOfRaw)
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

End Module
