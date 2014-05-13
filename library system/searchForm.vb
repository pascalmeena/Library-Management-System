Public Class searchForm
    Dim dbClass As New DBMSClass
    Protected Friend CurrentUserID As New Integer
    Protected Friend CurrentUserRole As String
    Dim getBookID As Integer
    Dim getOnShelf As String
    Dim getAuthorID As Integer
    'Function to update the data grid view automatically
    Private Sub DataGridLoad()

        Dim Sql2 = "SELECT * FROM dbo.Book ORDER BY [Book ID]"
        dbClass.analyzeSQL(dbClass.getConnectionString(), Sql2, True, "Allbooks")
        dataGridView.DataSource = dbClass.ds
        dataGridView.DataMember = "Allbooks"

    End Sub

    Private Sub searchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Sql = "SELECT DISTINCT genre FROM dbo.Book"
        dbClass.analyzeSQL(dbClass.getConnectionString(), Sql, True, "genre")
        For Value As Integer = 0 To dbClass.ds.Tables.Item("genre").Rows.Count - 1
            genreComboBox.Items.Add(dbClass.ds.Tables.Item("genre").Rows(Value).Item(0))
        Next

        
        DataGridLoad()
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        'Main form load function
        Dim sqlString As String = ""
        dbClass.ds.Clear()
        'get book id and send message if doesn't exit
        Dim getID = "select [book id], [book name], [genre], [on shelf] from dbo.book where [book name] = '" + searchByTitleTextBox.Text + "'"
        dbClass.analyzeSQL(dbClass.getConnectionString(), sqlString, True, "getID")
        If dbClass.ds.Tables.Item("logInString").Rows.Count > 0 Then
            Dim bookID As Integer = dbClass.ds.Tables.Item("getID").Rows(0).Item(0)
        Else
            MsgBox("Book doesn't exist!", MsgBoxStyle.Critical, "Search Result")
            Return
        End If
        'get book id and send message if doesn't exit
        Dim getAuthor = "select [author id], [first name], [last name] from dbo.author where [first name] = '" + searchByAuthorFirstNameTextBox.Text _
        + "' and [last name] = '" + searchByAuthorLastNameTextBox.Text + "'"
        dbClass.analyzeSQL(dbClass.getConnectionString(), sqlString, True, "getAuth")
        If dbClass.ds.Tables.Item("getAuth").Rows.Count > 0 Then
            getAuthorID = dbClass.ds.Tables.Item("getAuth").Rows(0).Item(0)
        Else
            MsgBox("Author Not Found!", MsgBoxStyle.Critical, "Search Result")
            Return
        End If
        'create a search query for joining
        sqlString = "select dbo.book.[book id], dbo.book.[Book Name], dbo.book.[on shelf] from dbo.Book, dbo.Author, dbo.AuthorsBook "
        'check only if title/genre entered
        If searchByTitleTextBox.Text <> "" And genreComboBox.Text = "" And searchByAuthorFirstNameTextBox.Text = "" And searchByAuthorLastNameTextBox.Text = "" Then
            'sqlString += " where (dbo.Book.[Book Name] = '" + searchByTitleTextBox.Text + "') "
            dataGridView.DataSource = dbClass.ds
            dataGridView.DataMember = "getID"
            If genreComboBox.SelectedItem <> "" Then
                'sqlString += "and (dbo.Book.genre = '" + genreComboBox.Text + "') "
                If ((dbClass.ds.Tables.Item("getID").Rows(0).Item(2)) = genreComboBox.Text) And (dbClass.ds.Tables.Item("getID").Rows(0).Item(1) = searchByTitleTextBox.Text) Then
                    dataGridView.DataSource = dbClass.ds
                    dataGridView.DataMember = "getID"
                Else
                    MsgBox("No Match Found!", MsgBoxStyle.Critical, "Search Result")
                    Return
                End If
            End If
        End If
        If searchByAuthorFirstNameTextBox.Text <> "" And searchByTitleTextBox.Text = "" And genreComboBox.Text = "" Then
            dataGridView.DataSource = dbClass.ds
            dataGridView.DataMember = "getAuth"
        ElseIf searchByAuthorFirstNameTextBox.Text <> "" And searchByTitleTextBox.Text <> "" Then
            sqlString += "where dbo.authorsbook.[author id] = " + getAuthorID + " and dbo.authorsbook.[book id] = " + getBookID _
            + "and dbo.book.[book id] = " + getBookID
        End If

        dbClass.analyzeSQL(dbClass.getConnectionString(), sqlString, True, "searchResults")
        If dbClass.ds.Tables.Item("searchResults").Rows.Count > 0 Then
            dataGridView.DataSource = dbClass.ds
            dataGridView.DataMember = "searchResults"
        Else
            MsgBox("Search wasn't found. Try Again!!", MsgBoxStyle.Information, "Search Result")
        End If

    End Sub



    Private Sub borrowButton_Click(sender As Object, e As EventArgs) Handles borrowButton.Click
        
        If getBookID = 0 Or IsDBNull(getBookID) Then
            MsgBox("Please select a book", MsgBoxStyle.Information, "Borrow Book")
            getBookID = 0
            Return
        End If
        'Check if the book is on shelf
        If getOnShelf = "No" Then
            MsgBox("Unable to borrow current book, NOT ON SHELF", MsgBoxStyle.Exclamation, "Borrow Book")
            getOnShelf = ""
            Return
        Else
            'Check if student or admin
            If CurrentUserRole = "Admin" Then
                CreateIssueForm(getBookID, CurrentUserID)
            Else
                'Allow to borrow
                CreateBorrowForm(getBookID, CurrentUserID)
            End If
        End If

    End Sub

    'BookID represent the id of which book you want to reference
    Private Sub CreateBorrowForm(ByVal BookID As Integer, ByVal getUserID As Integer)
        Dim thisform As BorrowBook
        thisform = New BorrowBook

        thisform.CurrentBookID = BookID
        thisform.CurrentUserID = getUserID
        thisform.ShowDialog()
        thisform.Activate()
    End Sub

    Private Sub CreateIssueForm(ByVal BookID As Integer, ByVal getUserID As Integer)
        Dim thisform As IssueBook
        thisform = New IssueBook

        thisform.CurrentBookID = BookID
        thisform.CurrentUserID = getUserID
        thisform.ShowDialog()
        thisform.Activate()
    End Sub
    Private Sub dataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView.CellClick
        If IsDBNull(dataGridView.Rows(e.RowIndex).Cells(0).Value) Then
            MsgBox("Please select a valid book within range", MsgBoxStyle.Critical, "Book Select")
            Return
        End If

        getBookID = dataGridView.Rows(e.RowIndex).Cells(0).Value
        getOnShelf = dataGridView.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub DataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dataGridView.CellFormatting
        If Me.dataGridView.Columns(e.ColumnIndex).Name = "Book Name" Then
            e.CellStyle.BackColor = Color.Gray
        End If
        If Me.dataGridView.Columns(e.ColumnIndex).Name = "On Shelf" Then
            e.CellStyle.BackColor = Color.Red
        End If
    End Sub
End Class