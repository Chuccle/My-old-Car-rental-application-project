<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerDetailsForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.LblCustomerDetails = New System.Windows.Forms.Label()
		Me.TxtForename = New System.Windows.Forms.TextBox()
		Me.LblForename = New System.Windows.Forms.Label()
		Me.LblDOB = New System.Windows.Forms.Label()
		Me.LblNationality = New System.Windows.Forms.Label()
		Me.LblLicenseHeld = New System.Windows.Forms.Label()
		Me.BtnSubmitDetails = New System.Windows.Forms.Button()
		Me.LblMinimumAge = New System.Windows.Forms.Label()
		Me.CboxNationality = New System.Windows.Forms.ComboBox()
		Me.CboxLicenseHeld = New System.Windows.Forms.ComboBox()
		Me.TxtSurname = New System.Windows.Forms.TextBox()
		Me.lblSurname = New System.Windows.Forms.Label()
		Me.TxtDOB = New System.Windows.Forms.MaskedTextBox()
		Me.SuspendLayout()
		'
		'LblCustomerDetails
		'
		Me.LblCustomerDetails.AutoSize = True
		Me.LblCustomerDetails.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblCustomerDetails.Location = New System.Drawing.Point(2, 9)
		Me.LblCustomerDetails.Name = "LblCustomerDetails"
		Me.LblCustomerDetails.Size = New System.Drawing.Size(289, 19)
		Me.LblCustomerDetails.TabIndex = 0
		Me.LblCustomerDetails.Text = "Please enter customer details below:"
		'
		'TxtForename
		'
		Me.TxtForename.Location = New System.Drawing.Point(7, 48)
		Me.TxtForename.MaxLength = 25
		Me.TxtForename.Name = "TxtForename"
		Me.TxtForename.Size = New System.Drawing.Size(71, 20)
		Me.TxtForename.TabIndex = 1
		'
		'LblForename
		'
		Me.LblForename.AutoSize = True
		Me.LblForename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblForename.Location = New System.Drawing.Point(117, 49)
		Me.LblForename.Name = "LblForename"
		Me.LblForename.Size = New System.Drawing.Size(130, 16)
		Me.LblForename.TabIndex = 6
		Me.LblForename.Text = "Customer Forename"
		'
		'LblDOB
		'
		Me.LblDOB.AutoSize = True
		Me.LblDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblDOB.Location = New System.Drawing.Point(117, 141)
		Me.LblDOB.Name = "LblDOB"
		Me.LblDOB.Size = New System.Drawing.Size(128, 16)
		Me.LblDOB.TabIndex = 7
		Me.LblDOB.Text = "D.O.B (dd/mm/yyyy)"
		'
		'LblNationality
		'
		Me.LblNationality.AutoSize = True
		Me.LblNationality.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblNationality.Location = New System.Drawing.Point(117, 187)
		Me.LblNationality.Name = "LblNationality"
		Me.LblNationality.Size = New System.Drawing.Size(71, 16)
		Me.LblNationality.TabIndex = 8
		Me.LblNationality.Text = "Nationality"
		'
		'LblLicenseHeld
		'
		Me.LblLicenseHeld.AutoSize = True
		Me.LblLicenseHeld.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblLicenseHeld.Location = New System.Drawing.Point(117, 226)
		Me.LblLicenseHeld.Name = "LblLicenseHeld"
		Me.LblLicenseHeld.Size = New System.Drawing.Size(147, 16)
		Me.LblLicenseHeld.TabIndex = 9
		Me.LblLicenseHeld.Text = "License held for (years)"
		'
		'BtnSubmitDetails
		'
		Me.BtnSubmitDetails.Location = New System.Drawing.Point(203, 275)
		Me.BtnSubmitDetails.Name = "BtnSubmitDetails"
		Me.BtnSubmitDetails.Size = New System.Drawing.Size(75, 23)
		Me.BtnSubmitDetails.TabIndex = 6
		Me.BtnSubmitDetails.Text = "Submit"
		Me.BtnSubmitDetails.UseVisualStyleBackColor = True
		'
		'LblMinimumAge
		'
		Me.LblMinimumAge.AutoSize = True
		Me.LblMinimumAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblMinimumAge.Location = New System.Drawing.Point(3, 275)
		Me.LblMinimumAge.Name = "LblMinimumAge"
		Me.LblMinimumAge.Size = New System.Drawing.Size(165, 16)
		Me.LblMinimumAge.TabIndex = 0
		Me.LblMinimumAge.Text = "Customer must be over 24 "
		'
		'CboxNationality
		'
		Me.CboxNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CboxNationality.FormattingEnabled = True
		Me.CboxNationality.Items.AddRange(New Object() {"British", "Irish", "Scottish", "Welsh"})
		Me.CboxNationality.Location = New System.Drawing.Point(7, 182)
		Me.CboxNationality.Name = "CboxNationality"
		Me.CboxNationality.Size = New System.Drawing.Size(71, 21)
		Me.CboxNationality.TabIndex = 4
		'
		'CboxLicenseHeld
		'
		Me.CboxLicenseHeld.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CboxLicenseHeld.FormattingEnabled = True
		Me.CboxLicenseHeld.Items.AddRange(New Object() {"0", "1", "2", "3", "More"})
		Me.CboxLicenseHeld.Location = New System.Drawing.Point(6, 225)
		Me.CboxLicenseHeld.Name = "CboxLicenseHeld"
		Me.CboxLicenseHeld.Size = New System.Drawing.Size(72, 21)
		Me.CboxLicenseHeld.TabIndex = 5
		'
		'TxtSurname
		'
		Me.TxtSurname.Location = New System.Drawing.Point(7, 89)
		Me.TxtSurname.MaxLength = 15
		Me.TxtSurname.Name = "TxtSurname"
		Me.TxtSurname.Size = New System.Drawing.Size(71, 20)
		Me.TxtSurname.TabIndex = 2
		'
		'lblSurname
		'
		Me.lblSurname.AutoSize = True
		Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSurname.Location = New System.Drawing.Point(117, 90)
		Me.lblSurname.Name = "lblSurname"
		Me.lblSurname.Size = New System.Drawing.Size(122, 16)
		Me.lblSurname.TabIndex = 15
		Me.lblSurname.Text = "Customer Surname"
		'
		'TxtDOB
		'
		Me.TxtDOB.AsciiOnly = True
		Me.TxtDOB.HidePromptOnLeave = True
		Me.TxtDOB.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
		Me.TxtDOB.Location = New System.Drawing.Point(7, 140)
		Me.TxtDOB.Mask = "00/00/0000"
		Me.TxtDOB.Name = "TxtDOB"
		Me.TxtDOB.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
		Me.TxtDOB.RejectInputOnFirstFailure = True
		Me.TxtDOB.Size = New System.Drawing.Size(71, 20)
		Me.TxtDOB.TabIndex = 3
		Me.TxtDOB.ValidatingType = GetType(Date)
		'
		'CustomerDetailsForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(290, 311)
		Me.Controls.Add(Me.TxtDOB)
		Me.Controls.Add(Me.lblSurname)
		Me.Controls.Add(Me.TxtSurname)
		Me.Controls.Add(Me.CboxLicenseHeld)
		Me.Controls.Add(Me.CboxNationality)
		Me.Controls.Add(Me.LblMinimumAge)
		Me.Controls.Add(Me.BtnSubmitDetails)
		Me.Controls.Add(Me.LblLicenseHeld)
		Me.Controls.Add(Me.LblNationality)
		Me.Controls.Add(Me.LblDOB)
		Me.Controls.Add(Me.LblForename)
		Me.Controls.Add(Me.TxtForename)
		Me.Controls.Add(Me.LblCustomerDetails)
		Me.Name = "CustomerDetailsForm"
		Me.Text = "Customer Details Form"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LblCustomerDetails As Label
	Friend WithEvents TxtForename As TextBox
	Friend WithEvents LblForename As Label
	Friend WithEvents LblDOB As Label
	Friend WithEvents LblNationality As Label
	Friend WithEvents LblLicenseHeld As Label
	Friend WithEvents BtnSubmitDetails As Button
	Friend WithEvents LblMinimumAge As Label
	Friend WithEvents CboxNationality As ComboBox
	Friend WithEvents CboxLicenseHeld As ComboBox
	Friend WithEvents TxtSurname As TextBox
	Friend WithEvents lblSurname As Label
	Friend WithEvents TxtDOB As MaskedTextBox
End Class
