Public Class UserPortal

    Private Sub borrowBook_Click(sender As Object, e As EventArgs) Handles borrowBook.Click
        MainForm.ShowDialog()   'SearchForm.ShowDialog()
    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click

        MainForm.ShowDialog()
        Me.Close()
    End Sub

End Class