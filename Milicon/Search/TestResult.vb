Imports System.ComponentModel

Public Class TestResult


    Private Sub TestResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = SearchData.TestLots
    End Sub

    Private Sub TestResult_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SearchData.Show()
    End Sub

End Class