Public Class CustomerDetailsForm

    'we declared these variables as puclic to allow them to be referenced by another form class
    Public DOB As String
    Public LicenseHeld As String
    Public Forename As String
    Public Surname As String
    Public Age As Integer
    Public Nationality As String



    'Extracts year part from dob and uses today's date to run subtraction operation which calculates age, if d.o.b exceeds today's date will give negative values
    Private Function GetCurrentAge(ByVal dob As Date) As Integer
        Dim age As Integer
        age = Today.Year - dob.Year
        If (dob > Today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Private Sub BtnSubmitDetails_Click(sender As Object, e As EventArgs) Handles BtnSubmitDetails.Click

        'Variables which dictate the appearance of the msgbox, we also reference all the previously entered values to be outputted on the msgbox

        Dim msg = "You inputted:" + vbCrLf + vbCrLf + TxtForename.Text _
            + " " + TxtSurname.Text + vbCrLf + TxtDOB.Text + vbCrLf +
            CboxNationality.SelectedItem + vbCrLf + CboxLicenseHeld.SelectedItem _
            + vbCrLf + vbCrLf + "Is this correct?"

        Dim title = "Please review the inputted data"
        Dim style = MsgBoxStyle.YesNo
        Dim response = MsgBox(msg, style, title)

        'if user picks no then the subprocedure exits
        If response = vbNo Then
            Exit Sub

        End If


        Select Case True

               'if the txtDOB.Text has no characters in it, exit sequence

            Case Len(TxtDOB.Text) = 2
                MsgBox("Please enter a value in the highlighted field")
                TxtDOB.Focus()
                Exit Sub

                'also if txtDob.Text has less than 10 characters, display custom msgbox and exit sequence + highlights corresponding field

            Case Len(TxtDOB.Text) < 10
                MsgBox("You have entered an invalid or incorrectly formatted date.")
                TxtDOB.Focus()
                Exit Sub

                'Also if txtDob.Text doesn't represent a valid date value or the "/" characters are in the incorrect places
                'Display custom msgbox and exit sequence + highlights corresponding field

            Case IsDate(TxtDOB.Text) = False Or TxtDOB.Text(2) <> "/" Or TxtDOB.Text(5) <> "/"
                MsgBox("You have entered an invalid or incorrectly formatted date.")
                TxtDOB.Focus()
                Exit Sub

                'If TxtDOB.Text exceeds current date or TxtDOB.Text less than the date "01/01/1900"
                'Display custom msgbox and exit sequence + highlights corresponding field

            Case Date.Parse(TxtDOB.Text) > Now.Date Or Date.Parse(TxtDOB.Text) < Date.Parse("01/01/1900")
                MsgBox("The date you have entered is outside the acceptable range.")
                TxtDOB.Focus()
                Exit Sub

                'if the TxtForename.Text has no characters in it, exit sequence

            Case Len(TxtForename.Text) = 0
                MsgBox("Please fill in the highlighted field", MsgBoxStyle.OkOnly)
                TxtForename.Focus()
                Exit Sub

                'if the TxtForename.Text has over 25 characters in it, exit sequence

            Case Len(TxtForename.Text) > 25
                MsgBox("Please input a name less than 25 characters", MsgBoxStyle.OkOnly)
                TxtForename.Focus()
                Exit Sub

                 'if the TxtSurname.Text has no characters in it, exit sequence

            Case Len(TxtSurname.Text) = 0
                MsgBox("Please fill in the highlighted field", MsgBoxStyle.OkOnly)
                TxtSurname.Focus()
                Exit Sub

                'if the TxtSurname.Text has over 25 characters in it, exit sequence

            Case Len(TxtSurname.Text) > 25
                MsgBox("Please input a name less than 25 characters", MsgBoxStyle.OkOnly)
                TxtSurname.Focus()
                Exit Sub

                'If no value is selected from CboxNationality, create custom message box and stop current sequence

            Case CboxNationality.SelectedItem Is Nothing
                MsgBox("Please fill in the highlighted field", MsgBoxStyle.OkOnly)
                CboxNationality.Focus()
                Exit Sub

                'If no value is selected from CboxLicenseHeld, create custom message box and stop current sequence

            Case CboxLicenseHeld.SelectedItem Is Nothing
                MsgBox("Please fill in the highlighted field", MsgBoxStyle.OkOnly)
                CboxLicenseHeld.Focus()
                Exit Sub

        End Select


        'assigns public variables values for use in next form
        Age = GetCurrentAge(TxtDOB.Text)
        Nationality = CboxNationality.SelectedItem
        Forename = TxtForename.Text
        Surname = TxtSurname.Text
        DOB = TxtDOB.Text
        LicenseHeld = (CboxLicenseHeld.SelectedItem)


        'Logic case tree - different outcomes will occur depending on what value UserAge, outcomes determined by conditions for each case
        If response = MsgBoxResult.No Then

            Exit Sub


            'If Age in range between 23 and 0 then create custom messagebox and restart application
        ElseIf Age < 24 Then
            MsgBox("Age is below 24, Please review the highlighted field", MsgBoxStyle.OkOnly)
            TxtDOB.Focus()
            Exit Sub
        End If




        'transitions this form into second one
        Me.Visible = False
        CarCategorySelector.Visible = True


    End Sub

    'Will restrict input to strictly letters and a backspace
    Private Sub TxtForename_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtForename.KeyPress
        e.Handled = True



        If e.KeyChar Like "[A-z]" Or e.KeyChar = Chr(&H8) Then e.Handled = False


    End Sub

    'Will restrict input to strictly letters and a backspace
    Private Sub TxtSurname_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSurname.KeyPress
        e.Handled = True



        If e.KeyChar Like "[A-z]" Or e.KeyChar = Chr(&H8) Then e.Handled = False
    End Sub

    'Will restrict input to strictly letters and a backspace
    Private Sub TxtDOB_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True



        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(&H8) Or e.KeyChar = "/" Then e.Handled = False

    End Sub


    Private Sub AutoCapitalize(textbox As TextBox)
        Dim startPos As Integer
        Dim selectionLength As Integer

        ' store the cursor position and selection length prior to changing the text
        startPos = textbox.SelectionStart
        selectionLength = textbox.SelectionLength

        'make the neccesary changes
        If textbox.TextLength > 1 Then
            textbox.Text = textbox.Text.Substring(0, 1).ToUpper() + textbox.Text.Substring(1).ToLower()
        ElseIf textbox.TextLength = 1 Then
            textbox.Text = textbox.Text.ToUpper()
        End If

        'restore the cursor position and text selection
        textbox.SelectionStart = startPos
        textbox.SelectionLength = selectionLength
        textbox.SelectionLength = selectionLength

    End Sub






    Private Sub TxtForename_TextChanged(sender As Object, e As EventArgs) Handles TxtForename.TextChanged


        AutoCapitalize(TxtForename)



    End Sub


    Private Sub TxtSurname_TextChanged(sender As Object, e As EventArgs) Handles TxtSurname.TextChanged


        AutoCapitalize(TxtSurname)


    End Sub

    Private Sub CustomerDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

