Imports System.Data.SqlClient
'DBMSClass's class will be used to manage connectivity with the database
Public Class DBMSClass
    Dim ds As New DataSet

    'define the connection string
    Public Function getConnectionString() As String
        Return "Data Source=PIZ-LAP\SQLEXPRESS; Initial Catalog=project1; Integrated Security=True"
    End Function

    Private Sub analyzeSQL(ByVal connectionString As String, ByVal sqlStatement As String, ByVal type As Boolean)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim dataAdapter As New SqlDataAdapter(sqlStatement, connectionString)
            Dim command As SqlCommand = connection.CreateCommand
            Dim transaction As SqlTransaction


            transaction = connection.BeginTransaction("Read")

            command.Connection = connection
            command.Transaction = transaction

            Try

                command.CommandText = sqlStatement
                'type = true means we are reading
                If type = True Then
                    dataAdapter.Fill(ds, "Results")
                    'dataGridView.DataSource = ds
                    'dataGridView.DataMember = "Results"
                Else
                    'else we are inserting/updating/deleting
                    command.ExecuteNonQuery()
                End If
                transaction.Commit()

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    transaction.Rollback()
                Catch ex2 As Exception
                    ' This catch block will handle any errors that may have occurred 
                    ' on the server that would cause the rollback to fail, such as 
                    ' a closed connection.
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try
            End Try

        End Using

    End Sub

End Class
