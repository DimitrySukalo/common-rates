namespace CommonRates.Binance.Models.Responses;

public class BinanceUiKlinesResponse
{
    public BinanceUiKlinesField Field { get; set; }
}

public abstract class BinanceUiKlinesField { }

public class BinanceUiKlinesDecimalField : BinanceUiKlinesField
{
    public decimal Decimal { get; set; }
}

public class BinanceUiKlinesStringField : BinanceUiKlinesField
{
    public string String { get; set; }
}