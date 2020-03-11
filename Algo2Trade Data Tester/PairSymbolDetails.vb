<Serializable>
Public Class PairSymbolDetails
    Public Property Instrument1AutoSelectTradingSymbol As Boolean
    Public Property Instrument1Table As Integer
    Public Property Instrument1Name As String
    Public Property Instrument1Token As String
    Public Property Instrument1StartingColumn As Integer
    Public Property Instrument1LotSize As Integer
    Public Property Instrument1NumberOfLots As Integer
    Public Property Instrument1Brokerage As Decimal

    Public Property Instrument2AutoSelectTradingSymbol As Boolean
    Public Property Instrument2Table As Integer
    Public Property Instrument2Name As String
    Public Property Instrument2Token As String
    Public Property Instrument2StartingColumn As Integer
    Public Property Instrument2LotSize As Integer
    Public Property Instrument2NumberOfLots As Integer
    Public Property Instrument2Brokerage As Decimal

    Public Property FromDate As Date
    Public Property ToDate As Date
    Public Property TimeFrame As String
    Public Property ExchangeStartTime As Date
    Public Property TemplateFilePath As String
End Class
