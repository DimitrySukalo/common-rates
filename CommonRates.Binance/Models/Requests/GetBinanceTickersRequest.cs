using CommonRates.Common.Attributes;
using CommonRates.Common.Enums.Behaviours;

namespace CommonRates.Binance.Models.Requests;

public class GetBinanceTickersRequest
{
    [UrlParameter("symbols", UrlParameterConvertingBehaviour.BinanceArray)] 
    public string[] Symbols { get; set; }
    
    [UrlParameter("windowSize")]
    public string WindowSize { get; set; }
    
    [UrlParameter("type")]
    public string Type { get; set; }
}