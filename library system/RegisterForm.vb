Imports System.Data.SqlClient

Public Class RegisterForm
    Dim dbClass As New DBMSClass
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'passwordTextBox.PasswordChar = "*"

    End Sub


    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        If userNameTextBox.Text = "" Or firstNameTextBox.Text = "" Or lastNameTextBox.Text = "" Or passwordTextBox.Text = "" Then
            MsgBox("Please fill all the information", MsgBoxStyle.Critical, "Error")
            Return
        End If
        'insert data into the database, check if user exists otherwise add them
        Dim Sql = "SELECT * FROM dbo.Users where [User Name] = '" + userNameTextBox.Text + "', and [First Name] = '" + firstNameTextBox.Text + "' and [Last Name] = '" + lastNameTextBox.Text + "'"
        dbClass.analyzeSQL(dbClass.getConnectionString(), Sql, True, "Results")
        'Dim transClass As New TransactionController
        'transClass.ExecuteTransaction(Sql, "Results", True)
        If dbClass.ds.Tables.Item("Results").Rows.Count > 0 Then
            MsgBox("User already exists")
        Else

            Sql = "INSERT INTO dbo.Users ([User Name], [First Name], [Last Name], Password, Role, [Fees Due]) " +
                "VALUES ('" + userNameTextBox.Text + "','" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + passwordTextBox.Text + "','Student',0)"
            dbClass.analyzeSQL(dbClass.getConnectionString, Sql, False, "")
            MsgBox("You are registered", MsgBoxStyle.Information, "Registered")
        End If

    End Sub

    Private Sub cancelButton2_Click(sender As Object, e As EventArgs) Handles cancelButton2.Click
        Me.Close()
    End Sub

End Class