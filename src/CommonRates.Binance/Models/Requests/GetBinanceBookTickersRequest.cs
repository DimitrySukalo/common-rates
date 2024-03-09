using CommonRates.Binance.Helpers;
using CommonRates.Common.Attributes;
using CommonRates.Common.Enums.Behaviours;

namespace CommonRates.Binance.Models.Requests;

public class GetBinanceBookTickersRequest
{
    [UrlParameter("symbols", UrlParameterConvertingBehaviour.BinanceArray)] 
    public string[] Symbols { get; }

    public GetBinanceBookTickersRequest(string[] symbols)
    {
        BinanceValidationHelper.ValidateSymbols(symbols);
        
        Symbols = symbols;
    }
}