using CommonRates.Binance.Helpers;
using CommonRates.Binance.Options;
using CommonRates.Common.Helpers.HttpClients;
using CommonRates.Common.Ports.Binance;
using CommonRates.Common.Ports.Binance.Requests;
using CommonRates.Common.Ports.Binance.Responses;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CommonRates.Binance.Adapters;

public class BinanceApiAdapter : IBinanceApiAdapter
{
    private readonly HttpClient _httpClient;
    private readonly BinanceApiOptions _apiOptions;
    private readonly ILogger<BinanceApiAdapter> _logger;

    public BinanceApiAdapter(
        HttpClient httpClient, 
        IOptions<BinanceApiOptions> apiOptions, 
        ILogger<BinanceApiAdapter> logger)
    {
        _httpClient = httpClient;
        _apiOptions = apiOptions.Value;
        _logger = logger;
    }
    
    public async Task<List<BinanceAggregateTradesResponse>> GetAggregateTradesAsync(GetBinanceAggregateTradesRequest request)
    {
        var url = BinanceUrlBuilder.BuildAggregateTradesUrl(_apiOptions.BaseUrl, request);
        
        return await HttpClientHelper.PerformJsonRequest<List<BinanceAggregateTradesResponse>>(
            async client => await client.GetAsync(url), _httpClient, _logger);
    }

    public async Task<List<BinanceAveragePriceResponse>> GetAveragePrice(GetBinanceAveragePriceRequest request)
    {
        var url = BinanceUrlBuilder.BuildAveragePriceUrl(_apiOptions.BaseUrl, request);
        
        return await HttpClientHelper.PerformJsonRequest<List<BinanceAveragePriceResponse>>(
            async client => await client.GetAsync(url), _httpClient, _logger);
    }

    public async Task<List<BinanceDepthResponse>> GetDepth(GetBinanceDepthRequest request)
    {
        var url = BinanceUrlBuilder.BuildDepthUrl(_apiOptions.BaseUrl, request);
        
        return await HttpClientHelper.PerformJsonRequest<List<BinanceDepthResponse>>(
            async client => await client.GetAsync(url), _httpClient, _logger);
    }
}