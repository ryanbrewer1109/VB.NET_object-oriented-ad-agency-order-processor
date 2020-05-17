<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.QtrPgRadioButton = New System.Windows.Forms.RadioButton()
        Me.BusCardRadioButton = New System.Windows.Forms.RadioButton()
        Me.HalfPgRadioButton = New System.Windows.Forms.RadioButton()
        Me.FullPgRadioButton = New System.Windows.Forms.RadioButton()
        Me.OutsideBackCoverRadioButton = New System.Windows.Forms.RadioButton()
        Me.LocationGroupBox = New System.Windows.Forms.GroupBox()
        Me.InteriorPgRadioButton = New System.Windows.Forms.RadioButton()
        Me.InsideFronCoverRadioButton = New System.Windows.Forms.RadioButton()
        Me.InsideBackCoverRadioButton = New System.Windows.Forms.RadioButton()
        Me.CompNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.RunDateTextBox = New System.Windows.Forms.TextBox()
        Me.ReserveButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.AdPriceLabel = New System.Windows.Forms.Label()
        Me.SeePriceButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.LocationGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 143)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ad Price"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(179, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(317, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Catch the Buzz!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(179, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(317, 59)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Place your ad with Buzz Advertising for maximum exposure!"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(180, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(316, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Reserve your ad today:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.QtrPgRadioButton)
        Me.GroupBox1.Controls.Add(Me.BusCardRadioButton)
        Me.GroupBox1.Controls.Add(Me.HalfPgRadioButton)
        Me.GroupBox1.Controls.Add(Me.FullPgRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 123)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ad Size"
        '
        'QtrPgRadioButton
        '
        Me.QtrPgRadioButton.AutoSize = True
        Me.QtrPgRadioButton.Location = New System.Drawing.Point(13, 66)
        Me.QtrPgRadioButton.Name = "QtrPgRadioButton"
        Me.QtrPgRadioButton.Size = New System.Drawing.Size(88, 17)
        Me.QtrPgRadioButton.TabIndex = 6
        Me.QtrPgRadioButton.TabStop = True
        Me.QtrPgRadioButton.Text = "Quarter Page"
        Me.QtrPgRadioButton.UseVisualStyleBackColor = True
        '
        'BusCardRadioButton
        '
        Me.BusCardRadioButton.AutoSize = True
        Me.BusCardRadioButton.Location = New System.Drawing.Point(13, 89)
        Me.BusCardRadioButton.Name = "BusCardRadioButton"
        Me.BusCardRadioButton.Size = New System.Drawing.Size(92, 17)
        Me.BusCardRadioButton.TabIndex = 2
        Me.BusCardRadioButton.TabStop = True
        Me.BusCardRadioButton.Text = "Business Card"
        Me.BusCardRadioButton.UseVisualStyleBackColor = True
        '
        'HalfPgRadioButton
        '
        Me.HalfPgRadioButton.AutoSize = True
        Me.HalfPgRadioButton.Location = New System.Drawing.Point(13, 43)
        Me.HalfPgRadioButton.Name = "HalfPgRadioButton"
        Me.HalfPgRadioButton.Size = New System.Drawing.Size(72, 17)
        Me.HalfPgRadioButton.TabIndex = 1
        Me.HalfPgRadioButton.TabStop = True
        Me.HalfPgRadioButton.Text = "Half Page"
        Me.HalfPgRadioButton.UseVisualStyleBackColor = True
        '
        'FullPgRadioButton
        '
        Me.FullPgRadioButton.AutoSize = True
        Me.FullPgRadioButton.Location = New System.Drawing.Point(13, 20)
        Me.FullPgRadioButton.Name = "FullPgRadioButton"
        Me.FullPgRadioButton.Size = New System.Drawing.Size(69, 17)
        Me.FullPgRadioButton.TabIndex = 0
        Me.FullPgRadioButton.TabStop = True
        Me.FullPgRadioButton.Text = "Full Page"
        Me.FullPgRadioButton.UseVisualStyleBackColor = True
        '
        'OutsideBackCoverRadioButton
        '
        Me.OutsideBackCoverRadioButton.AutoSize = True
        Me.OutsideBackCoverRadioButton.Enabled = False
        Me.OutsideBackCoverRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.OutsideBackCoverRadioButton.Name = "OutsideBackCoverRadioButton"
        Me.OutsideBackCoverRadioButton.Size = New System.Drawing.Size(118, 17)
        Me.OutsideBackCoverRadioButton.TabIndex = 3
        Me.OutsideBackCoverRadioButton.TabStop = True
        Me.OutsideBackCoverRadioButton.Text = "Outside back cover"
        Me.OutsideBackCoverRadioButton.UseVisualStyleBackColor = True
        '
        'LocationGroupBox
        '
        Me.LocationGroupBox.Controls.Add(Me.InteriorPgRadioButton)
        Me.LocationGroupBox.Controls.Add(Me.InsideFronCoverRadioButton)
        Me.LocationGroupBox.Controls.Add(Me.InsideBackCoverRadioButton)
        Me.LocationGroupBox.Controls.Add(Me.OutsideBackCoverRadioButton)
        Me.LocationGroupBox.Enabled = False
        Me.LocationGroupBox.Location = New System.Drawing.Point(179, 176)
        Me.LocationGroupBox.Name = "LocationGroupBox"
        Me.LocationGroupBox.Size = New System.Drawing.Size(161, 124)
        Me.LocationGroupBox.TabIndex = 7
        Me.LocationGroupBox.TabStop = False
        Me.LocationGroupBox.Text = "Location"
        '
        'InteriorPgRadioButton
        '
        Me.InteriorPgRadioButton.AutoSize = True
        Me.InteriorPgRadioButton.Enabled = False
        Me.InteriorPgRadioButton.Location = New System.Drawing.Point(6, 88)
        Me.InteriorPgRadioButton.Name = "InteriorPgRadioButton"
        Me.InteriorPgRadioButton.Size = New System.Drawing.Size(84, 17)
        Me.InteriorPgRadioButton.TabIndex = 3
        Me.InteriorPgRadioButton.TabStop = True
        Me.InteriorPgRadioButton.Text = "Interior page"
        Me.InteriorPgRadioButton.UseVisualStyleBackColor = True
        '
        'InsideFronCoverRadioButton
        '
        Me.InsideFronCoverRadioButton.AutoSize = True
        Me.InsideFronCoverRadioButton.Enabled = False
        Me.InsideFronCoverRadioButton.Location = New System.Drawing.Point(6, 65)
        Me.InsideFronCoverRadioButton.Name = "InsideFronCoverRadioButton"
        Me.InsideFronCoverRadioButton.Size = New System.Drawing.Size(107, 17)
        Me.InsideFronCoverRadioButton.TabIndex = 3
        Me.InsideFronCoverRadioButton.TabStop = True
        Me.InsideFronCoverRadioButton.Text = "Inside front cover"
        Me.InsideFronCoverRadioButton.UseVisualStyleBackColor = True
        '
        'InsideBackCoverRadioButton
        '
        Me.InsideBackCoverRadioButton.AutoSize = True
        Me.InsideBackCoverRadioButton.Enabled = False
        Me.InsideBackCoverRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.InsideBackCoverRadioButton.Name = "InsideBackCoverRadioButton"
        Me.InsideBackCoverRadioButton.Size = New System.Drawing.Size(110, 17)
        Me.InsideBackCoverRadioButton.TabIndex = 3
        Me.InsideBackCoverRadioButton.TabStop = True
        Me.InsideBackCoverRadioButton.Text = "Inside back cover"
        Me.InsideBackCoverRadioButton.UseVisualStyleBackColor = True
        '
        'CompNameTextBox
        '
        Me.CompNameTextBox.Location = New System.Drawing.Point(365, 195)
        Me.CompNameTextBox.Name = "CompNameTextBox"
        Me.CompNameTextBox.Size = New System.Drawing.Size(131, 20)
        Me.CompNameTextBox.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(362, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Company Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(362, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Telephone:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(362, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Run date:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(365, 239)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(131, 20)
        Me.PhoneTextBox.TabIndex = 8
        '
        'RunDateTextBox
        '
        Me.RunDateTextBox.Location = New System.Drawing.Point(365, 280)
        Me.RunDateTextBox.Name = "RunDateTextBox"
        Me.RunDateTextBox.Size = New System.Drawing.Size(131, 20)
        Me.RunDateTextBox.TabIndex = 8
        '
        'ReserveButton
        '
        Me.ReserveButton.Location = New System.Drawing.Point(255, 320)
        Me.ReserveButton.Name = "ReserveButton"
        Me.ReserveButton.Size = New System.Drawing.Size(73, 23)
        Me.ReserveButton.TabIndex = 10
        Me.ReserveButton.Text = "Reserve Ad"
        Me.ReserveButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(339, 320)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(73, 23)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(423, 320)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(73, 23)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AdPriceLabel
        '
        Me.AdPriceLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.AdPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AdPriceLabel.Location = New System.Drawing.Point(26, 320)
        Me.AdPriceLabel.Name = "AdPriceLabel"
        Me.AdPriceLabel.Size = New System.Drawing.Size(133, 23)
        Me.AdPriceLabel.TabIndex = 11
        Me.AdPriceLabel.Text = "$0.00"
        Me.AdPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SeePriceButton
        '
        Me.SeePriceButton.Location = New System.Drawing.Point(171, 320)
        Me.SeePriceButton.Name = "SeePriceButton"
        Me.SeePriceButton.Size = New System.Drawing.Size(73, 23)
        Me.SeePriceButton.TabIndex = 12
        Me.SeePriceButton.Text = "See Price"
        Me.SeePriceButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 368)
        Me.Controls.Add(Me.SeePriceButton)
        Me.Controls.Add(Me.AdPriceLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ReserveButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RunDateTextBox)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.CompNameTextBox)
        Me.Controls.Add(Me.LocationGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainForm"
        Me.Text = "Buzz Advertising"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.LocationGroupBox.ResumeLayout(False)
        Me.LocationGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BusCardRadioButton As RadioButton
    Friend WithEvents HalfPgRadioButton As RadioButton
    Friend WithEvents FullPgRadioButton As RadioButton
    Friend WithEvents QtrPgRadioButton As RadioButton
    Friend WithEvents OutsideBackCoverRadioButton As RadioButton
    Friend WithEvents LocationGroupBox As GroupBox
    Friend WithEvents InteriorPgRadioButton As RadioButton
    Friend WithEvents InsideFronCoverRadioButton As RadioButton
    Friend WithEvents InsideBackCoverRadioButton As RadioButton
    Friend WithEvents CompNameTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents RunDateTextBox As TextBox
    Friend WithEvents ReserveButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents AdPriceLabel As Label
    Friend WithEvents SeePriceButton As Button
End Class
