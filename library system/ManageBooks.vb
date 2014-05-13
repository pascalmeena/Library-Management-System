Public Class ManageBooks
    Dim dbClass As New DBMSClass
    Dim getID
    Dim getAuthorIDCell
    'Function to update the data grid view automatically
    Private Sub DataGridLoad()
        dbClass.ds.Clear()

        Dim SqlDataGrid = "SELECT * FROM dbo.Book B, dbo.Author A, dbo.AuthorsBook AB WHERE ((AB.[Book ID] = B.[Book ID]) AND (A.[Author ID] = AB.[Author ID]))"
        dbClass.analyzeSQL(dbClass.getConnectionString(), SqlDataGrid, True, "books")
        DataGridView1.DataSource = dbClass.ds
        DataGridView1.DataMember = "books"

    End Sub

    'Main load 
    Private Sub ManageBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridLoad()
    End Sub

    'Function that fills data into the fields
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Me.bookNameTextBox.Text = DataGridView1.Item(1, i).Value
        Me.bookDetailsRichTextBox.Text = DataGridView1.Item(2, i).Value
        Me.genreTextBox.Text = DataGridView1.Item(3, i).Value
        Me.onShelfTextBox.Text = DataGridView1.Item(4, i).Value
        Me.authorFirstNameTextBox.Text = DataGridView1.Item(7, i).Value
        Me.authorLastNameTextBox.Text = DataGridView1.Item(8, i).Value

        getID = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        getAuthorIDCell = DataGridView1.Rows(e.RowIndex).Cells(7).Value
    End Sub

    'Add book function
    Private Sub addBookButton_Click(sender As Object, e As EventArgs) Handles addBookButton.Click
        Dim insertAuthorsBook
        Dim returnedAuthorID
        'Checks to see everything filled in
        If bookNameTextBox.Text = "" Or bookDetailsRichTextBox.Text = "" Or genreTextBox.Text = "" Or authorFirstNameTextBox.Text = "" Or authorLastNameTextBox.Text = "" Then
            MsgBox("Please fill all the information")
            Return
        End If

        'check if author exists in author, if exists, get author id, else insert author into Author
        'check if book exists in book, if exists, prompt, else insert into book
        '
        'insert new book into the database, check if book name exists before adding them
        Dim Sql = "SELECT * FROM dbo.Book where [Book Name] = '" + bookNameTextBox.Text + "'"
        dbClass.analyzeSQL(dbClass.getConnectionString(), Sql, True, "checkBook")
        If dbClass.ds.Tables.Item("checkBook").Rows.Count > 0 Then
            MsgBox("Book already exists, please insert a different book or update", MsgBoxStyle.Critical, "Error")
        Else
            'inserting the book
            Sql = "INSERT INTO dbo.Book ([Book Name], [Book Details], [Genre], [On Shelf]) " +
                "VALUES ('" + bookNameTextBox.Text + "','" + bookDetailsRichTextBox.Text + "','" + genreTextBox.Text + "','" + "Yes')"
            dbClass.analyzeSQL(dbClass.getConnectionString, Sql, False, "")

            'Getting the book id
            Dim getBookID = "SELECT [BookID] from dbo.Book WHERE [Book Name] = " + bookNameTextBox.Text
            dbClass.analyzeSQL(dbClass.getConnectionString, getBookID, True, "getBookIDs")
            Dim returnedBookID = dbClass.ds.Tables.Item("getBookIDs").Rows(1).Item("Book ID")
            '---------------------------------------------------------------------------------------

            'check if author exists
            Dim checkAuthor = "SELECT * FROM dbo.Author WHERE [First Name] = '" + authorFirstNameTextBox.Text + "'" + _
                " AND [Last Name] = '" + authorLastNameTextBox.Text + "'"
            dbClass.analyzeSQL(dbClass.getConnectionString(), checkAuthor, True, "checkAuthors")
            If dbClass.ds.Tables.Item("checkAuthor").Rows.Count > 0 Then
                returnedAuthorID = dbClass.ds.Tables.Item("checkAuthors").Rows(1).Item("Author ID")

                'insert the bookid and authorid into authorsbook table
                insertAuthorsBook = "INSERT INTO dbo.AuthorsBook ([Author ID], [Book ID]) " +
                    "VALUES ('" + returnedAuthorID + "','" + returnedBookID + "')"
                dbClass.analyzeSQL(dbClass.getConnectionString, insertAuthorsBook, False, "")
                MsgBox("Book ID:" + returnedBookID + " ,Author ID: " + returnedAuthorID + "inserted into AuthorsBook")
            Else
                'insert author into author table first
                Dim Sql2 = "INSERT INTO dbo.Author ([First Name],[Last Name]) " +
                    "VALUES ('" + authorFirstNameTextBox.Text + "','" + authorLastNameTextBox.Text + "')"
                dbClass.analyzeSQL(dbClass.getConnectionString, Sql2, False, "")

                'return that author's id
                Dim Sql3 = "SELECT [Author ID] FROM dbo.Author WHERE [First Name] = '" + authorFirstNameTextBox.Text + "'" + _
                    " AND [Last Name] = '" + authorLastNameTextBox.Text + "'"
                dbClass.analyzeSQL(dbClass.getConnectionString(), Sql3, True, "returnAuthorIDs")
                returnedAuthorID = dbClass.ds.Tables.Item("returnAuthorIDs").Rows(1).Item("Author ID")

                'insert the bookid and authorid into authorsbook table
                insertAuthorsBook = "INSERT INTO dbo.AuthorsBook ([Author ID], [Book ID]) " +
                    "VALUES ('" + returnedAuthorID + "','" + returnedBookID + "')"
                dbClass.analyzeSQL(dbClass.getConnectionString, insertAuthorsBook, False, "")
                MsgBox("Book ID:" + returnedBookID + " ,Author ID: " + returnedAuthorID + "inserted into AuthorsBook")
            End If
        End If
        DataGridLoad()
    End Sub

    'Clear Data Grid/Fields
    Private Sub clearGridButton_Click(sender As Object, e As EventArgs) Handles clearGridButton.Click
        Me.bookNameTextBox.Clear()
        Me.bookDetailsRichTextBox.Clear()
        Me.genreTextBox.Clear()
        Me.authorFirstNameTextBox.Clear()
        Me.authorLastNameTextBox.Clear()
    End Sub

    'Update Book function
    Private Sub updateBookButton_Click(sender As Object, e As EventArgs) Handles updateBookButton.Click
        'Get row selected then increment by one to calculate the bookID, then update book info
        Dim i As Integer
        i = getID

        Dim getAuthorID = getAuthorIDCell

        'Update the book table
        Dim updateBookSql = "UPDATE dbo.Book " & _
          "SET [Book Name] = '" & bookNameTextBox.Text & "', [Book Details] = '" & bookDetailsRichTextBox.Text & "', [Genre] = '" & genreTextBox.Text & "', [On Shelf] = '" & onShelfTextBox.Text & "'" & _
          " WHERE [Book ID] = " & i
        dbClass.analyzeSQL(dbClass.getConnectionString, updateBookSql, False, "")

        'Update the author table
        Dim updateAuthorSql = "UPDATE dbo.Author " & _
            "SET [First Name] = '" & authorFirstNameTextBox.Text & "', [Last Name] = '" & authorLastNameTextBox.Text & "' " & _
            "WHERE [Author ID] = " & getAuthorIDCell
        dbClass.analyzeSQL(dbClass.getConnectionString, updateAuthorSql, False, "")

        DataGridLoad()
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If Me.DataGridView1.Columns(e.ColumnIndex).Name = "Book ID" Then
            e.CellStyle.BackColor = Color.Gray
        End If
    End Sub


    Private Sub deleteBookButton_Click(sender As Object, e As EventArgs) Handles deleteBookButton.Click
        'Get row selected then increment by one to calculate the userID
        Dim i As Integer
        i = getID

        'Deletes book from the database
        Dim deleteBookSQL = "DELETE FROM dbo.Book " & _
            "WHERE [Book ID] = " & i
        dbClass.analyzeSQL(dbClass.getConnectionString, deleteBookSQL, False, "")

        'Delete book/author from the authorsbook 
        Dim deleteAuthorSql = "Delete from dbo.authorsbook " & _
           "where ([author id] = " & getAuthorIDCell & ") and ([book id] = " & getID & ")"
        dbClass.analyzeSQL(dbClass.getConnectionString, deleteAuthorSql, False, "")
        DataGridLoad()

    End Sub
End Class