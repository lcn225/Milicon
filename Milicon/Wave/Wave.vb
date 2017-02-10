Public Class Wave

    Public ID_Object As String = 0
    Private Sub Wave_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainMenu.Show()
    End Sub

    Public Sub DisplayTI()

    End Sub

    Private Sub ObjectList_Button_Click(sender As Object, e As EventArgs) Handles ObjectList_Button.Click
        ObjectList.Show()
        ObjectList.ObjectList_Load(Me, e)
    End Sub

End Class