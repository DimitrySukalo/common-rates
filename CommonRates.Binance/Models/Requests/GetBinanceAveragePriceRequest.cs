using CommonRates.Binance.Helpers;
using CommonRates.Common.Attributes;

namespace CommonRates.Binance.Models.Requests;

public class GetBinanceAveragePriceRequest
{
    [UrlParameter("symbol")] public string Symbol { get; }

    public GetBinanceAveragePriceRequest(string symbol)
    {
        BinanceValidationHelper.ValidateStringValue(symbol);
        
        Symbol = symbol;
    }
}