Public Class CarCategorySelector


    'Declare a variable that cannot be modified - useful for calculations later on
    Const VAT = 0.2

    'Declare our variables to be used later on in the output file
    Private Penalty As Double


    Private Sub CarCategorySelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'On The form loading hide all the panels

        PanelSmall.Visible = False
        PanelMedium.Visible = False
        PanelLarge.Visible = False



        'Assign the penalty variable based on the value of License
        Select Case CInt(customerDataDict("Years license held for:"))

            Case = 0
                Penalty = 0.5

            Case = 1
                Penalty = 0.3

            Case = 2
                Penalty = 0.15

            Case = 3
                Penalty = 0.05
        End Select

    End Sub

    Private Sub SavetoFile()

        If SaveFilePrompt.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim objwriter As New IO.StreamWriter(SaveFilePrompt.FileName)

            For Each pair As KeyValuePair(Of String, Object) In customerDataDict.Cast(Of KeyValuePair(Of String, Object))

                objwriter.WriteLine("{0} {1}", pair.Key, pair.Value)

            Next

            objwriter.Close()

        End If

        MsgBox("File Saved")

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

        AddOrUpdate("Package type:", "Small")

    End Sub

    'When the Medium image is clicked make medium car panel visible and hide other panels
    Private Sub ImgMediumCar_Click(sender As Object, e As EventArgs) Handles ImgMediumCar.Click
        PanelSmall.Visible = False
        PanelMedium.Visible = True
        PanelLarge.Visible = False
        RbtnMedium1.Checked = True

        AddOrUpdate("Package type:", "Medium")

    End Sub

    'When the Large	car image Is clicked make large car panel visible and hide other panels
    Private Sub ImgLargeCar_Click(sender As Object, e As EventArgs) Handles ImgLargeCar.Click
        PanelSmall.Visible = False
        PanelMedium.Visible = False
        PanelLarge.Visible = True
        RbtnLarge1.Checked = True

        AddOrUpdate("Package type:", "Large")

    End Sub

    'instead of repeating the exact same operation over and over i can simply reference it and write it out once
    Private Function TotalPriceCalculator(packageCost As Decimal) As String


        Return FormatCurrency((((packageCost * Penalty) + packageCost) * VAT) + ((packageCost * Penalty) + packageCost))

    End Function


    Private Sub PackageCheck(rBtn1 As RadioButton, rBtn2 As RadioButton, rBtn3 As RadioButton)

        Dim multiplier As Double

        Select Case customerDataDict.Item("Package type:").ToString()

            Case "Small"
                multiplier = 1

            Case "Medium"
                multiplier = 1.33

            Case "Large"
                multiplier = 1.5

        End Select


        Dim oneDayCost As Decimal = CDec(30 * multiplier)
        Dim sevenDayCost As Decimal = CDec(95 * multiplier)
        Dim thirtyDayCost As Decimal = CDec(270 * multiplier)



        Select Case True

            Case rBtn1.Checked = True

                AddOrUpdate("Total price:", TotalPriceCalculator(oneDayCost))
                AddOrUpdate("Package duration:", 1)


            Case rBtn2.Checked = True

                AddOrUpdate("Total price:", TotalPriceCalculator(sevenDayCost))
                AddOrUpdate("Package duration:", 7)

            Case rBtn3.Checked = True

                AddOrUpdate("Total price:", TotalPriceCalculator(thirtyDayCost))
                AddOrUpdate("Package duration:", 30)

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