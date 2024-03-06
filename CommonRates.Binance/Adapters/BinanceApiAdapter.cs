using CommonRates.Binance.Contracts;
using CommonRates.Binance.Helpers;
using CommonRates.Binance.Models.Requests;
using CommonRates.Binance.Models.Requests.Abstracts;
using CommonRates.Binance.Models.Responses;
using CommonRates.Binance.Options;
using CommonRates.Common.Helpers.HttpClients;
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

    public async Task<BinanceAveragePriceResponse> GetAveragePriceAsync(GetBinanceAveragePriceRequest request)
    {
        var url = BinanceUrlBuilder.BuildAveragePriceUrl(_apiOptions.BaseUrl, request);
        
        return await HttpClientHelper.PerformJsonRequest<BinanceAveragePriceResponse>(
            async client => await client.GetAsync(url), _httpClient, _logger);
    }

    public async Task<BinanceDepthResponse> GetDepthAsync(GetBinanceDepthRequest request)
    {
        var url = BinanceUrlBuilder.BuildDepthUrl(_apiOptions.BaseUrl, request);
        
        return await HttpClientHelper.PerformJsonRequest<BinanceDepthResponse>(
            async client => await client.GetAsync(url), _httpClient, _logger);
    }

    public async Task<BinanceExchangeInfoResponse> GetExchangeInfoAsync(GetBinanceExchangeInfoAbstractRequest request)
    {
        var url = BinanceUrlBuilder.BuildExchangeInfoUrl(_apiOptions.BaseUrl, request);
        
        return await HttpClientHelper.PerformJsonRequest<BinanceExchangeInfoResponse>(
            async client => await client.GetAsync(url), _httpClient, _logger);
    }

    public async Task<List<List<BinanceKlinesResponse>>> GetKlinesAsync(GetBinanceKlinesRequest request)
    {
        var url = BinanceUrlBuilder.BuildKlinesUrl(_apiOptions.BaseUrl, request);
        
        return await HttpClientHelper.PerformJsonRequest<List<List<BinanceKlinesResponse>>>(
            async client => await client.GetAsync(url), _httpClient, _logger);
    }

    public async Task<List<BinanceTickerResponse>> GetKlinesAsync(GetBinanceTickerRequest request)
    {
        var url = BinanceUrlBuilder.BuildTickerUrl(_apiOptions.BaseUrl, request);
        
        return await HttpClientHelper.PerformJsonRequest<List<BinanceTickerResponse>>(
            async client => await client.GetAsync(url), _httpClient, _logger);
    }

    public async Task GetPingAsync()
    {
        var url = BinanceUrlBuilder.BuildPingUrl(_apiOptions.BaseUrl);
        
        await HttpClientHelper.PerformEmptyRequest(
            async client => await client.GetAsync(url), _httpClient, _logger);
    }
}