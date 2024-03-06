using CommonRates.Binance.Helpers;
using CommonRates.Common.Attributes;

namespace CommonRates.Binance.Models.Requests;

public class GetBinanceUiKlinesRequest
{
    [UrlParameter("symbol")] public string Symbol { get; }
    
    [UrlParameter("interval")] public string Interval { get; } 
    
    [UrlParameter("startTime")] public long? StartTime { get; } 
    
    [UrlParameter("endTime")] public long? EndTime { get; } 
    
    [UrlParameter("timeZone")] public string TimeZone { get; } 
    
    [UrlParameter("limit")] public int? Limit { get; }
    
    public GetBinanceUiKlinesRequest(
        string symbol, 
        string interval, 
        long? startTime, 
        long? endTime, 
        string timeZone = "0", 
        int? limit = 500)
    {
        BinanceValidationHelper.ValidateStringValue(symbol);
        BinanceValidationHelper.ValidateStringValue(interval);
        BinanceValidationHelper.ValidateLimit(limit, 1, 1000);

        Symbol = symbol;
        Interval = interval;
        StartTime = startTime;
        EndTime = endTime;
        TimeZone = timeZone;
        Limit = limit;
    }
}