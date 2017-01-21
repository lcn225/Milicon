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
        da.Fill(result, "GetTableName_Type")

        Return result
    End Function
    '根据测试批号查找表名，返回DS

End Module
