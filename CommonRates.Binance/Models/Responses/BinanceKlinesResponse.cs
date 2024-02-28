namespace CommonRates.Binance.Models.Responses;

public class BinanceKlinesResponse
{
    public BinanceKlinesField Field { get; set; }
}

public abstract class BinanceKlinesField { }

public class BinanceKlinesDecimalField : BinanceKlinesField
{
    public decimal Decimal { get; set; }
}

public class BinanceKlinesStringField : BinanceKlinesField
{
    public string String { get; set; }
}