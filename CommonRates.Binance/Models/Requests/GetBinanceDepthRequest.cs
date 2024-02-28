using CommonRates.Common.Attributes;

namespace CommonRates.Binance.Models.Requests;

public class GetBinanceDepthRequest
{
    [UrlParameter("symbol")] public string Symbol { get; set; }
    
    [UrlParameter("limit")] public int Limit { get; set; }
}