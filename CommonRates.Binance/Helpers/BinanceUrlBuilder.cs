using CommonRates.Binance.Models.Requests;
using CommonRates.Binance.Models.Requests.Abstracts;
using CommonRates.Common.Helpers.Urls;

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
    
    public static string BuildKlinesUrl(string baseUrl, GetBinanceKlinesRequest request)
    {
        var url = $"{baseUrl}/api/v3/klines";

        return GeneralUrlBuilder.AppendUrlQueryParams(request, url);
    }
    
    public static string BuildUiKlinesUrl(string baseUrl, GetBinanceUiKlinesRequest request)
    {
        var url = $"{baseUrl}/api/v3/uiKlines";

        return GeneralUrlBuilder.AppendUrlQueryParams(request, url);
    }
    
    public static string BuildTickerUrl(string baseUrl, GetBinanceTickersRequest request)
    {
        var url = $"{baseUrl}/api/v3/ticker";

        return GeneralUrlBuilder.AppendUrlQueryParams(request, url);
    }
    
    public static string Build24HoursTickerUrl(string baseUrl, GetBinance24HoursTickersRequest request)
    {
        var url = $"{baseUrl}/api/v3/ticker/24hr";

        return GeneralUrlBuilder.AppendUrlQueryParams(request, url);
    }
    
    public static string BuildBookTickerUrl(string baseUrl, GetBinanceBookTickersRequest request)
    {
        var url = $"{baseUrl}/api/v3/ticker/bookTicker";

        return GeneralUrlBuilder.AppendUrlQueryParams(request, url);
    }
    
    public static string BuildTickerPriceUrl(string baseUrl, GetBinanceTickerPriceRequest request)
    {
        var url = $"{baseUrl}/api/v3/ticker/price";

        return GeneralUrlBuilder.AppendUrlQueryParams(request, url);
    }
    
    public static string BuildTradesUrl(string baseUrl, GetBinanceTradesRequest request)
    {
        var url = $"{baseUrl}/api/v3/trades";

        return GeneralUrlBuilder.AppendUrlQueryParams(request, url);
    }
    
    public static string BuildTimeUrl(string baseUrl)
    {
        return $"{baseUrl}/api/v3/time";
    }
    
    public static string BuildPingUrl(string baseUrl)
    {
        return $"{baseUrl}/api/v3/ping";
    }
}