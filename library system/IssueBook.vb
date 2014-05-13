Public Class IssueBook
    Protected Friend CurrentBookID As New Integer
    Protected Friend CurrentUserID As New Integer
    Dim dbClass As New DBMSClass

    Private Sub IssueBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bookIDTextBox.Text = CurrentBookID
        userIDTextBox.Text = CurrentUserID
        DataGridLoad()

        'Date constraints
        DateTimePicker1.MinDate = DateAndTime.Now
        DateTimePicker2.MinDate = DateAndTime.Now
        DateTimePicker2.MaxDate = DateTimePicker1.MaxDate
    End Sub

    'Function to update the data grid view automatically
    Private Sub DataGridLoad()

        Dim SqlDataGrid = "SELECT [User ID], [User Name], [First Name], [Last Name] FROM dbo.Users ORDER BY [User ID]"
        dbClass.analyzeSQL(dbClass.getConnectionString(), SqlDataGrid, True, "users")
        DataGridView1.DataSource = dbClass.ds
        DataGridView1.DataMember = "users"

        Dim SqlDataGrid2 = "SELECT [Book ID], [Book Name], [On Shelf] FROM dbo.Book WHERE [On Shelf] = 'Yes' ORDER BY [Book ID]"
        dbClass.analyzeSQL(dbClass.getConnectionString(), SqlDataGrid2, True, "books")

        DataGridView2.DataSource = dbClass.ds
        DataGridView2.DataMember = "books"

    End Sub

    'Cancel button
    Private Sub cancelButton2_Click(sender As Object, e As EventArgs) Handles cancelButton2.Click
        Me.Close()
    End Sub

    Private Sub issueButton_Click(sender As Object, e As EventArgs) Handles issueButton.Click
        If bookIDTextBox.Text = "" Or userIDTextBox.Text = "" Then
            MsgBox("Please fill all the information")
            Return
        End If

        'Check if the book is on shelf/exists
        If (bookIDTextBox.Text = 0) Then
            MsgBox("Book does not exist, Check the book id", MsgBoxStyle.Critical, "Error")
            Return
            'Check if the user exists in case it's changed/entered manually
        ElseIf (userIDTextBox.Text = 0) Then
            MsgBox("User does not exist, Check the user id", MsgBoxStyle.Critical, "Error")
            Return
        Else
            'insert data into borrow table
            Dim insertBorrow2 = "INSERT INTO dbo.Borrow ([Book ID], [User ID], [Date Borrowed], [Date Due]) " & _
                "VALUES (" & bookIDTextBox.Text & "," & userIDTextBox.Text & ",'" & DateTimePicker1.Value.ToString("yyyy/MM/dd") & "','" & DateTimePicker2.Value.ToString("yyyy/MM/dd") & "')"
            dbClass.analyzeSQL(dbClass.getConnectionString, insertBorrow2, False, "")
            MsgBox(insertBorrow2)
            'update onshelf for book to no
            Dim updateBookSql2 = "UPDATE dbo.Book " & _
             "SET [On Shelf] = 'No' " & _
             "WHERE [Book ID] = " & bookIDTextBox.Text
            dbClass.analyzeSQL(dbClass.getConnectionString, updateBookSql2, False, "")
            MsgBox("Issued Successfully!", MsgBoxStyle.Information, "Issued")
            dbClass.ds.Clear()
            DataGridView1.DataSource = dbClass.ds
            DataGridLoad()
        End If
    End Sub

    'DataGridView1 cell click
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        CurrentUserID = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Me.userIDTextBox.Text = CurrentUserID

    End Sub

    'DataGridView2 cell click

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        CurrentBookID = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        Me.bookIDTextBox.Text = CurrentBookID
    End Sub
End Class