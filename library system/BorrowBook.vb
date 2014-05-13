Public Class BorrowBook
    Dim dbClass As New DBMSClass
    Protected Friend CurrentBookID As New Integer
    Protected Friend CurrentUserID As New Integer

    Private Sub issueButton_Click(sender As Object, e As EventArgs) Handles borrowButton.Click, Button1.Click
        If bookIDTextBox.Text = "" Or userIDTextBox.Text = "" Then
            MsgBox("Please fill all the information")
            Return
        End If
        'Check if the book is on shelf/exists
        Dim Sql = "SELECT * FROM dbo.Book where [Book ID] = " + bookIDTextBox.Text
        dbClass.analyzeSQL(dbClass.getConnectionString(), Sql, True, "checkBook")

        'Check if the user is exists in case it's changed
        Dim checkUser2 = "SELECT * FROM dbo.Users where [User ID] = " + userIDTextBox.Text
        dbClass.analyzeSQL(dbClass.getConnectionString(), checkUser2, True, "checkUser22")

        If (dbClass.ds.Tables.Item("checkBook").Rows.Count < 0) Then
            MsgBox("Book does not exist, Check the book id", MsgBoxStyle.Critical, "Error")
            Return
        ElseIf (dbClass.ds.Tables.Item("checkUser22").Rows.Count < 0) Then
            MsgBox("User does not exist, Check the user id", MsgBoxStyle.Critical, "Error")
            Return
        Else
            'insert data into borrow table
            Dim insertBorrow = "INSERT INTO dbo.Borrow ([Book ID], [User ID], [Date Borrowed], [Date Due]) " & _
                "VALUES (" & bookIDTextBox.Text & "," & userIDTextBox.Text & ",'" & DateTimePicker1.Value.ToString("yyyy/MM/dd") & "','" & DateTimePicker2.Value.ToString("yyyy/MM/dd") & "')"
            dbClass.analyzeSQL(dbClass.getConnectionString, insertBorrow, False, "")

            'update onshelf for book to no
            'Update the book table
            Dim updateBookSql = "UPDATE dbo.Book " & _
             "SET [On Shelf] = 'No' " & _
             "WHERE [Book ID] = " & bookIDTextBox.Text
            dbClass.analyzeSQL(dbClass.getConnectionString, updateBookSql, False, "")
            MsgBox("Borrowed Successfully!", MsgBoxStyle.Information, "Borrow")
            insertBorrow = ""
            Me.Close()
        End If



    End Sub

    'Load Page, loads the textboxes with data passed from Main Page
    Private Sub BorrowBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bookIDTextBox.Text = CurrentBookID
        userIDTextBox.Text = CurrentUserID

        'Date constraints, up to two weeks only
        DateTimePicker1.MinDate = DateAndTime.Now
        DateTimePicker1.MaxDate = DateAndTime.Now.AddDays(14)
        DateTimePicker2.MinDate = DateAndTime.Now
        DateTimePicker2.MaxDate = DateTimePicker1.MaxDate
    End Sub

    Private Sub cancelButton2_Click(sender As Object, e As EventArgs) Handles cancelButton2.Click, Button2.Click
        Me.Close()
    End Sub

End Class