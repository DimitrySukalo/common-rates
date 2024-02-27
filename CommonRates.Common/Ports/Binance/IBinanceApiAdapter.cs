using CommonRates.Common.Ports.Binance.Requests;
using CommonRates.Common.Ports.Binance.Responses;

namespace CommonRates.Common.Ports.Binance;

public interface IBinanceApiAdapter
{
    public Task<List<BinanceAggregateTradesResponse>> GetAggregateTradesAsync(GetAggregateTradesRequest request);
}