using CommonRates.Binance.Helpers;
using CommonRates.Common.Attributes;

namespace CommonRates.Binance.Models.Requests;

public class GetBinanceAggregateTradesRequest
{
    [UrlParameter("symbol")] public string Symbol { get; }
    
    [UrlParameter("fromId")] public long? FromId { get; } 
    
    [UrlParameter("startTime")] public long? StartTime { get; } 
    
    [UrlParameter("endTime")] public long? EndTime { get; } 
    
    [UrlParameter("limit")] public int? Limit { get; }

    public GetBinanceAggregateTradesRequest(
        string symbol, 
        long? fromId, 
        long? startTime, 
        long? endTime, 
        int? limit = 500)
    {
        BinanceValidationHelper.ValidateStringValue(symbol);
        BinanceValidationHelper.ValidateLimit(limit, 1, 1000);

        Symbol = symbol;
        FromId = fromId;
        StartTime = startTime;
        EndTime = endTime;
        Limit = limit;
    }
}