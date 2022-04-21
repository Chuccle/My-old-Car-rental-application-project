
Imports System.Data.SqlClient
Public Module SQLComponent

    '' Change this to your settings
    Private Property ConnectionString As String = "Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=test;"

    Private ReadOnly parameterList As New List(Of SqlParameter)

    Public Sub Parameterise()

        parameterList.Add(New SqlParameter("@Type", SqlDbType.VarChar, 50) With {
            .Value = CarCategorySelector.PackageType
        })


        parameterList.Add(New SqlParameter("@Length", SqlDbType.Int) With {
            .Value = CarCategorySelector.PackageDuration
        })


        parameterList.Add(New SqlParameter("@Forename", SqlDbType.VarChar, 50) With {
            .Value = CustomerDetailsForm.Forename
        })


        parameterList.Add(New SqlParameter("@Surname", SqlDbType.VarChar, 50) With {
            .Value = CustomerDetailsForm.Surname
        })


        parameterList.Add(New SqlParameter("@Nationality", SqlDbType.VarChar, 50) With {
            .Value = CustomerDetailsForm.Nationality
        })


        parameterList.Add(New SqlParameter("@Age", SqlDbType.Int) With {
            .Value = CustomerDetailsForm.Age
        })


        parameterList.Add(New SqlParameter("@DOB", SqlDbType.VarChar, 8) With {
            .Value = CustomerDetailsForm.DOB
        })


        parameterList.Add(New SqlParameter("@LicenseHeld", SqlDbType.Int) With {
            .Value = CustomerDetailsForm.LicenseHeld
        })


        parameterList.Add(New SqlParameter("@Total", SqlDbType.VarChar, 10) With {
            .Value = Convert.ToString(FormatCurrency(CarCategorySelector.TotalPrice))
        })


    End Sub

    Private Function QueryHelper(adapter As SqlDataAdapter, sqlCnn As SqlConnection) As Integer()

        Dim Sql(1) As String

        Dim id(1) As Integer


        Sql(0) = "SELECT PackageDurationID FROM PackageDuration WHERE DurationDays = @Length"


        Sql(1) = "SELECT PackageTypeID FROM PackageType WHERE Type = @Type"


        For i As Integer = 0 To 1

            Dim ds As New DataSet

            Dim sqlCmd = New SqlCommand(Sql(i), sqlCnn)

            If i = 0 Then

                sqlCmd.Parameters.AddRange(parameterList.GetRange(1, 1).ToArray)

            Else

                sqlCmd.Parameters.AddRange(parameterList.GetRange(0, 1).ToArray)

            End If


            Try

                sqlCnn.Open()

                adapter.SelectCommand = sqlCmd

                adapter.Fill(ds, "results")

                adapter.Dispose()

                sqlCmd.Dispose()

                sqlCnn.Close()


            Catch ex As Exception

                MsgBox("Connection was unsuccessful: " + ex.Message)

            End Try


            id(i) = Convert.ToInt32(ds.Tables("results").Rows(0).Item(0))


        Next

        Return id

    End Function


    Public Sub Query()

        If (parameterList.Count = 0) Then

            MsgBox("error, please run parameterise method before using the Query method")

            Exit Sub


        End If

        Dim adapter As New SqlDataAdapter


        Dim sqlCnn = New SqlConnection(ConnectionString)


        Dim PackageIDs = QueryHelper(adapter, sqlCnn)

        parameterList.Add(New SqlParameter("@PackageDurationID", SqlDbType.Int) With {
            .Value = PackageIDs(0)
        })

        parameterList.Add(New SqlParameter("@PackageTypeID", SqlDbType.Int) With {
            .Value = PackageIDs(1)
        })


        Dim sql As String = "INSERT INTO CustomerInfo(Firstname, LastName, Nationality, Age, DOB, LicenseHeldYears, PackageDurationID, PackageTypeID,TotalFee) Values(@Forename,@Surname,@Nationality, @Age, @DOB, @LicenseHeld, @PackageDurationID, @PackageTypeID, @Total)"

        Dim ds As New DataSet

        Dim sqlCmd = New SqlCommand(sql, sqlCnn)


        Try

            sqlCnn.Open()

            sqlCmd.Parameters.AddRange(parameterList.GetRange(2, 9).ToArray())

            adapter.SelectCommand = sqlCmd

            adapter.Fill(ds)

            adapter.Dispose()

            sqlCmd.Dispose()

            sqlCnn.Close()

            MsgBox("Record inserted succesfully")

        Catch ex As Exception

            MsgBox("Connection was unsuccessful: " + ex.Message)

        End Try


    End Sub

End Module
