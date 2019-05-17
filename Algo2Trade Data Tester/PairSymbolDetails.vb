<Serializable>
Public Class PairSymbolDetails
    Public Property Instrument1Name As String
    Public Property Instrument1Token As String
    Public Property Instrument1StartingColumn As Integer
    Public Property Instrument1LotSize As Integer
    Public Property Instrument1NumberOfLots As Integer
    Public Property Instrument1Brokerage As Decimal

    Public Property Instrument2Name As String
    Public Property Instrument2Token As String
    Public Property Instrument2StartingColumn As Integer
    Public Property Instrument2LotSize As Integer
    Public Property Instrument2NumberOfLots As Integer
    Public Property Instrument2Brokerage As Decimal

    Public Property EODExitTime As Date
    Public Property FromDate As Date
    Public Property ToDate As Date
    Public Property TimeFrame As Integer
    Public Property TemplateFilePath As String
End Class
