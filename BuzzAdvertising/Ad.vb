Public Class Ad
    Private _company As String
    Private _telephone As String
    Private _adRunDate As String
    Private _adSize As String
    Private _adLocation As String
    Private _adPrice As String = "$0.00"

    ' Mutator and accessor functions for _company
    Public Property Company As String
        Get
            Return _company
        End Get
        Set(value As String)
            _company = value
        End Set
    End Property


    ' Mutator and accessor functions for _telephone
    Public Property Telephone As String
        Get
            Return _telephone
        End Get
        Set(value As String)
            _telephone = value
        End Set
    End Property

    ' RunDate Property: Mutator and accessor functions for _adRunDate
    Public Property RunDate As String
        Get
            Return _adRunDate
        End Get
        Set(value As String)
            _adRunDate = value
        End Set
    End Property

    ' Size Property: Mutator and accessor functions for _adSize
    Public Property Size As String
        Get
            Return _adSize
        End Get
        Set(value As String)
            _adSize = value
        End Set
    End Property

    ' Location Property: Mutator and accessor functions for _adLocation
    Public Property Location As String
        Get
            Return _adLocation
        End Get
        Set(value As String)
            _adLocation = value
        End Set
    End Property

    ' Price Property: Mutator and accessor functions for _adPrice
    Public Property Price As String
        Get
            Return _adPrice
        End Get
        Set(value As String)
            _adPrice = value
        End Set
    End Property

    ' Function to calculate ad price
    Public Function CalculatePrice(ByVal sizeValue As String, ByVal locationValue As String) As String
        If (sizeValue = "") Or (locationValue = "") Then
            MessageBox.Show("Please select both a Size and a Locationin order to see a Price.")
            Return "$0.00"
        End If
        'MessageBox.Show("In CalculatePrice. Size = " & sizeValue & " and location = " & locationValue & ".")
        Dim basePrice As Double = 225.0
        Dim price As Double = 0
        Dim markup As Double = 0

        Select Case sizeValue
            Case "fullPg"
                price = basePrice

            Case "halfPg"
                price = 0.65 * basePrice

            Case "qtrPg"
                price = 0.4 * basePrice

            Case "busCard"
                price = 35.0
        End Select

        Select Case locationValue
            Case "outsideBackCover"
                markup = 1.4
            Case "insideBackCover"
                markup = 1.15
            Case "insideFrontCover"
                markup = 1.2
            Case "interior"
                markup = 1
        End Select
        'MessageBox.Show("Baseprice = " & basePrice & ", price = " & price & ", and markup = " & markup & ".")
        Dim totalCost As Double = price * markup
        'MessageBox.Show("totalCost = " & totalCost & ", totalCost.ToString('C2') = " & totalCost.ToString("C2") & ".")
        _adPrice = totalCost.ToString("C2")
        Return _adPrice

    End Function

    ' Constructor without Parameters
    Public Sub New()
        _adSize = String.Empty
        _adLocation = String.Empty
    End Sub

    ' Constructor with Parameters
    Public Sub New(ByVal sizeValue As String, ByVal locationValue As String)
        _adSize = sizeValue
        _adLocation = locationValue
    End Sub

End Class
