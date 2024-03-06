using CommonRates.Binance.Helpers;
using CommonRates.Common.Attributes;

namespace CommonRates.Binance.Models.Requests;

public class GetBinanceDepthRequest
{
    [UrlParameter("symbol")] public string Symbol { get; }
    
    [UrlParameter("limit")] public int Limit { get; }

    public GetBinanceDepthRequest(string symbol, int limit)
    {
        BinanceValidationHelper.ValidateStringValue(symbol);
        BinanceValidationHelper.ValidateLimit(limit, 1, 5000);
        
        Symbol = symbol;
        Limit = limit;
    }
}