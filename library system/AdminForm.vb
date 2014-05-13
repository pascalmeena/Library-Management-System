Public Class AdminForm
    Dim dbClass As New DBMSClass

    'Calls the ManageUsers class
    Private Sub manageUsersButton_Click(sender As Object, e As EventArgs) Handles manageUsersButton.Click
        ManageUsers.ShowDialog()
    End Sub

    'Calls the ManageBooks class
    Private Sub manageBooksButton_Click(sender As Object, e As EventArgs) Handles manageBooksButton.Click
        ManageBooks.ShowDialog()
    End Sub


    Private Sub issueBooksButton_Click(sender As Object, e As EventArgs) Handles issueBooksButton.Click
        IssueBook.ShowDialog()
        IssueBook.Activate()

    End Sub

    Private Sub ETLButton_Click(sender As Object, e As EventArgs) Handles ETLButton.Click
        Dim todaysdate As String = String.Format("{0:yyyy/MM/dd}", DateTime.Now)
        Dim getData = "Select dbo.TimeTable.TimeID, dbo.TimeTable.CurrentTD " _
            + "From dbo.TimeTable Where (TimeTable.CurrentTD = '" + todaysdate + "')"
        'MsgBox(getData)
        dbClass.analyzeSQL(dbClass.getConnectionString(), getData, True, "checkTimeExists")

        'check if time exists
        If dbClass.ds.Tables.Item("checkTimeExists").Rows.Count <> 0 Then
            dbClass.ds.Tables.Item("checkTimeExists").Clear()
            MsgBox("Data warehouse is uptodate!", MsgBoxStyle.Information, "Update")
            Return
        End If

        'Creates the time id
        getData = "Insert into dbo.TimeTable (CurrentTD) Values ('" & todaysdate & "')"

        dbClass.analyzeSQL(dbClass.getConnectionString(), getData, False, "")
        'MsgBox(getData)
        'gets the time id
        getData = "Select TimeID From dbo.TimeTable Where (CurrentTD = '" + todaysdate + "')"
        dbClass.analyzeSQL(dbClass.getConnectionString(), getData, True, "checkTimeID")
        MsgBox(getData)
        'Gets information to put into the fact table
        getData = "Select dbo.Book.[Book ID], dbo.Book.Genre, dbo.PublisherTable.[Publisher ID], " _
            + "dbo.PublisherTable.[Publisher City], dbo.PublisherTable.[Publisher Country] From dbo.Book, dbo.Borrow, dbo.PublisherTable " _
            + "Where (dbo.Book.[Book ID] = dbo.Borrow.[Book ID]) AND (dbo.Book.[Publisher ID] = dbo.PublisherTable.[Publisher ID]) " _
            + "AND (dbo.Borrow.[Date Borrowed] = '" + todaysdate + "')"
        dbClass.analyzeSQL(dbClass.getConnectionString(), getData, True, "Results")
        MsgBox(getData)
        'MsgBox(dbClass.ds.Tables.Item("Results").Rows(0).Item("Publisher ID").ToString)
        For i As Integer = 0 To dbClass.ds.Tables.Item("Results").Rows.Count - 1
            getData = "Insert Into dbo.FactTable (BookID, PublisherID, TimeID, CountOfBorrow) Values " _
                + "(" + dbClass.ds.Tables.Item("Results").Rows(i).Item("Book ID").ToString + ", " _
                + dbClass.ds.Tables.Item("Results").Rows(i).Item("Publisher ID").ToString + ", " _
                + dbClass.ds.Tables.Item("checkTimeID").Rows(0).Item("TimeID").ToString + ", 1)"
            dbClass.analyzeSQL(dbClass.getConnectionString(), getData, False, "")

            getData = "Insert Into dbo.ETLBookTable ([Book ID], [Genre]) Values (" _
                + dbClass.ds.Tables.Item("Results").Rows(i).Item("Book ID").ToString + ", '" _
                + dbClass.ds.Tables.Item("Results").Rows(i).Item("Genre").ToString + "')"
            dbClass.analyzeSQL(dbClass.getConnectionString(), getData, False, "")

            getData = "Insert Into dbo.ETLPublisherTable ([Publisher ID], [Publisher City], [Publisher Country]) Values (" _
                + dbClass.ds.Tables.Item("Results").Rows(i).Item("Publisher ID").ToString + ", '" _
                + dbClass.ds.Tables.Item("Results").Rows(i).Item("Publisher City").ToString + "', '" _
                + dbClass.ds.Tables.Item("Results").Rows(i).Item("Publisher Country").ToString + "')"
            dbClass.analyzeSQL(dbClass.getConnectionString(), getData, False, "")
        Next

        dbClass.ds.Tables.Item("checkTimeExists").Clear()
        dbClass.ds.Tables.Item("Results").Clear()
        'dbClass.ds.Tables.Item("checkTimeID").Clear()
        MsgBox(getData)

        'get book data
        'Dim getBookData = "select [book id], [genre] from dbo.Book book, dbo.Borrow borrow" & _
        '   "insert into dbo.etlbooktable " & _
        '  "where book.[book id] = borrow.[borrow id] and borrow.[date borrowed] = " & Date.Now
    End Sub

    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
        Dashboard.ShowDialog()
        Dashboard.Activate()
    End Sub

    Private Sub viewReportsButton_Click(sender As Object, e As EventArgs) Handles viewReportsButton.Click
        Reports.ShowDialog()
        Reports.Activate()
    End Sub

End Class