Module CustomerDict

    'Dictionary of all the needed data
    Public customerDataDict As IDictionary = New Dictionary(Of String, Object)


    'Allows us to have overwriteable key values 

    Public Sub AddOrUpdate(Key As String, Value As Object)


        If customerDataDict.Contains(Key) Then

            customerDataDict(Key) = Value

        Else

            customerDataDict.Add(Key, Value)

        End If


    End Sub


End Module
