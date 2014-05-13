Imports System.Data.SqlClient

Public Class MainForm
    Dim dbClass As New DBMSClass
    Dim loggedIn As Boolean = False
    Dim getBookID As Integer
    Dim userID As Integer
    Dim getOnShelf As String
    Dim userRole As String
    Dim userName As String
    'Main form load function
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordTextBox.PasswordChar = "*"
        adminButton.Visible = False
        userPortalButton.Visible = False
        'loginGroupBox.Visible = True
        welcomeLabel.Visible = False
        userLabel.Visible = False
        logoutButton.Visible = False
        Dim Sql = "SELECT DISTINCT genre FROM dbo.Book"
        dbClass.analyzeSQL(dbClass.getConnectionString(), Sql, True, "genre")
        For Value As Integer = 0 To dbClass.ds.Tables.Item("genre").Rows.Count
            genreComboBox.Items.Add(dbClass.ds.Tables.Item("genre").Rows(Value).Item(0))
        Next

    End Sub


    'Search function
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim sqlString As String = ""
        sqlString = "select * from dbo.Book"
        If searchByTitleTextBox.Text <> "" Then
            sqlString += " where dbo.Book.[Book Name] = '" + searchByTitleTextBox.Text + "'"
            If genreComboBox.SelectedItem <> "" Then
                sqlString += "and dbo.Book.genre ='" + genreComboBox.Text + "'"
            End If
        End If

        'dbClass.ds.Clear()
        If searchByTitleTextBox.Text = "" And genreComboBox.Text = "" Then

            MsgBox("Please enter search selections!", MsgBoxStyle.Critical, "Search Error")
            Return
        ElseIf searchByTitleTextBox.Text = "" And genreComboBox.Text <> "" Then
            sqlString = "SELECT * FROM dbo.Book where genre = '" + genreComboBox.Text + "'"
        End If

        dbClass.ds.Clear()
        dataGridView.DataSource = dbClass.ds
        dbClass.analyzeSQL(dbClass.getConnectionString(), sqlString, True, "searchResults")
        If dbClass.ds.Tables.Item("searchResults").Rows.Count > 0 Then

            dataGridView.DataSource = dbClass.ds
            dataGridView.DataMember = "searchResults"
            dataGridView.Columns(0).Visible = False
            dataGridView.Columns(5).Visible = False
        Else
            MsgBox("Search wasn't found. Try Again!!", MsgBoxStyle.Information, "Search Result")
        End If

    End Sub

    'Login Function
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        If userNameTextBox.Text = "" Or passwordTextBox.Text = "" Then
            MsgBox("Please enter your username or password")
            Return
        End If
        Dim sqlString As String
        sqlString = "SELECT * FROM dbo.Users WHERE [User Name] ='" + userNameTextBox.Text + "' AND [Password] = '" + passwordTextBox.Text + "'"
        dbClass.analyzeSQL(dbClass.getConnectionString(), sqlString, True, "logInString")
        If dbClass.ds.Tables.Item("logInString").Rows.Count > 0 Then
            'get user id
            userID = dbClass.ds.Tables.Item("logInString").Rows(0).Item(0)

            'get username for display
            userName = dbClass.ds.Tables.Item("logInString").Rows(0).Item(1)

            'get the user role
            userRole = dbClass.ds.Tables.Item("logInString").Rows(0).Item(5)
            MsgBox("You are logged in, " + userName, MsgBoxStyle.Information, "Logged In")
            loggedIn = True
            loginGroupBox.Visible = False
            welcomeLabel.Visible = True
            userLabel.Text = userName
            userLabel.Visible = True

            logoutButton.Visible = True

            'check to see who logged in
            whoLoggedIn()

            'Pass userid to searchform if they will use it
            PassUserIDToSearchForm(userID, userRole)
        Else
            MsgBox("Login failed", MsgBoxStyle.Critical, "Log In Attempt")
        End If
    End Sub

    'Gets the column book id  
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

    'For register button
    Private Sub registerButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click
        RegisterForm.Show()
    End Sub

    'Checkout button
    Private Sub checkOutButton_Click(sender As Object, e As EventArgs) Handles checkOutButton.Click
        If loggedIn = False Then
            MsgBox("You must login first to proceed", MsgBoxStyle.Information, "Checkout")
            Return
        End If
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
            If userRole = "Admin" Then
                CreateIssueForm(getBookID, userID)
            Else
                'Allow to borrow
                CreateBorrowForm(getBookID, userID)
            End If
        End If

    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        loggedIn = False
        welcomeLabel.Visible = False
        userLabel.Visible = False
        userLabel.Text = ""
        logoutButton.Visible = False
        loginGroupBox.Visible = True
        adminButton.Visible = False
        userPortalButton.Visible = False
        userNameTextBox.Text = ""
        passwordTextBox.Text = ""
        userRole = ""
        dbClass.ds.Clear()
    End Sub

    'check user role to display different menu options
    Private Sub whoLoggedIn()
        If userRole = "Admin" Then
            adminLoggedIn()
        Else
            userLoggedIn()
        End If
    End Sub

    Private Sub adminLoggedIn()
        adminButton.Visible = True

    End Sub
    Private Sub userLoggedIn()
        userPortalButton.Visible = True
    End Sub

    Private Sub adminButton_Click(sender As Object, e As EventArgs) Handles adminButton.Click
        AdminForm.ShowDialog()
    End Sub

    Private Sub userPortalButton_Click(sender As Object, e As EventArgs) Handles userPortalButton.Click
        UserPortal.ShowDialog()
    End Sub

    'BookNumber represent the index of which book you want to reference on the main page
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

    Private Sub PassUserIDToSearchForm(ByVal getUserID As Integer, ByVal getUserRole As String)
        Dim thisform As searchForm
        thisform = New searchForm

        thisform.CurrentUserID = getUserID
        thisform.CurrentUserRole = getUserRole
    End Sub

    Private Sub libraryHoursButton_Click(sender As Object, e As EventArgs) Handles libraryHoursButton.Click
        libraryhours.ShowDialog()
    End Sub
End Class