Public Class Reports
    Dim dbClass As New DBMSClass
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query = "select dbo.borrow.[user id], dbo.users.[user name], dbo.borrow.[book id], dbo.book.[book name] " _
                    + "From dbo.borrow, dbo.book, dbo.users Where (dbo.borrow.[book id] = dbo.book.[book id]) and " _
                    + "(dbo.borrow.[user id] = dbo.users.[user id])"

        ' dbClass.ds.Clear()
        ' DataGridView1.DataSource = dbClass.ds
        dbClass.analyzeSQL(dbClass.getConnectionString(), query, True, "searchResults")
        If dbClass.ds.Tables.Item("searchResults").Rows.Count > 0 Then

            DataGridView1.DataSource = dbClass.ds
            DataGridView1.DataMember = "searchResults"
        Else
            MsgBox("No report at the moment!!", MsgBoxStyle.Critical, "Search Result")
        End If

    End Sub
End Class