Public Class ManageUsers
    Dim dbClass As New DBMSClass
    Dim getID
    'Function to update the data grid view automatically
    Private Sub DataGridLoad()
        
        Dim SqlDataGrid = "SELECT * FROM dbo.Users ORDER BY [User ID]"
        dbClass.analyzeSQL(dbClass.getConnectionString(), SqlDataGrid, True, "users")
        DataGridView1.DataSource = dbClass.ds
        DataGridView1.DataMember = "users"
    End Sub
   
    'ManageUsers form load function
    Private Sub ManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridLoad()
    End Sub

    'Function that fills data into the fields and gets the index id
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        'MsgBox(i)
        Me.userNameTextBox.Text = DataGridView1.Item(1, i).Value
        Me.firstNameTextBox.Text = DataGridView1.Item(2, i).Value
        Me.lastNameTextBox.Text = DataGridView1.Item(3, i).Value
        Me.passwordTextBox.Text = DataGridView1.Item(4, i).Value
        Me.roleComboBox.Text = DataGridView1.Item(5, i).Value

        getID = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        'MsgBox(getID)
    End Sub

    'Add user function
    Private Sub addUserButton_Click(sender As Object, e As EventArgs) Handles addUserButton.Click
        'Checks to see everything filled in
        If userNameTextBox.Text = "" Or firstNameTextBox.Text = "" Or firstNameTextBox.Text = "" Or lastNameTextBox.Text = "" Or passwordTextBox.Text = "" Or roleComboBox.SelectedItem = "" Then
            MsgBox("Please fill all the information")
            Return
        End If

        'insert new user into the database, check if username exists before adding them
        Dim Sql = "SELECT * FROM dbo.Users where [User Name] = '" + userNameTextBox.Text + "'"
        dbClass.analyzeSQL(dbClass.getConnectionString(), Sql, True, "checkUser")
        If dbClass.ds.Tables.Item("checkUser").Rows.Count > 0 Then
            MsgBox("Username already exists, please choose a different username", MsgBoxStyle.Critical, "Error")
        Else
            Sql = "INSERT INTO dbo.Users ([User Name], [First Name], [Last Name], Password, Role, [Fees Due]) " +
                "VALUES ('" + userNameTextBox.Text + "','" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + passwordTextBox.Text + "','" + roleComboBox.SelectedItem + "',0)"
            dbClass.analyzeSQL(dbClass.getConnectionString, Sql, False, "")
            MsgBox("User added", MsgBoxStyle.Information, "Manage User")
        End If
        dbClass.ds.Tables.Item("users").Clear()
        DataGridLoad()

    End Sub

    'Clear Data Grid/Fields
    Private Sub clearGridButton_Click(sender As Object, e As EventArgs) Handles clearGridButton.Click
        Me.userNameTextBox.Clear()
        Me.firstNameTextBox.Clear()
        Me.lastNameTextBox.Clear()
        Me.passwordTextBox.Clear()
        'Me.roleComboBox.Text.()
        Me.feesDueTextBox.Clear()
    End Sub


    'Function to update user information
    Private Sub updateUserButton_Click(sender As Object, e As EventArgs) Handles updateUserButton.Click
        'Get row selected then increment by one to calculate the userID, then update user info
        
        Dim i As Integer
        i = getID

        Dim updateSql = "UPDATE dbo.Users " & _
          "SET [User Name] = '" & userNameTextBox.Text & "', [First Name]='" & firstNameTextBox.Text & "', [Last Name]='" & lastNameTextBox.Text & _
          "', Password='" & passwordTextBox.Text & "', Role='" & roleComboBox.SelectedItem & "', [Fees Due]= '" & feesDueTextBox.Text & "'" & _
          " WHERE [User ID] = " & i
        MsgBox(updateSql)
        dbClass.analyzeSQL(dbClass.getConnectionString, updateSql, False, "")
        MsgBox("User Updated", MsgBoxStyle.Information, "Update User")
        dbClass.ds.Tables.Item("users").Clear()
        DataGridLoad()

    End Sub

    'Delete User Function
    Private Sub deleteUserButton_Click(sender As Object, e As EventArgs) Handles deleteUserButton.Click
        'Get row selected then increment by one to calculate the userID
        Dim i As Integer
        i = getID

        'Deletes user from the database
        Dim deleteUserSQL = "DELETE FROM dbo.Users " & _
            " WHERE [User ID] = " & i & " AND [User Name] = '" & userNameTextBox.Text + "'"
        dbClass.analyzeSQL(dbClass.getConnectionString, deleteUserSQL, False, "")
        dbClass.ds.Tables.Item("users").Clear()

        MsgBox("User deleted", MsgBoxStyle.Information, "Manage User")
        DataGridLoad()

    End Sub

    'Cell Formatting Color
    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If Me.DataGridView1.Columns(e.ColumnIndex).Name = "User ID" Then
            e.CellStyle.BackColor = Color.Gray
        End If
    End Sub
End Class