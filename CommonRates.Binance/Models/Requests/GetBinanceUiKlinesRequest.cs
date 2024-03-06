using CommonRates.Common.Attributes;

namespace CommonRates.Binance.Models.Requests;

public class GetBinanceUiKlinesRequest
{
    [UrlParameter("symbol")] public string Symbol { get; set; }
    
    [UrlParameter("interval")] public string Interval { get; set; } 
    
    [UrlParameter("startTime")] public long StartTime { get; set; } 
    
    [UrlParameter("endTime")] public long EndTime { get; set; } 
    
    [UrlParameter("timeZone")] public string TimeZone { get; set; } 
    
    [UrlParameter("limit")] public int Limit { get; set; }
}