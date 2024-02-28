using CommonRates.Common.Ports.Binance.Requests;
using CommonRates.Common.Ports.Binance.Responses;

namespace CommonRates.Common.Ports.Binance;

public interface IBinanceApiAdapter
{
    public Task<List<BinanceAggregateTradesResponse>> GetAggregateTradesAsync(GetBinanceAggregateTradesRequest request);
    
    public Task<List<BinanceAveragePriceResponse>> GetAveragePrice(GetBinanceAveragePriceRequest request);
    
    public Task<List<BinanceDepthResponse>> GetDepth(GetBinanceDepthRequest request);
}