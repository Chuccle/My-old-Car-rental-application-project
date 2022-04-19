Public Class ValidationComponent


    Public Function ValidateName(TxtName As TextBox) As Boolean

        Select Case (True)

            Case Len(TxtName.Text) = 0
                MsgBox("Please fill in the highlighted field", MsgBoxStyle.OkOnly)
                TxtName.Focus()
                Return False

                'if the TxtForename.Text has over 25 characters in it, exit sequence

            Case Len(TxtName.Text) > 25
                MsgBox("Please input a name less than 25 characters", MsgBoxStyle.OkOnly)
                TxtName.Focus()
                Return False

        End Select

        Return True

    End Function

    Public Function ValidateDOB(TxtDOB As MaskedTextBox) As Boolean

        Select Case (True)

            Case Len(TxtDOB.Text) = 2
                MsgBox("Please enter a value in the highlighted field")
                TxtDOB.Focus()
                Return False

                'also if txtDob.Text has less than 10 characters, display custom msgbox and exit sequence + highlights corresponding field

            Case Len(TxtDOB.Text) < 10
                MsgBox("You have entered an invalid or incorrectly formatted date.")
                TxtDOB.Focus()
                Return False

                'Also if txtDob.Text doesn't represent a valid date value or the "/" characters are in the incorrect places
                'Display custom msgbox and exit sequence + highlights corresponding field

            Case IsDate(TxtDOB.Text) = False Or TxtDOB.Text(2) <> "/" Or TxtDOB.Text(5) <> "/"
                MsgBox("You have entered an invalid or incorrectly formatted date.")
                TxtDOB.Focus()
                Return False

                'If TxtDOB.Text exceeds current date or TxtDOB.Text less than the date "01/01/1900"
                'Display custom msgbox and exit sequence + highlights corresponding field

            Case Date.Parse(TxtDOB.Text) > Now.Date Or Date.Parse(TxtDOB.Text) < Date.Parse("01/01/1900")
                MsgBox("The date you have entered is outside the acceptable range.")
                TxtDOB.Focus()
                Return False

        End Select

        Return True

    End Function

    Public Function ValidateCombobox(ComboBox As ComboBox) As Boolean


        'If no value is selected from CboxNationality, create custom message box and stop current sequence

        If ComboBox.SelectedItem Is Nothing Then
            MsgBox("Please fill in the highlighted field", MsgBoxStyle.OkOnly)
            ComboBox.Focus()
            Return False

        End If

        Return True

    End Function


End Class
