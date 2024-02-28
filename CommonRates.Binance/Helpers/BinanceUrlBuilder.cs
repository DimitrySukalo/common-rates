using CommonRates.Common.Helpers.Urls;
using CommonRates.Common.Ports.Binance.Requests;
using CommonRates.Common.Ports.Binance.Requests.Abstracts;

namespace CommonRates.Binance.Helpers;

public static class BinanceUrlBuilder
{
    public static string BuildAggregateTradesUrl(string baseUrl, GetBinanceAggregateTradesRequest request)
    {
        var url = $"{baseUrl}/api/v3/aggTrades";

        return GeneralUrlBuilder.AppendUrlQueryParams(request, url);
    }
    
    public static string BuildAveragePriceUrl(string baseUrl, GetBinanceAveragePriceRequest request)
    {
        var url = $"{baseUrl}/api/v3/avgPrice";

        return GeneralUrlBuilder.AppendUrlQueryParams(request, url);
    }
    
    public static string BuildDepthUrl(string baseUrl, GetBinanceDepthRequest request)
    {
        var url = $"{baseUrl}/api/v3/depth";

        return GeneralUrlBuilder.AppendUrlQueryParams(request, url);
    }
    
    public static string BuildExchangeInfoUrl(string baseUrl, GetBinanceExchangeInfoAbstractRequest request)
    {
        var url = $"{baseUrl}/api/v3/exchangeInfo";

        return GeneralUrlBuilder.AppendUrlQueryParams(request, url);
    }
}