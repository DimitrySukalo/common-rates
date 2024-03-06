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
    
    public Task<List<List<BinanceUiKlinesResponse>>> GetUiKlinesAsync(GetBinanceUiKlinesRequest request);
    
    public Task<List<BinanceTickerResponse>> GetTickerAsync(GetBinanceTickersRequest request);
    
    public Task<List<Binance24HoursTickerResponse>> Get24HoursTickerAsync(GetBinance24HoursTickersRequest request);
    
    public Task<List<BinanceBookTickerResponse>> GetBookTickerAsync(GetBinanceBookTickersRequest request);
    
    public Task<List<BinanceTickerPriceResponse>> GetTickerPriceAsync(GetBinanceTickerPriceRequest request);

    public Task<List<BinanceTradeResponse>> GetTradesAsync(GetBinanceTradesRequest request);
    
    public Task<BinanceTimeResponse> GetTimeAsync();
    
    public Task GetPingAsync();
}