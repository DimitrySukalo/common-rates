using CommonRates.Binance.Helpers;
using CommonRates.Common.Attributes;
using CommonRates.Common.Enums.Behaviours;

namespace CommonRates.Binance.Models.Requests;

public class GetBinanceTickersRequest
{
    [UrlParameter("symbols", UrlParameterConvertingBehaviour.BinanceArray)] 
    public string[] Symbols { get; }
    
    [UrlParameter("windowSize")]
    public string WindowSize { get; }
    
    [UrlParameter("type")]
    public string Type { get; }

    public GetBinanceTickersRequest(
        string[] symbols, 
        string windowSize = "1d", 
        string type = "FULL")
    {
        BinanceValidationHelper.ValidateSymbols(symbols);
        
        Symbols = symbols;
        WindowSize = windowSize;
        Type = type;
    }
}