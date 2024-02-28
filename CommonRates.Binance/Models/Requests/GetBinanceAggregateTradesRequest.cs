using CommonRates.Common.Attributes;

namespace CommonRates.Binance.Models.Requests;

public class GetBinanceAggregateTradesRequest
{
    [UrlParameter("symbol")] public string Symbol { get; set; }
    
    [UrlParameter("fromId")] public long FromId { get; set; } 
    
    [UrlParameter("startTime")] public long StartTime { get; set; } 
    
    [UrlParameter("endTime")] public long EndTime { get; set; } 
    
    [UrlParameter("limit")] public int Limit { get; set; }
}