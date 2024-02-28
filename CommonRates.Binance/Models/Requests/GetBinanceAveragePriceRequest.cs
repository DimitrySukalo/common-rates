using CommonRates.Common.Attributes;

namespace CommonRates.Binance.Models.Requests;

public abstract class GetBinanceAveragePriceRequest
{
    [UrlParameter("symbol")] public string Symbol { get; set; }
}