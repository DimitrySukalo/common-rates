using CommonRates.Common.Helpers.Urls;
using CommonRates.Common.Ports.Binance.Requests;

namespace CommonRates.Binance.Helpers;

public static class BinanceUrlBuilder
{
    public static string BuildAggregateTradesUrl(string baseUrl, GetAggregateTradesRequest request)
    {
        var url = $"{baseUrl}/api/v3/aggTrades";

        return GeneralUrlBuilder.AppendUrlQueryParams(request, url);
    }
}