Public Class ini

    Private Declare Function GetPrivateProfileString _
        Lib "KERNEL32.DLL" Alias "GetPrivateProfileStringA" (
        ByVal lpAppName As String,
        ByVal lpKeyName As String,
        ByVal lpDefault As String,
        ByVal lpReturnedString As String,
        ByVal nSize As Integer,
        ByVal lpFileName As String
        ) As Integer

    Private Declare Function WritePrivateProfileString _
        Lib "kernel32" Alias "WritePrivateProfileStringA" (
        ByVal lpApplicationName As String,
        ByVal lpKeyName As String,
        ByVal lpString As String,
        ByVal lpFileName As String
        ) As Int32

    Public Shared Function GetIniString(ByVal apName As String, ByVal keyName As String, ByVal defaults As String, ByVal fileName As String) As String
        Dim strResult As String = Space(255)
        Call GetPrivateProfileString(apName, keyName, defaults, strResult, Len(strResult), fileName)
        Return Microsoft.VisualBasic.Left(strResult, InStr(strResult, Chr(0)) - 1)
    End Function

    Public Shared Function GetIniString(ByVal apName As String, ByVal keyName As String, ByVal defaults As String) As String
        Dim fileName As String = My.Application.Info.DirectoryPath & "\MainMenu.ini"
        Return GetIniString(apName, keyName, defaults, fileName)
    End Function

    Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As Long
        Dim strResult As String = Space(255)
        WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, FileName)
        Return Microsoft.VisualBasic.Left(strResult, InStr(strResult, Chr(0)) - 1)
    End Function

    Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String) As Long
        Dim fileName As String = My.Application.Info.DirectoryPath & "\MainMenu.ini"
        Return WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, fileName)
    End Function

End Class
