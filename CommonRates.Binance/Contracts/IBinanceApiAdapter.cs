using CommonRates.Binance.Models.Requests;
using CommonRates.Binance.Models.Requests.Abstracts;
using CommonRates.Binance.Models.Responses;

namespace CommonRates.Binance.Contracts;

public interface IBinanceApiAdapter
{
    public Task<List<BinanceAggregateTradesResponse>> GetAggregateTradesAsync(GetBinanceAggregateTradesRequest request);
    
    public Task<BinanceAveragePriceResponse> GetAveragePrice(GetBinanceAveragePriceRequest request);
    
    public Task<BinanceDepthResponse> GetDepth(GetBinanceDepthRequest request);
    
    public Task<BinanceExchangeInfoResponse> GetExchangeInfo(GetBinanceExchangeInfoAbstractRequest request);
    
    public Task<List<List<BinanceKlinesResponse>>> GetKlines(GetBinanceKlinesRequest request);
}