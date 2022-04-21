Public Class CarCategorySelector

    'Declare a variable that cannot be modified - useful for calculations later on
    Const VAT = 0.2

    'Declare our variables to be used later on in the output file
    Private Penalty As Double


    Public PackageDuration As Integer

    Public PackageType As String

    Public TotalPrice As Double

    Private Sub CarCategorySelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'On The form loading hide all the panels

        PanelSmall.Visible = False
        PanelMedium.Visible = False
        PanelLarge.Visible = False

        'Assign the penalty variable based on the value of License
        Select Case CustomerDetailsForm.LicenseHeld

            Case = "0"
                Penalty = 0.5

            Case = "1"
                Penalty = 0.3

            Case = "2"
                Penalty = 0.15

            Case = "3"
                Penalty = 0.05

        End Select

    End Sub

    Private Sub SavetoFile()




        If SaveFilePrompt.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim i As Integer
            Dim arytext(8) As String


            'We reference the public variables directly from CustomerDetailsForm so we don't have to waste memory space holding the variables in this form
            'We format as currency to automatically assign the prefix of the user's currency and also the amount of decimal places



            arytext(0) = "Customer forename: " + CustomerDetailsForm.Forename
            arytext(1) = "Customer surname: " + CustomerDetailsForm.Surname
            arytext(2) = "Nationality: " + CustomerDetailsForm.Nationality
            arytext(3) = "Age: " + Convert.ToString(CustomerDetailsForm.Age)
            arytext(4) = "Date of birth " + CustomerDetailsForm.DOB
            arytext(5) = "Years license Held for: " + CustomerDetailsForm.LicenseHeld
            arytext(6) = "Package Duration: " + PackageDuration.ToString()
            arytext(7) = "Package Type: " + PackageType
            arytext(8) = "Total fee: " + Convert.ToString(FormatCurrency(TotalPrice))

            'declare our filename and it's emcoding as a variable
            Dim objwriter As New IO.StreamWriter(SaveFilePrompt.FileName)

            For i = 0 To 8
                'writes every item in the array on a separate line
                objwriter.WriteLine(arytext(i))

            Next

            objwriter.Close()


        End If

        MsgBox("Please select the package again")

        Application.Exit()

    End Sub

    Private Sub SavetoDB()

        Dim style = MsgBoxStyle.YesNo

        Dim response = MsgBox("Would you like to save this file to the local SQL database?", style)

        If response = vbNo Then
            Exit Sub
        End If

        'Add all our values from this class and the previous class for our query'
        Parameterise()

        'perform query operation'
        Query()

        Exit Sub


    End Sub
    'When the small car image is clicked make small car panel visible and hide other panels
    Private Sub ImgSmallCar_Click(sender As Object, e As EventArgs) Handles ImgSmallCar.Click
        PanelSmall.Visible = True
        PanelMedium.Visible = False
        PanelLarge.Visible = False
        RbtnSmall1.Checked = True
        PackageType = "Small"
    End Sub

    'When the Medium image is clicked make medium car panel visible and hide other panels
    Private Sub ImgMediumCar_Click(sender As Object, e As EventArgs) Handles ImgMediumCar.Click
        PanelSmall.Visible = False
        PanelMedium.Visible = True
        PanelLarge.Visible = False
        RbtnMedium1.Checked = True
        PackageType = "Medium"
    End Sub

    'When the Large	car image Is clicked make large car panel visible and hide other panels
    Private Sub ImgLargeCar_Click(sender As Object, e As EventArgs) Handles ImgLargeCar.Click
        PanelSmall.Visible = False
        PanelMedium.Visible = False
        PanelLarge.Visible = True
        RbtnLarge1.Checked = True
        PackageType = "Large"
    End Sub

    'instead of repeating the exact same operation over and over i can simply reference it and write it out once
    Private Function TotalPriceCalculator(package As Double) As Double

        Return (((package * Penalty) + package) * VAT) + ((package * Penalty) + package)

    End Function


    Private Sub PackageCheck(rBtn1 As RadioButton, rBtn2 As RadioButton, rBtn3 As RadioButton)

        Dim multiplier As Double


        Select Case PackageType

            Case "Small"
                multiplier = 1

            Case "Medium"
                multiplier = 1.33

            Case "Large"
                multiplier = 1.5

        End Select



        Dim oneDayCost As Double = 30 * multiplier
        Dim sevenDayCost As Double = 95 * multiplier
        Dim thirtyDayCost As Double = 270 * multiplier

        'Depending on radiobutton selection, will use a calculation from referencing previous variables and returned result is assigned to TotalPrice
        'Option ID is also assigned depending on radiobutton selection


        Select Case True

            Case rBtn1.Checked = True
                TotalPrice = TotalPriceCalculator(oneDayCost)
                PackageDuration = 1

            Case rBtn2.Checked = True
                TotalPrice = TotalPriceCalculator(sevenDayCost)
                PackageDuration = 7

            Case rBtn3.Checked = True
                TotalPrice = TotalPriceCalculator(thirtyDayCost)
                PackageDuration = 30

        End Select


    End Sub


    Private Sub BtnConfirmSmall_Click(sender As Object, e As EventArgs) Handles BtnConfirmSmall.Click

        PackageCheck(RbtnSmall1, RbtnMedium7, RbtnMedium30)
        SavetoFile()

    End Sub


    Private Sub BtnConfirmMedium_Click(sender As Object, e As EventArgs) Handles BtnConfirmMedium.Click

        PackageCheck(RbtnMedium1, RbtnMedium7, RbtnMedium30)
        SavetoFile()

    End Sub


    Private Sub BtnConfirmLarge_Click(sender As Object, e As EventArgs) Handles BtnConfirmLarge.Click


        PackageCheck(RbtnLarge1, RbtnLarge7, RbtnLarge30)
        SavetoFile()

    End Sub


    Private Sub ExportToDBSmall_Click(sender As Object, e As EventArgs) Handles exportToDBSmall.Click

        PackageCheck(RbtnSmall1, RbtnSmall7, RbtnSmall30)
        SavetoDB()

    End Sub

    Private Sub ExportToDBMedium_Click(sender As Object, e As EventArgs) Handles exportToDBMedium.Click

        PackageCheck(RbtnMedium1, RbtnMedium7, RbtnMedium30)
        SavetoDB()

    End Sub

    Private Sub ExportToDBLarge_Click(sender As Object, e As EventArgs) Handles exportToDBLarge.Click

        PackageCheck(RbtnLarge1, RbtnLarge7, RbtnLarge30)
        SavetoDB()

    End Sub

    Private Sub BtnGoBack_Click(sender As Object, e As EventArgs) Handles BtnGoBack.Click

        Visible = False
        CustomerDetailsForm.Visible = True

    End Sub

End Class