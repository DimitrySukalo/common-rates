using CommonRates.Binance.Helpers;
using CommonRates.Binance.Models.Requests.Abstracts;
using CommonRates.Common.Attributes;
using CommonRates.Common.Enums.Behaviours;

namespace CommonRates.Binance.Models.Requests;

public sealed class GetBinanceExchangeInfoWithSymbolsRequest : GetBinanceExchangeInfoAbstractRequest
{
    [UrlParameter("symbols", UrlParameterConvertingBehaviour.BinanceArray)] 
    public string[] Symbols { get; }

    public GetBinanceExchangeInfoWithSymbolsRequest(string[] symbols)
    {
        BinanceValidationHelper.ValidateSymbols(symbols);
        
        Symbols = symbols;
    }
}