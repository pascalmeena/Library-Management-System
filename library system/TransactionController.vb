Imports System.Data.SqlClient

Public Class TransactionController
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Private SQLDataset As New DataSet
    Private SQLConnectionString = getConnectionString()

    Private Shared Function getConnectionString() As String
        Return "Data Source=PIZ-LAP\SQLEXPRESS; Initial Catalog=project1; Integrated Security=True"
    End Function

    Public Function getDataSet() As DataSet
        Return SQLDataset
    End Function

    Public Sub ExecuteTransaction(Query As String, TableName As String, Read As Boolean)

        Using connection As New SqlConnection(SQLConnectionString)
            connection.Open()

            'SQLCmd = New SqlCommand(Query, SQLConnectionString)


            'Dim dataAdapter As New SqlDataAdapter(Query, SQLConnectionString)
            'Dim SQLCmd As SqlCommand = connection.CreateCommand
            SQLCmd = New SqlCommand(Query, connection)
            Dim transaction As SqlTransaction

            SQLDA = New SqlDataAdapter(SQLCmd)

            transaction = connection.BeginTransaction("Read")

            SQLCmd.Connection = connection
            SQLCmd.Transaction = transaction

            Try

                'SQLCmd.CommandText = Query
                'SQLDataset = New DataSet

                If Read = True Then
                    SQLDA.Fill(SQLDataset, TableName)
                Else
                    SQLCmd.ExecuteNonQuery()
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
