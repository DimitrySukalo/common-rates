using CommonRates.Binance.Models.Requests;
using CommonRates.Binance.Models.Requests.Abstracts;
using CommonRates.Binance.Models.Responses;

namespace CommonRates.Binance.Contracts;

public interface IBinanceApiAdapter
{
    public Task<List<BinanceAggregateTradesResponse>> GetAggregateTradesAsync(GetBinanceAggregateTradesRequest request);
    
    public Task<List<BinanceAveragePriceResponse>> GetAveragePrice(GetBinanceAveragePriceRequest request);
    
    public Task<List<BinanceDepthResponse>> GetDepth(GetBinanceDepthRequest request);
    
    public Task<List<BinanceExchangeInfoResponse>> GetExchangeInfo(GetBinanceExchangeInfoAbstractRequest request);
}