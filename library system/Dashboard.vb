Public Class Dashboard
    Dim dbClass As New DBMSClass
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim queryString1 = "select distinct [Publisher Country] from dbo.ETLPublisherTable " + " order by [Publisher Country] asc"
        dbClass.analyzeSQL(dbClass.getConnectionString(), queryString1, True, "country")
        For i As Integer = 0 To dbClass.ds.Tables.Item("country").Rows.Count - 1
            countryComboBox.Items.Add(dbClass.ds.Tables.Item("country").Rows(0).Item(0).ToString)
        Next

        Dim queryString2 = "select distinct CurrentTD from dbo.timetable"
        dbClass.analyzeSQL(dbClass.getConnectionString(), queryString2, True, "dateSearch")

        For Value As Integer = 0 To dbClass.ds.Tables.Item("dateSearch").Rows.Count - 1
            Dim tdate As Date = dbClass.ds.Tables.Item("dateSearch").Rows(Value).Item(0)

            yearComboBox.Items.Add(tdate.Date.Year)
            monthComboBox.Items.Add(tdate.Date.Month)
            dayComboBox.Items.Add(tdate.Date.Day)
        Next

        Dim queryString3 = "select distinct genre from dbo.ETLBookTable order by genre asc"
        dbClass.analyzeSQL(dbClass.getConnectionString(), queryString3, True, "genreSearch")
        For Value As Integer = 0 To dbClass.ds.Tables.Item("genreSearch").Rows.Count - 1

            genreComboBox.Items.Add(dbClass.ds.Tables.Item("genreSearch").Rows(Value).Item(0).ToString)
        Next
    End Sub

    'From which category to select from 
    Public Function whichCategory() As String
        Dim supportBox As String = ""
        If countryComboBox.SelectedIndex <> -1 Then
            supportBox += ", dbo.ETLPublisherTable"
        End If
        If yearComboBox.SelectedIndex <> -1 Then
            supportBox += ", dbo.TimeTable"
        End If
        If genreComboBox.SelectedIndex <> -1 Then
            supportBox += ", dbo.ETLBookTable"
        End If

        Return supportBox
    End Function

    Private Sub countryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles countryComboBox.SelectedIndexChanged
        cityComboBox.Items.Clear()
        cityComboBox.Text = "City"

        Dim queryString As String = ""
        queryString = "select distinct [Publisher City] from dbo.ETLPublisherTable where [Publisher Country] = '" _
                        + countryComboBox.Text + "' order by [Publisher City] asc"
        dbClass.analyzeSQL(dbClass.getConnectionString(), queryString, True, "citySearch")

        For Value As Integer = 0 To dbClass.ds.Tables.Item("citySearch").Rows.Count - 1
            cityComboBox.Items.Add(dbClass.ds.Tables.Item("citySearch").Rows(Value).Item(0).ToString)
            'MsgBox(dbClass.ds.Tables.Item("citySearch").Rows(Value).Item(0).ToString)
        Next
    End Sub


    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim queryString As String = ""

        queryString = "select sum(CountOfBorrow) from dbo.facttable"
        queryString += whichCategory()
        If countryComboBox.SelectedIndex <> -1 Then
            queryString += " where (dbo.facttable.[publisherid] = dbo.etlpublishertable.[publisher id]) and (dbo.etlpublishertable.[publisher country] = '" + countryComboBox.Text + "')"
            If cityComboBox.SelectedIndex <> -1 Then
                queryString += " and (dbo.etlpublishertable.[publisher city] = '" + cityComboBox.Text + "')"
            End If

            If yearComboBox.SelectedIndex <> -1 Then
                queryString += " and dbo.facttable.timeid = dbo.timetable.timeid " _
                    + "and (dbo.timetable.currenttd = '" + yearComboBox.Text + "')"
            End If
            If genreComboBox.Text <> "" Then
                queryString += " and dbo.facttable.bookid = etlbooktable.[book id] " _
                    + "and (etlbooktable.genre = '" + genreComboBox.Text + "')"
            End If

            MsgBox(queryString)
            dbClass.analyzeSQL(dbClass.getConnectionString(), queryString, True, "calculate")

            DataGridView1.DataSource = dbClass.ds
            DataGridView1.DataMember = "calculate"
        Else
            MessageBox.Show("Selection too general!", "Error")
            Return
        End If
    End Sub

   
End Class