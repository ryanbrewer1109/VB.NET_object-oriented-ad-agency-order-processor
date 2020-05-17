Public Class MainForm

    Dim thisAd As Ad
    Dim currentSize As String
    Dim currentLocation As String
    Dim isComplete As Boolean = True

    Public Sub FullPgRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FullPgRadioButton.CheckedChanged
        '        EnableAllLocationButtons
        If FullPgRadioButton.Checked Then
            currentSize = "fullPg"
            DetermineLocationButtons()
        Else
            LocationGroupBox.Enabled = False
        End If

    End Sub

    Public Sub HalfPgRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles HalfPgRadioButton.CheckedChanged
        If HalfPgRadioButton.Checked Then
            currentSize = "halfPg"
            DetermineLocationButtons()
        Else
            LocationGroupBox.Enabled = False
        End If

        'EnableThreeLocationButtons()
        'If OutsideBackCoverRadioButton.Checked Then
        'MessageBox.Show("The backcover is reserved for full page ads. Please select a different ad location.")
        ' ClearLocationRadioButtons()
        ' End If

        DetermineLocationButtons()
    End Sub

    Public Sub QtrPgRadioButton_Clicked(sender As Object, e As EventArgs) Handles QtrPgRadioButton.Click
        If QtrPgRadioButton.Checked Then
            currentSize = "qtrPg"
            DetermineLocationButtons()
        Else
            LocationGroupBox.Enabled = False
        End If

        'EnableThreeLocationButtons()
        'If OutsideBackCoverRadioButton.Checked Then
        'MessageBox.Show("The backcover is reserved for full page ads. Please select a different ad location.")
        ' ClearLocationRadioButtons()
        ' End If

        DetermineLocationButtons()
    End Sub

    Public Sub BusCardRadioButton_Clicked(sender As Object, e As EventArgs) Handles BusCardRadioButton.Click
        If BusCardRadioButton.Checked Then
            currentSize = "busCard"
            DetermineLocationButtons()
        Else
            LocationGroupBox.Enabled = False
        End If
        'EnableOneLocationButton()
        'If currentLocation <> String.Empty Then
        ' If Not InteriorPgRadioButton.Checked Then
        MessageBox.Show("Business card ads are only permitted on interior pages. Please select applicable ad location.")
        ' ClearLocationRadioButtons()
        ' End If
        ' End If

        DetermineLocationButtons()
    End Sub

    Public Sub OutsideBackCoverRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles OutsideBackCoverRadioButton.CheckedChanged
        ClearPrice()
        If currentSize <> "fullPg" Then
            MessageBox.Show("The backcover is reserved for full page ads. Please select a different ad location.")
            ClearLocationRadioButtons()
        End If
    End Sub

    Public Sub InsideBackCoverRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles InsideBackCoverRadioButton.CheckedChanged
        ClearPrice()
    End Sub

    Private Sub InsideFronCoverRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles InsideFronCoverRadioButton.CheckedChanged
        ClearPrice()
    End Sub

    Private Sub InteriorPgRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles InteriorPgRadioButton.CheckedChanged
        ClearPrice()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Clear button:
        ' Clear Radio Button Selections
        ClearSizeRadioButtons()
        ClearLocationRadioButtons()
        EnableForm()

        ' Clear other fields on form
        CompNameTextBox.Text = String.Empty
        PhoneTextBox.Text = String.Empty
        RunDateTextBox.Text = String.Empty
        AdPriceLabel.Text = "$0.00"

        ' Reset Size and clear currentSize selection
        currentSize = String.Empty
        currentLocation = String.Empty

        ' Clear other data in thisAd object

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ShowReserveErrorMsg()
        MessageBox.Show("Form is incomplete or has errors. Please make corrections and click Reserve Ad again.")
    End Sub


    Public Sub SeePriceButton_Click(sender As Object, e As EventArgs) Handles SeePriceButton.Click


        Select Case True
            Case FullPgRadioButton.Checked
                currentSize = "fullPg"
        '        thisAd.Size = currentSize
            Case HalfPgRadioButton.Checked
                currentSize = "halfPg"
         '       thisAd.Size = currentSize
            Case QtrPgRadioButton.Checked
                currentSize = "qtrPg"
          '      thisAd.Size = currentSize
            Case BusCardRadioButton.Checked
                currentSize = "busCard"
                '     thisAd.Size = currentSize
        End Select

        Select Case True
            Case OutsideBackCoverRadioButton.Checked
                currentLocation = "outsideBackCover"
            '    thisAd.Location = currentLocation

            Case InsideBackCoverRadioButton.Checked
                currentLocation = "insideBackCover"
            '    thisAd.Location = currentLocation

            Case InsideFronCoverRadioButton.Checked
                currentLocation = "insideFrontCover"
            '    thisAd.Location = currentLocation

            Case InteriorPgRadioButton.Checked
                currentLocation = "interior"
                '    thisAd.Size = currentLocation
        End Select

        Dim thisAd As Ad = New Ad(currentSize, currentLocation)

        'MessageBox.Show("Calculating Price. Completed 'Select Case' code block. Size is " & thisAd.Size & " and location is " & thisAd.Location & ".")
        AdPriceLabel.Text = thisAd.CalculatePrice(thisAd.Size, thisAd.Location)
        ReserveButton.Enabled = True
    End Sub

    Sub DisableLocationButtons()
        OutsideBackCoverRadioButton.Enabled = False
        InsideBackCoverRadioButton.Enabled = False
        InsideFronCoverRadioButton.Enabled = False
        InteriorPgRadioButton.Enabled = False
        'MessageBox.Show("Location Buttons just disabled.")
    End Sub
    Sub DisableForm()
        DisableLocationButtons()
        FullPgRadioButton.Enabled = False
        HalfPgRadioButton.Enabled = False
        QtrPgRadioButton.Enabled = False
        BusCardRadioButton.Enabled = False
        CompNameTextBox.Enabled = False
        PhoneTextBox.Enabled = False
        RunDateTextBox.Enabled = False

        SeePriceButton.Enabled = False
        ReserveButton.Enabled = False
    End Sub

    Sub EnableForm()
        DisableLocationButtons()
        FullPgRadioButton.Enabled = True
        HalfPgRadioButton.Enabled = True
        QtrPgRadioButton.Enabled = True
        BusCardRadioButton.Enabled = True
        CompNameTextBox.Enabled = True
        PhoneTextBox.Enabled = True
        RunDateTextBox.Enabled = True

        SeePriceButton.Enabled = True
        ReserveButton.Enabled = True
    End Sub


    Sub EnableAllLocationButtons()
        OutsideBackCoverRadioButton.Enabled = True
        InsideBackCoverRadioButton.Enabled = True
        InsideFronCoverRadioButton.Enabled = True
        InteriorPgRadioButton.Enabled = True

    End Sub

    Sub EnableThreeLocationButtons()
        InsideBackCoverRadioButton.Enabled = True
        InsideFronCoverRadioButton.Enabled = True
        InteriorPgRadioButton.Enabled = True
    End Sub

    Sub EnableOneLocationButton()
        InteriorPgRadioButton.Enabled = True
    End Sub

    Sub EnableSizeRadioButtons()
        FullPgRadioButton.Enabled = True
        HalfPgRadioButton.Enabled = True
        QtrPgRadioButton.Enabled = True
        BusCardRadioButton.Enabled = True
    End Sub

    Sub DetermineLocationButtons()
        LocationGroupBox.Enabled = True
        ClearLocationRadioButtons()
        DisableLocationButtons()
        ClearPrice()


        Select Case currentSize
            Case "fullPg"
                'MessageBox.Show("Location should be ALL OPTIONS")
                EnableAllLocationButtons()

            Case "halfPg", "qtrPg"
                'MessageBox.Show("Location should be ALL Except BackCover")                '
                EnableThreeLocationButtons()

            Case "busCard"
                'MessageBox.Show("Location should be ONLY interior pages.")                '
                EnableOneLocationButton()
        End Select
    End Sub

    Sub ClearSizeRadioButtons()
        FullPgRadioButton.Checked = False
        HalfPgRadioButton.Checked = False
        QtrPgRadioButton.Checked = False
        BusCardRadioButton.Checked = False
    End Sub

    Sub ClearLocationRadioButtons()
        OutsideBackCoverRadioButton.Checked = False
        InsideBackCoverRadioButton.Checked = False
        InsideFronCoverRadioButton.Checked = False
        InteriorPgRadioButton.Checked = False
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show("Load function is running.")
        ' DisableLocationButtons()
        ' MessageBox.Show("BEFORE: Is FullPageRadio Button checked? " & FullPgRadioButton.Checked)
        ' FullPgRadioButton.Checked = False
        ' MessageBox.Show("AFTER: Is FullPageRadio Button checked? " & FullPgRadioButton.Checked)
        ReserveButton.Enabled = False
    End Sub
    Private Sub ReserveButton_Click(sender As Object, e As EventArgs) Handles ReserveButton.Click
        ' This subroutine handles the Reserve Ad button and validates form is complete
        isComplete = True
        If CompNameTextBox.Text = String.Empty Then
            isComplete = False

        ElseIf PhoneTextBox.Text = String.Empty Then
            isComplete = False

        ElseIf RunDateTextBox.Text = String.Empty Then
            isComplete = False

        ElseIf AdPriceLabel.Text = "$0.00" Then
            isComplete = False
        End If

        If Not isComplete Then
            ShowReserveErrorMsg()
            'ReserveButton.Enabled = False
        Else
            DisableForm()
            MessageBox.Show("Thank you for your order! Your ad is being processed.")
        End If


    End Sub

    Public Sub ClearPrice()
        AdPriceLabel.Text = "$0.00"
        ReserveButton.Enabled = False
    End Sub
End Class