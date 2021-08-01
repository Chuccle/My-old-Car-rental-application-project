Imports System.Data.SqlClient

Public Class CarCategorySelector

	'Declare a variable that cannot be modified - useful for calculations later on
	Const VAT = 0.2

	'Declare our variables to be used later on in the output file
	Private Penalty As Decimal

	Private OptionID As String
	Private TotalPrice As Decimal

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

	'Depending on radiobutton selection, will use a calculation from referencing previous variables and returned result is assigned to TotalPrice
	'Option ID is also assigned depending on radiobutton selection
	Private Sub SavetoFile()

		If SaveFilePrompt.ShowDialog = Windows.Forms.DialogResult.OK Then

			Dim i As Integer
			Dim arytext(7) As String

			'We reference the public variables directly from CustomerDetailsForm so we don't have to waste memory space holding the variables in this form
			'We format as currency to automatically assign the prefix of the user's currency and also the amount of decimal places
			arytext(0) = "Customer forename: " + CustomerDetailsForm.Forename
			arytext(1) = "Customer surname: " + CustomerDetailsForm.Surname
			arytext(2) = "Nationality: " + CustomerDetailsForm.Nationality
			arytext(3) = "Age: " + Convert.ToString(CustomerDetailsForm.Age)
			arytext(4) = "Date of birth " + CustomerDetailsForm.DOB
			arytext(5) = "Years license Held for: " + CustomerDetailsForm.LicenseHeld
			arytext(6) = "PackageID: " + OptionID
			arytext(7) = "Total fee: " + Convert.ToString(FormatCurrency(TotalPrice))

			'declare our filename and it's emcoding as a variable
			Dim objwriter As New IO.StreamWriter(SaveFilePrompt.FileName)

			For i = 0 To 7
				'writes every item in the array on a separate line
				objwriter.WriteLine(arytext(i))

			Next

			objwriter.Close()
		Else
			MsgBox("Please select the package again")

		End If

		Application.Exit()

	End Sub

	Private Sub savetoDB2()

		Dim style = MsgBoxStyle.YesNo
		Dim response = MsgBox("Would you like to save this file to the local SQL database?", style)
		If response = vbNo Then
			Exit Sub
		End If

		Dim connectionString As String
		Dim sqlCnn As SqlConnection
		Dim sqlCmd As SqlCommand
		Dim adapter As New SqlDataAdapter
		Dim ds As New DataSet
		''		Dim i As Integer
		Dim sql As String
		Dim Forename As String = CustomerDetailsForm.Forename
		Dim Lastname As String = CustomerDetailsForm.Surname
		Dim Nationality As String = CustomerDetailsForm.Nationality
		Dim Age As String = Convert.ToString(CustomerDetailsForm.Age)
		Dim DOB As String = CustomerDetailsForm.DOB
		Dim LicenseHeld As String = CustomerDetailsForm.LicenseHeld
		Dim Total As String = Convert.ToString(FormatCurrency(TotalPrice))

		connectionString = "Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=master;"
		sql = "Insert into CustomerInfo(Forename, LastName, Nationality, Age, DOB, LicenseYears, OptionID, TotalFee) Values('" + Forename + "','" + Lastname + "','" + Nationality + "','" + Age + "','" + DOB + "','" + LicenseHeld + "','" + OptionID + "','" + Total + "')"

		sqlCnn = New SqlConnection(connectionString)
		Try
			sqlCnn.Open()
			sqlCmd = New SqlCommand(sql, sqlCnn)
			adapter.SelectCommand = sqlCmd
			adapter.Fill(ds)
			''	For i = 0 To ds.Tables(0).Rows.Count - 1
			''MsgBox(ds.Tables(0).Rows(i).Item(0) & "  --  " & ds.Tables(0).Rows(i).Item(1))
			''	Next
			adapter.Dispose()
			sqlCmd.Dispose()
			sqlCnn.Close()
		Catch ex As Exception
			MsgBox("Connection was unsuccessful: " + ex.Message)
		End Try
	End Sub

	'When the small car image is clicked make small car panel visible and hide other panels
	Private Sub ImgSmallCar_Click(sender As Object, e As EventArgs) Handles ImgSmallCar.Click
		PanelSmall.Visible = True
		PanelMedium.Visible = False
		PanelLarge.Visible = False

	End Sub

	'When the Medium image is clicked make medium car panel visible and hide other panels
	Private Sub ImgMediumCar_Click(sender As Object, e As EventArgs) Handles ImgMediumCar.Click
		PanelSmall.Visible = False
		PanelMedium.Visible = True
		PanelLarge.Visible = False

	End Sub

	'When the Large	car image Is clicked make large car panel visible and hide other panels
	Private Sub ImgLargeCar_Click(sender As Object, e As EventArgs) Handles ImgLargeCar.Click
		PanelSmall.Visible = False
		PanelMedium.Visible = False
		PanelLarge.Visible = True

	End Sub

	'instead of repeating the exact same operation over and over i can simply reference it and write it out once
	Private Function TotalPriceCalculator(ByVal package As Integer) As Decimal
		Dim total As Decimal
		total = (((package * Penalty) + package) * VAT) + ((package * Penalty) + package)
		Return total

	End Function

	'Declares package integers and assigns them with respective values
	Private Sub BtnConfirmSmall_Click(sender As Object, e As EventArgs) Handles BtnConfirmSmall.Click
		Dim Small1Value As Integer = 30
		Dim Small7Value As Integer = 95
		Dim Small30Value As Integer = 270

		'Depending on radiobutton selection, will use a calculation from referencing previous variables and returned result is assigned to TotalPrice
		'Option ID is also assigned depending on radiobutton selection

		Select Case True

			Case RbtnSmall1.Checked = True
				TotalPrice = TotalPriceCalculator(Small1Value)
				OptionID = "Small1"

			Case RbtnSmall7.Checked = True
				TotalPrice = TotalPriceCalculator(Small7Value)
				OptionID = "Small7"

			Case RbtnSmall30.Checked = True
				TotalPrice = TotalPriceCalculator(Small30Value)
				OptionID = "Small30"

		End Select

		savetoDB2()

		SavetoFile()

	End Sub

	'Declares package integers and assigns them with respective values
	Private Sub BtnConfirmMedium_Click(sender As Object, e As EventArgs) Handles BtnConfirmMedium.Click
		Dim Medium1Value As Integer = 40
		Dim Medium7Value As Integer = 115
		Dim Medium30Value As Integer = 310

		Select Case True

			Case RbtnMedium1.Checked = True
				TotalPrice = TotalPriceCalculator(Medium1Value)
				OptionID = "Medium1"

			Case RbtnMedium7.Checked = True
				TotalPrice = TotalPriceCalculator(Medium7Value)
				OptionID = "Medium7"

			Case RbtnMedium30.Checked = True
				TotalPrice = TotalPriceCalculator(Medium30Value)
				OptionID = "Medium30"

		End Select
		savetoDB2()

		SavetoFile()

	End Sub

	'Declares package integers and assigns them with respective values
	Private Sub BtnConfirmLarge_Click(sender As Object, e As EventArgs) Handles BtnConfirmLarge.Click
		Dim Large1Value As Integer = 45
		Dim Large7Value As Integer = 130
		Dim Large30Value As Integer = 340

		Select Case True

			Case RbtnLarge1.Checked = True
				TotalPrice = TotalPriceCalculator(Large1Value)
				OptionID = "Large1"

			Case RbtnLarge7.Checked = True
				TotalPrice = TotalPriceCalculator(Large7Value)
				OptionID = "Large7"

			Case RbtnLarge30.Checked = True
				TotalPrice = TotalPriceCalculator(Large30Value)
				OptionID = "Large30"

		End Select

		savetoDB2()

		SavetoFile()

	End Sub

	'Hides current form and makes other form visible
	Private Sub BtnGoBack_Click(sender As Object, e As EventArgs) Handles BtnGoBack.Click
		Me.Visible = False
		CustomerDetailsForm.Visible = True
	End Sub

	Private Sub exportToAccessMedium_Click(sender As Object, e As EventArgs) Handles exportToAccessMedium.Click

	End Sub

	Private Sub exportToAccessLarge_Click(sender As Object, e As EventArgs) Handles exportToAccessLarge.Click

	End Sub

End Class