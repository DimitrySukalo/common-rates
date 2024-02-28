using CommonRates.Common.Attributes;

namespace CommonRates.Common.Ports.Binance.Requests;

public class GetBinanceDepthRequest
{
    [UrlParameter("symbol")] public string Symbol { get; set; }
    
    [UrlParameter("limit")] public int Limit { get; set; }
}