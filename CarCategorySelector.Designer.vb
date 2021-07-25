<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarCategorySelector
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CarCategorySelector))
		Me.ImgSmallCar = New System.Windows.Forms.PictureBox()
		Me.ImgMediumCar = New System.Windows.Forms.PictureBox()
		Me.ImgLargeCar = New System.Windows.Forms.PictureBox()
		Me.PanelSmall = New System.Windows.Forms.Panel()
		Me.exportToAccessSmall = New System.Windows.Forms.Button()
		Me.BtnConfirmSmall = New System.Windows.Forms.Button()
		Me.RbtnSmall30 = New System.Windows.Forms.RadioButton()
		Me.RbtnSmall7 = New System.Windows.Forms.RadioButton()
		Me.RbtnSmall1 = New System.Windows.Forms.RadioButton()
		Me.LblDurationSmall = New System.Windows.Forms.Label()
		Me.PanelMedium = New System.Windows.Forms.Panel()
		Me.exportToAccessMedium = New System.Windows.Forms.Button()
		Me.BtnConfirmMedium = New System.Windows.Forms.Button()
		Me.RbtnMedium30 = New System.Windows.Forms.RadioButton()
		Me.RbtnMedium7 = New System.Windows.Forms.RadioButton()
		Me.RbtnMedium1 = New System.Windows.Forms.RadioButton()
		Me.LblDurationMedium = New System.Windows.Forms.Label()
		Me.PanelLarge = New System.Windows.Forms.Panel()
		Me.exportToAccessLarge = New System.Windows.Forms.Button()
		Me.BtnConfirmLarge = New System.Windows.Forms.Button()
		Me.RbtnLarge30 = New System.Windows.Forms.RadioButton()
		Me.RbtnLarge7 = New System.Windows.Forms.RadioButton()
		Me.RbtnLarge1 = New System.Windows.Forms.RadioButton()
		Me.LblDurationLarge = New System.Windows.Forms.Label()
		Me.LblPickCategory = New System.Windows.Forms.Label()
		Me.LblSmall = New System.Windows.Forms.Label()
		Me.LblMedium = New System.Windows.Forms.Label()
		Me.LblLarge = New System.Windows.Forms.Label()
		Me.LblDisclaimer = New System.Windows.Forms.Label()
		Me.SaveFilePrompt = New System.Windows.Forms.SaveFileDialog()
		Me.BtnGoBack = New System.Windows.Forms.Button()
		CType(Me.ImgSmallCar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImgMediumCar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImgLargeCar, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelSmall.SuspendLayout()
		Me.PanelMedium.SuspendLayout()
		Me.PanelLarge.SuspendLayout()
		Me.SuspendLayout()
		'
		'ImgSmallCar
		'
		Me.ImgSmallCar.BackgroundImage = CType(resources.GetObject("ImgSmallCar.BackgroundImage"), System.Drawing.Image)
		Me.ImgSmallCar.Image = CType(resources.GetObject("ImgSmallCar.Image"), System.Drawing.Image)
		Me.ImgSmallCar.Location = New System.Drawing.Point(16, 110)
		Me.ImgSmallCar.Margin = New System.Windows.Forms.Padding(4)
		Me.ImgSmallCar.Name = "ImgSmallCar"
		Me.ImgSmallCar.Size = New System.Drawing.Size(352, 330)
		Me.ImgSmallCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.ImgSmallCar.TabIndex = 0
		Me.ImgSmallCar.TabStop = False
		'
		'ImgMediumCar
		'
		Me.ImgMediumCar.Image = CType(resources.GetObject("ImgMediumCar.Image"), System.Drawing.Image)
		Me.ImgMediumCar.Location = New System.Drawing.Point(376, 110)
		Me.ImgMediumCar.Margin = New System.Windows.Forms.Padding(4)
		Me.ImgMediumCar.Name = "ImgMediumCar"
		Me.ImgMediumCar.Size = New System.Drawing.Size(368, 330)
		Me.ImgMediumCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.ImgMediumCar.TabIndex = 1
		Me.ImgMediumCar.TabStop = False
		'
		'ImgLargeCar
		'
		Me.ImgLargeCar.Image = CType(resources.GetObject("ImgLargeCar.Image"), System.Drawing.Image)
		Me.ImgLargeCar.Location = New System.Drawing.Point(752, 110)
		Me.ImgLargeCar.Margin = New System.Windows.Forms.Padding(4)
		Me.ImgLargeCar.Name = "ImgLargeCar"
		Me.ImgLargeCar.Size = New System.Drawing.Size(351, 330)
		Me.ImgLargeCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.ImgLargeCar.TabIndex = 2
		Me.ImgLargeCar.TabStop = False
		'
		'PanelSmall
		'
		Me.PanelSmall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PanelSmall.Controls.Add(Me.exportToAccessSmall)
		Me.PanelSmall.Controls.Add(Me.BtnConfirmSmall)
		Me.PanelSmall.Controls.Add(Me.RbtnSmall30)
		Me.PanelSmall.Controls.Add(Me.RbtnSmall7)
		Me.PanelSmall.Controls.Add(Me.RbtnSmall1)
		Me.PanelSmall.Controls.Add(Me.LblDurationSmall)
		Me.PanelSmall.Location = New System.Drawing.Point(16, 110)
		Me.PanelSmall.Margin = New System.Windows.Forms.Padding(4)
		Me.PanelSmall.Name = "PanelSmall"
		Me.PanelSmall.Size = New System.Drawing.Size(351, 329)
		Me.PanelSmall.TabIndex = 3
		'
		'exportToAccessSmall
		'
		Me.exportToAccessSmall.Location = New System.Drawing.Point(179, 280)
		Me.exportToAccessSmall.Name = "exportToAccessSmall"
		Me.exportToAccessSmall.Size = New System.Drawing.Size(134, 25)
		Me.exportToAccessSmall.TabIndex = 5
		Me.exportToAccessSmall.Text = "Export to Access"
		Me.exportToAccessSmall.UseVisualStyleBackColor = True
		'
		'BtnConfirmSmall
		'
		Me.BtnConfirmSmall.Location = New System.Drawing.Point(58, 278)
		Me.BtnConfirmSmall.Margin = New System.Windows.Forms.Padding(4)
		Me.BtnConfirmSmall.Name = "BtnConfirmSmall"
		Me.BtnConfirmSmall.Size = New System.Drawing.Size(100, 28)
		Me.BtnConfirmSmall.TabIndex = 4
		Me.BtnConfirmSmall.Text = "Save data"
		Me.BtnConfirmSmall.UseVisualStyleBackColor = True
		'
		'RbtnSmall30
		'
		Me.RbtnSmall30.AutoSize = True
		Me.RbtnSmall30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RbtnSmall30.Location = New System.Drawing.Point(72, 214)
		Me.RbtnSmall30.Margin = New System.Windows.Forms.Padding(4)
		Me.RbtnSmall30.Name = "RbtnSmall30"
		Me.RbtnSmall30.Size = New System.Drawing.Size(178, 29)
		Me.RbtnSmall30.TabIndex = 3
		Me.RbtnSmall30.TabStop = True
		Me.RbtnSmall30.Text = "1 Month - £270* "
		Me.RbtnSmall30.UseVisualStyleBackColor = True
		'
		'RbtnSmall7
		'
		Me.RbtnSmall7.AutoSize = True
		Me.RbtnSmall7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RbtnSmall7.Location = New System.Drawing.Point(72, 150)
		Me.RbtnSmall7.Margin = New System.Windows.Forms.Padding(4)
		Me.RbtnSmall7.Name = "RbtnSmall7"
		Me.RbtnSmall7.Size = New System.Drawing.Size(159, 29)
		Me.RbtnSmall7.TabIndex = 2
		Me.RbtnSmall7.TabStop = True
		Me.RbtnSmall7.Text = "1 Week - £95*"
		Me.RbtnSmall7.UseVisualStyleBackColor = True
		'
		'RbtnSmall1
		'
		Me.RbtnSmall1.AutoSize = True
		Me.RbtnSmall1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RbtnSmall1.Location = New System.Drawing.Point(72, 84)
		Me.RbtnSmall1.Margin = New System.Windows.Forms.Padding(4)
		Me.RbtnSmall1.Name = "RbtnSmall1"
		Me.RbtnSmall1.Size = New System.Drawing.Size(147, 29)
		Me.RbtnSmall1.TabIndex = 1
		Me.RbtnSmall1.TabStop = True
		Me.RbtnSmall1.Text = "1 Day - £30* "
		Me.RbtnSmall1.UseVisualStyleBackColor = True
		'
		'LblDurationSmall
		'
		Me.LblDurationSmall.AutoSize = True
		Me.LblDurationSmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblDurationSmall.Location = New System.Drawing.Point(53, 31)
		Me.LblDurationSmall.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblDurationSmall.Name = "LblDurationSmall"
		Me.LblDurationSmall.Size = New System.Drawing.Size(240, 29)
		Me.LblDurationSmall.TabIndex = 0
		Me.LblDurationSmall.Text = "Duration of the rental:"
		'
		'PanelMedium
		'
		Me.PanelMedium.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PanelMedium.Controls.Add(Me.exportToAccessMedium)
		Me.PanelMedium.Controls.Add(Me.BtnConfirmMedium)
		Me.PanelMedium.Controls.Add(Me.RbtnMedium30)
		Me.PanelMedium.Controls.Add(Me.RbtnMedium7)
		Me.PanelMedium.Controls.Add(Me.RbtnMedium1)
		Me.PanelMedium.Controls.Add(Me.LblDurationMedium)
		Me.PanelMedium.Location = New System.Drawing.Point(377, 110)
		Me.PanelMedium.Margin = New System.Windows.Forms.Padding(4)
		Me.PanelMedium.Name = "PanelMedium"
		Me.PanelMedium.Size = New System.Drawing.Size(366, 329)
		Me.PanelMedium.TabIndex = 4
		'
		'exportToAccessMedium
		'
		Me.exportToAccessMedium.Location = New System.Drawing.Point(192, 278)
		Me.exportToAccessMedium.Name = "exportToAccessMedium"
		Me.exportToAccessMedium.Size = New System.Drawing.Size(125, 28)
		Me.exportToAccessMedium.TabIndex = 5
		Me.exportToAccessMedium.Text = "Export to Access"
		Me.exportToAccessMedium.UseVisualStyleBackColor = True
		'
		'BtnConfirmMedium
		'
		Me.BtnConfirmMedium.Location = New System.Drawing.Point(37, 278)
		Me.BtnConfirmMedium.Margin = New System.Windows.Forms.Padding(4)
		Me.BtnConfirmMedium.Name = "BtnConfirmMedium"
		Me.BtnConfirmMedium.Size = New System.Drawing.Size(100, 28)
		Me.BtnConfirmMedium.TabIndex = 4
		Me.BtnConfirmMedium.Text = "Save to File"
		Me.BtnConfirmMedium.UseVisualStyleBackColor = True
		'
		'RbtnMedium30
		'
		Me.RbtnMedium30.AutoSize = True
		Me.RbtnMedium30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RbtnMedium30.Location = New System.Drawing.Point(67, 214)
		Me.RbtnMedium30.Margin = New System.Windows.Forms.Padding(4)
		Me.RbtnMedium30.Name = "RbtnMedium30"
		Me.RbtnMedium30.Size = New System.Drawing.Size(178, 29)
		Me.RbtnMedium30.TabIndex = 3
		Me.RbtnMedium30.TabStop = True
		Me.RbtnMedium30.Text = "1 Month - £310* "
		Me.RbtnMedium30.UseVisualStyleBackColor = True
		'
		'RbtnMedium7
		'
		Me.RbtnMedium7.AutoSize = True
		Me.RbtnMedium7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RbtnMedium7.Location = New System.Drawing.Point(67, 150)
		Me.RbtnMedium7.Margin = New System.Windows.Forms.Padding(4)
		Me.RbtnMedium7.Name = "RbtnMedium7"
		Me.RbtnMedium7.Size = New System.Drawing.Size(175, 29)
		Me.RbtnMedium7.TabIndex = 2
		Me.RbtnMedium7.TabStop = True
		Me.RbtnMedium7.Text = "1 Week - £115* "
		Me.RbtnMedium7.UseVisualStyleBackColor = True
		'
		'RbtnMedium1
		'
		Me.RbtnMedium1.AutoSize = True
		Me.RbtnMedium1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RbtnMedium1.Location = New System.Drawing.Point(67, 84)
		Me.RbtnMedium1.Margin = New System.Windows.Forms.Padding(4)
		Me.RbtnMedium1.Name = "RbtnMedium1"
		Me.RbtnMedium1.Size = New System.Drawing.Size(142, 29)
		Me.RbtnMedium1.TabIndex = 1
		Me.RbtnMedium1.TabStop = True
		Me.RbtnMedium1.Text = "1 Day - £40*"
		Me.RbtnMedium1.UseVisualStyleBackColor = True
		'
		'LblDurationMedium
		'
		Me.LblDurationMedium.AutoSize = True
		Me.LblDurationMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblDurationMedium.Location = New System.Drawing.Point(53, 31)
		Me.LblDurationMedium.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblDurationMedium.Name = "LblDurationMedium"
		Me.LblDurationMedium.Size = New System.Drawing.Size(240, 29)
		Me.LblDurationMedium.TabIndex = 0
		Me.LblDurationMedium.Text = "Duration of the rental:"
		'
		'PanelLarge
		'
		Me.PanelLarge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PanelLarge.Controls.Add(Me.exportToAccessLarge)
		Me.PanelLarge.Controls.Add(Me.BtnConfirmLarge)
		Me.PanelLarge.Controls.Add(Me.RbtnLarge30)
		Me.PanelLarge.Controls.Add(Me.RbtnLarge7)
		Me.PanelLarge.Controls.Add(Me.RbtnLarge1)
		Me.PanelLarge.Controls.Add(Me.LblDurationLarge)
		Me.PanelLarge.Location = New System.Drawing.Point(752, 110)
		Me.PanelLarge.Margin = New System.Windows.Forms.Padding(4)
		Me.PanelLarge.Name = "PanelLarge"
		Me.PanelLarge.Size = New System.Drawing.Size(349, 329)
		Me.PanelLarge.TabIndex = 5
		'
		'exportToAccessLarge
		'
		Me.exportToAccessLarge.Location = New System.Drawing.Point(188, 278)
		Me.exportToAccessLarge.Name = "exportToAccessLarge"
		Me.exportToAccessLarge.Size = New System.Drawing.Size(121, 28)
		Me.exportToAccessLarge.TabIndex = 5
		Me.exportToAccessLarge.Text = "Export to Access"
		Me.exportToAccessLarge.UseVisualStyleBackColor = True
		'
		'BtnConfirmLarge
		'
		Me.BtnConfirmLarge.Location = New System.Drawing.Point(40, 278)
		Me.BtnConfirmLarge.Margin = New System.Windows.Forms.Padding(4)
		Me.BtnConfirmLarge.Name = "BtnConfirmLarge"
		Me.BtnConfirmLarge.Size = New System.Drawing.Size(100, 28)
		Me.BtnConfirmLarge.TabIndex = 4
		Me.BtnConfirmLarge.Text = "Save data"
		Me.BtnConfirmLarge.UseVisualStyleBackColor = True
		'
		'RbtnLarge30
		'
		Me.RbtnLarge30.AutoSize = True
		Me.RbtnLarge30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RbtnLarge30.Location = New System.Drawing.Point(79, 214)
		Me.RbtnLarge30.Margin = New System.Windows.Forms.Padding(4)
		Me.RbtnLarge30.Name = "RbtnLarge30"
		Me.RbtnLarge30.Size = New System.Drawing.Size(178, 29)
		Me.RbtnLarge30.TabIndex = 3
		Me.RbtnLarge30.TabStop = True
		Me.RbtnLarge30.Text = "1 Month - £340* "
		Me.RbtnLarge30.UseVisualStyleBackColor = True
		'
		'RbtnLarge7
		'
		Me.RbtnLarge7.AutoSize = True
		Me.RbtnLarge7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RbtnLarge7.Location = New System.Drawing.Point(79, 150)
		Me.RbtnLarge7.Margin = New System.Windows.Forms.Padding(4)
		Me.RbtnLarge7.Name = "RbtnLarge7"
		Me.RbtnLarge7.Size = New System.Drawing.Size(170, 29)
		Me.RbtnLarge7.TabIndex = 2
		Me.RbtnLarge7.TabStop = True
		Me.RbtnLarge7.Text = "1 Week - £130*"
		Me.RbtnLarge7.UseVisualStyleBackColor = True
		'
		'RbtnLarge1
		'
		Me.RbtnLarge1.AutoSize = True
		Me.RbtnLarge1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RbtnLarge1.Location = New System.Drawing.Point(79, 84)
		Me.RbtnLarge1.Margin = New System.Windows.Forms.Padding(4)
		Me.RbtnLarge1.Name = "RbtnLarge1"
		Me.RbtnLarge1.Size = New System.Drawing.Size(142, 29)
		Me.RbtnLarge1.TabIndex = 1
		Me.RbtnLarge1.TabStop = True
		Me.RbtnLarge1.Text = "1 Day - £45*"
		Me.RbtnLarge1.UseVisualStyleBackColor = True
		'
		'LblDurationLarge
		'
		Me.LblDurationLarge.AutoSize = True
		Me.LblDurationLarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblDurationLarge.Location = New System.Drawing.Point(55, 31)
		Me.LblDurationLarge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblDurationLarge.Name = "LblDurationLarge"
		Me.LblDurationLarge.Size = New System.Drawing.Size(240, 29)
		Me.LblDurationLarge.TabIndex = 0
		Me.LblDurationLarge.Text = "Duration of the rental:"
		'
		'LblPickCategory
		'
		Me.LblPickCategory.AutoSize = True
		Me.LblPickCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblPickCategory.Location = New System.Drawing.Point(16, 11)
		Me.LblPickCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblPickCategory.Name = "LblPickCategory"
		Me.LblPickCategory.Size = New System.Drawing.Size(369, 36)
		Me.LblPickCategory.TabIndex = 6
		Me.LblPickCategory.Text = "Pick the vehicle category"
		'
		'LblSmall
		'
		Me.LblSmall.AutoSize = True
		Me.LblSmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblSmall.Location = New System.Drawing.Point(16, 79)
		Me.LblSmall.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblSmall.Name = "LblSmall"
		Me.LblSmall.Size = New System.Drawing.Size(61, 25)
		Me.LblSmall.TabIndex = 7
		Me.LblSmall.Text = "Small"
		'
		'LblMedium
		'
		Me.LblMedium.AutoSize = True
		Me.LblMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblMedium.Location = New System.Drawing.Point(372, 79)
		Me.LblMedium.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblMedium.Name = "LblMedium"
		Me.LblMedium.Size = New System.Drawing.Size(82, 25)
		Me.LblMedium.TabIndex = 8
		Me.LblMedium.Text = "Medium"
		'
		'LblLarge
		'
		Me.LblLarge.AutoSize = True
		Me.LblLarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblLarge.Location = New System.Drawing.Point(747, 79)
		Me.LblLarge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblLarge.Name = "LblLarge"
		Me.LblLarge.Size = New System.Drawing.Size(62, 25)
		Me.LblLarge.TabIndex = 9
		Me.LblLarge.Text = "Large"
		'
		'LblDisclaimer
		'
		Me.LblDisclaimer.AutoSize = True
		Me.LblDisclaimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblDisclaimer.Location = New System.Drawing.Point(19, 469)
		Me.LblDisclaimer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblDisclaimer.Name = "LblDisclaimer"
		Me.LblDisclaimer.Size = New System.Drawing.Size(533, 17)
		Me.LblDisclaimer.TabIndex = 10
		Me.LblDisclaimer.Text = "*Prices are not representative of final pricing, other factors are included"
		'
		'SaveFilePrompt
		'
		Me.SaveFilePrompt.DefaultExt = "txt"
		Me.SaveFilePrompt.FileName = "Record1"
		Me.SaveFilePrompt.Filter = "Text Files|*.txt|Rich Text Files|*.rtf"
		Me.SaveFilePrompt.InitialDirectory = "C:/Users/Documents "
		'
		'BtnGoBack
		'
		Me.BtnGoBack.Location = New System.Drawing.Point(973, 469)
		Me.BtnGoBack.Margin = New System.Windows.Forms.Padding(4)
		Me.BtnGoBack.Name = "BtnGoBack"
		Me.BtnGoBack.Size = New System.Drawing.Size(101, 30)
		Me.BtnGoBack.TabIndex = 11
		Me.BtnGoBack.Text = "Go back"
		Me.BtnGoBack.UseVisualStyleBackColor = True
		'
		'CarCategorySelector
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1124, 517)
		Me.Controls.Add(Me.BtnGoBack)
		Me.Controls.Add(Me.LblDisclaimer)
		Me.Controls.Add(Me.LblLarge)
		Me.Controls.Add(Me.LblMedium)
		Me.Controls.Add(Me.LblSmall)
		Me.Controls.Add(Me.LblPickCategory)
		Me.Controls.Add(Me.PanelLarge)
		Me.Controls.Add(Me.PanelMedium)
		Me.Controls.Add(Me.PanelSmall)
		Me.Controls.Add(Me.ImgLargeCar)
		Me.Controls.Add(Me.ImgMediumCar)
		Me.Controls.Add(Me.ImgSmallCar)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "CarCategorySelector"
		Me.Text = "Car Category Selector"
		CType(Me.ImgSmallCar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImgMediumCar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImgLargeCar, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelSmall.ResumeLayout(False)
		Me.PanelSmall.PerformLayout()
		Me.PanelMedium.ResumeLayout(False)
		Me.PanelMedium.PerformLayout()
		Me.PanelLarge.ResumeLayout(False)
		Me.PanelLarge.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ImgSmallCar As PictureBox
	Friend WithEvents ImgMediumCar As PictureBox
	Friend WithEvents ImgLargeCar As PictureBox
	Friend WithEvents PanelSmall As Panel
	Friend WithEvents PanelMedium As Panel
	Friend WithEvents PanelLarge As Panel
	Friend WithEvents LblPickCategory As Label
	Friend WithEvents LblDurationSmall As Label
	Friend WithEvents LblDurationMedium As Label
	Friend WithEvents LblDurationLarge As Label
	Friend WithEvents LblSmall As Label
	Friend WithEvents LblMedium As Label
	Friend WithEvents LblLarge As Label
	Friend WithEvents RbtnSmall30 As RadioButton
	Friend WithEvents RbtnSmall7 As RadioButton
	Friend WithEvents RbtnSmall1 As RadioButton
	Friend WithEvents RbtnMedium30 As RadioButton
	Friend WithEvents RbtnMedium7 As RadioButton
	Friend WithEvents RbtnMedium1 As RadioButton
	Friend WithEvents RbtnLarge30 As RadioButton
	Friend WithEvents RbtnLarge7 As RadioButton
	Friend WithEvents RbtnLarge1 As RadioButton
	Friend WithEvents BtnConfirmSmall As Button
	Friend WithEvents BtnConfirmMedium As Button
	Friend WithEvents BtnConfirmLarge As Button
	Friend WithEvents LblDisclaimer As Label
	Friend WithEvents SaveFilePrompt As SaveFileDialog
	Friend WithEvents BtnGoBack As Button
	Friend WithEvents exportToAccessMedium As Button
	Friend WithEvents exportToAccessSmall As Button
	Friend WithEvents exportToAccessLarge As Button
End Class
