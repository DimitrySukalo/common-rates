using CommonRates.Binance.Helpers;
using CommonRates.Common.Attributes;
using CommonRates.Common.Enums.Behaviours;

namespace CommonRates.Binance.Models.Requests;

public class GetBinance24HoursTickersRequest
{
    [UrlParameter("symbols", UrlParameterConvertingBehaviour.BinanceArray)] 
    public string[] Symbols { get; }
    
    [UrlParameter("type")]
    public string Type { get; }

    public GetBinance24HoursTickersRequest(
        string[] symbols, 
        string type = "FULL")
    {
        BinanceValidationHelper.ValidateSymbols(symbols);
        
        Symbols = symbols;
        Type = type;
    }
}