using CommonRates.Binance.Helpers;
using CommonRates.Binance.Models.Requests.Abstracts;
using CommonRates.Common.Attributes;
using CommonRates.Common.Enums.Behaviours;

namespace CommonRates.Binance.Models.Requests;

public sealed class GetBinanceExchangeInfoWithPermissionsRequest : GetBinanceExchangeInfoAbstractRequest
{
    [UrlParameter("permissions", UrlParameterConvertingBehaviour.BinanceArray)] 
    public string[] Permissions { get; }

    public GetBinanceExchangeInfoWithPermissionsRequest(string[] permissions)
    {
        BinanceValidationHelper.ValidatePermissions(permissions);
        
        Permissions = permissions;
    }
}