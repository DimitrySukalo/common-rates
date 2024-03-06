using CommonRates.Binance.Models.Requests;
using CommonRates.Binance.Models.Requests.Abstracts;
using CommonRates.Binance.Models.Responses;

namespace CommonRates.Binance.Contracts;

public interface IBinanceApiAdapter
{
    public Task<List<BinanceAggregateTradesResponse>> GetAggregateTradesAsync(GetBinanceAggregateTradesRequest request);
    
    public Task<BinanceAveragePriceResponse> GetAveragePriceAsync(GetBinanceAveragePriceRequest request);
    
    public Task<BinanceDepthResponse> GetDepthAsync(GetBinanceDepthRequest request);
    
    public Task<BinanceExchangeInfoResponse> GetExchangeInfoAsync(GetBinanceExchangeInfoAbstractRequest request);
    
    public Task<List<List<BinanceKlinesResponse>>> GetKlinesAsync(GetBinanceKlinesRequest request);
    
    public Task<List<BinanceTickerResponse>> GetKlinesAsync(GetBinanceTickerRequest request);
    
    public Task GetPingAsync();
}