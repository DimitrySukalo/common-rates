using CommonRates.Common.Attributes;
using CommonRates.Common.Attributes.Behaviours;
using CommonRates.Common.Ports.Binance.Requests.Abstracts;

namespace CommonRates.Common.Ports.Binance.Requests;

public sealed class GetBinanceExchangeInfoWithPermissionsRequest : GetBinanceExchangeInfoAbstractRequest
{
    [UrlParameter("permissions", UrlParameterConvertingBehaviour.BinanceArray)] 
    public string[] Permissions { get; set; }
}