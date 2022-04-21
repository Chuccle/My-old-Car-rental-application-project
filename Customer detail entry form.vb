Public Class CustomerDetailsForm

    'we declared these variables as puclic to allow them to be referenced by other classes
    Public DOB As String
    Public LicenseHeld As String
    Public Forename As String
    Public Surname As String
    Public Age As Integer
    Public Nationality As String
    Public PackageType As String
    Public PackageDuration As Integer
    Public TotalPrice As String


    'Extracts year part from dob and uses today's date to run subtraction operation which calculates age, if d.o.b exceeds today's date will give negative values
    Private Function GetCurrentAge(dob As Date) As Integer

        Dim age As Integer = Today.Year - dob.Year

        If (dob > Today.AddYears(-age)) Then age -= 1

        Return age

    End Function

    Private Sub BtnSubmitDetails_Click(sender As Object, e As EventArgs) Handles BtnSubmitDetails.Click

        If Not ValidateName(TxtForename) Then Exit Sub


        If Not ValidateName(TxtSurname) Then Exit Sub


        If Not ValidateDOB(TxtDOB) Then Exit Sub


        If Not ValidateCombobox(CboxLicenseHeld) Then Exit Sub


        If Not ValidateCombobox(CboxNationality) Then Exit Sub

        'assigns public variables values for use in next form
        Age = GetCurrentAge(Convert.ToDateTime(TxtDOB.Text))
        Nationality = CboxNationality.SelectedItem.ToString()
        Forename = TxtForename.Text
        Surname = TxtSurname.Text
        DOB = TxtDOB.Text
        LicenseHeld = CboxLicenseHeld.SelectedItem.ToString()

        Dim msg = "You inputted:" + vbCrLf + vbCrLf + TxtForename.Text _
            + " " + TxtSurname.Text + vbCrLf + TxtDOB.Text + vbCrLf +
            CboxNationality.SelectedItem.ToString() + vbCrLf + CboxLicenseHeld.SelectedItem.ToString() _
            + vbCrLf + vbCrLf + "Is this correct?"

        Dim title = "Please review the inputted data"

        Dim style = MsgBoxStyle.YesNo

        Dim response = MsgBox(msg, style, title)

        If response = MsgBoxResult.No Then

            Exit Sub

            'If Age in range between 23 and 0 then create custom messagebox and restart application
        ElseIf Age < 24 Then

            MsgBox("Age is below 24, Please review the highlighted field", MsgBoxStyle.OkOnly)

            TxtDOB.Focus()

            Exit Sub

        End If

        'transitions this form into second one

        Visible = False

        CarCategorySelector.Visible = True

    End Sub

    'Will restrict input to strictly letters and a backspace
    Private Sub TxtForename_Keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtForename.KeyPress

        e.Handled = True

        If e.KeyChar Like "[A-z]" Or e.KeyChar = Chr(&H8) Then e.Handled = False

    End Sub

    'Will restrict input to strictly letters and a backspace
    Private Sub TxtSurname_Keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtSurname.KeyPress

        e.Handled = True

        If e.KeyChar Like "[A-z]" Or e.KeyChar = Chr(&H8) Then e.Handled = False

    End Sub

    'Will restrict input to strictly letters and a backspace
    Private Sub TxtDOB_Keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs)

        e.Handled = True

        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(&H8) Then e.Handled = False

    End Sub

    Private Sub AutoCapitalize(textbox As TextBox)

        'store the cursor position and selection length prior to changing the text
        Dim startPos As Integer = textbox.SelectionStart
        Dim selectionLength As Integer = textbox.SelectionLength

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


End Class