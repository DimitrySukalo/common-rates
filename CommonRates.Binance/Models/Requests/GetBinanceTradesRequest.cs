using CommonRates.Binance.Helpers;
using CommonRates.Common.Attributes;

namespace CommonRates.Binance.Models.Requests;

public class GetBinanceTradesRequest
{
    [UrlParameter("symbol")] public string Symbol { get; }

    [UrlParameter("limit")] public int Limit { get; }

    public GetBinanceTradesRequest(
        string symbol, 
        int limit = 500)
    {
        BinanceValidationHelper.ValidateStringValue(symbol);
        BinanceValidationHelper.ValidateLimit(limit, 1, 1000);
        
        Symbol = symbol;
        Limit = limit;
    }
}