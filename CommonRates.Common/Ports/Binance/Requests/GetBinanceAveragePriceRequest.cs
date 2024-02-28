using CommonRates.Common.Attributes;

namespace CommonRates.Common.Ports.Binance.Requests;

public abstract class GetBinanceAveragePriceRequest
{
    [UrlParameter("symbol")] public string Symbol { get; set; }
}