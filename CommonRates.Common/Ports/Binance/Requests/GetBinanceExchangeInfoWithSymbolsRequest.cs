using CommonRates.Common.Attributes;
using CommonRates.Common.Attributes.Behaviours;
using CommonRates.Common.Ports.Binance.Requests.Abstracts;

namespace CommonRates.Common.Ports.Binance.Requests;

public sealed class GetBinanceExchangeInfoWithSymbolsRequest : GetBinanceExchangeInfoAbstractRequest
{
    [UrlParameter("symbols", UrlParameterConvertingBehaviour.BinanceArray)] 
    public string[] Symbols { get; set; }
}