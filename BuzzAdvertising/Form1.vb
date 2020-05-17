Public Class Form1
    ' Variable indicates the when both radio buttons have beenselected for the first time.
    ' At that pont, a new Adobject should be created.
    Dim counterNumTimesLocationChanged = 0
    Dim thisAd As Ad

    Public Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If adLocation <> String.Empty Then
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
            RadioButton8.Enabled = True

            setAdSize("fullPg")

            adPriceLabel.Text = calcAdPrice(adSize, adLocation)

        End If

    End Sub

    Public Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If adLocation <> String.Empty Then
            RadioButton5.Enabled = False
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
            RadioButton8.Enabled = True

            setAdSize("halfPg")
            RadioButton5.Enabled = False
            If adLocation <> String.Empty Then
                adPriceLabel.Text = calcAdPrice(adSize, adLocation)
            End If
    End Sub

    Public Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If adLocation <> String.Empty Then
            RadioButton5.Enabled = False
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
            RadioButton8.Enabled = True

            setAdSize("qtrPg")
            adPriceLabel.Text = calcAdPrice(adSize, adLocation)
        End If
    End Sub

    Public Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        setAdSize("busCard")
        RadioButton5.Enabled = False
        If adLocation <> String.Empty Then
            RadioButton5.Enabled = False
            RadioButton6.Enabled = False
            RadioButton7.Enabled = False
            RadioButton8.Enabled = True

        ElseIf adLocation = "interior" Then
            adPriceLabel.Text = calcAdPrice(adSize, adLocation)
        ElseIf adLocation <> String.Empty Then
            MessageBox.Show("Business card ads must be located on interior pages only. Choose a larger different size.")
        Else
            RadioButton5.Enabled = False
            RadioButton6.Enabled = False
            RadioButton7.Enabled = False
            RadioButton8.Enabled = True
            MessageBox.Show("Change location to interior page, or choose a larger size. ")

        End If
    End Sub

    Public Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        setAdLocation("outsideBackCover")
        counterNumTimesLocationChanged += 1
        If Size <> String.Empty Then
            adPriceLabel.Text = calcAdPrice(adSize, adLocation)
        End If
    End Sub

    Public Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        counterNumTimesLocationChanged += 1
        setAdLocation("insideBackCover")
        If adLocation <> String.Empty Then
            adPriceLabel.Text = calcAdPrice(adSize, adLocation)
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        counterNumTimesLocationChanged += 1

        setAdLocation("insideFrontCover")
        If adLocation > 0 Then
            adPriceLabel.Text = calcAdPrice(adSize, adLocation)
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged

        counterNumTimesLocationChanged += 1
        setAdLocation("interior")
        If Ad Location > 0 Then
            adPriceLabel.Text = calcAdPrice(adSize, adLocation)
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Clear button:
        ' Reset Size and clear adSize selection
        setAdSize(String.Empty)
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False

        ' Reset Size and clear adSize selection
        setAdLocation(String.Empty)
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False

        ' Clear other text fields
        setCompany(String.Empty)
        setTelephone(String.Empty)
        setRunDate(String.Empty)


    End Sub

End Class


n Public Class Ad

End Class