using System.Text.Json;
using CommonRates.Binance.Contracts;
using CommonRates.Binance.Helpers;
using CommonRates.Binance.JsonConverters;
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

        var options = new JsonSerializerOptions
        {
            Converters = {new BinanceKlinesConverter()}
        };
        
        return await HttpClientHelper.PerformJsonRequest<List<List<BinanceKlinesResponse>>>(
            async client => await client.GetAsync(url), _httpClient, _logger, options);
    }

    public async Task<List<List<BinanceUiKlinesResponse>>> GetUiKlinesAsync(GetBinanceUiKlinesRequest request)
    {
        var url = BinanceUrlBuilder.BuildUiKlinesUrl(_apiOptions.BaseUrl, request);

        var options = new JsonSerializerOptions
        {
            Converters = {new BinanceUiKlinesConverter()}
        };
        
        return await HttpClientHelper.PerformJsonRequest<List<List<BinanceUiKlinesResponse>>>(
            async client => await client.GetAsync(url), _httpClient, _logger, options);
    }

    public async Task<List<BinanceTickerResponse>> GetTickerAsync(GetBinanceTickersRequest request)
    {
        var url = BinanceUrlBuilder.BuildTickerUrl(_apiOptions.BaseUrl, request);
        
        return await HttpClientHelper.PerformJsonRequest<List<BinanceTickerResponse>>(
            async client => await client.GetAsync(url), _httpClient, _logger);
    }

    public async Task<List<Binance24HoursTickerResponse>> Get24HoursTickerAsync(GetBinance24HoursTickersRequest request)
    {
        var url = BinanceUrlBuilder.Build24HoursTickerUrl(_apiOptions.BaseUrl, request);
        
        return await HttpClientHelper.PerformJsonRequest<List<Binance24HoursTickerResponse>>(
            async client => await client.GetAsync(url), _httpClient, _logger);
    }

    public async Task<List<BinanceBookTickerResponse>> GetBookTickerAsync(GetBinanceBookTickersRequest request)
    {
        var url = BinanceUrlBuilder.BuildBookTickerUrl(_apiOptions.BaseUrl, request);
        
        return await HttpClientHelper.PerformJsonRequest<List<BinanceBookTickerResponse>>(
            async client => await client.GetAsync(url), _httpClient, _logger);
    }

    public async Task<List<BinanceTickerPriceResponse>> GetTickerPriceAsync(GetBinanceTickerPriceRequest request)
    {
        var url = BinanceUrlBuilder.BuildTickerPriceUrl(_apiOptions.BaseUrl, request);
        
        return await HttpClientHelper.PerformJsonRequest<List<BinanceTickerPriceResponse>>(
            async client => await client.GetAsync(url), _httpClient, _logger);
    }

    public async Task<List<BinanceTradeResponse>> GetTradesAsync(GetBinanceTradesRequest request)
    {
        var url = BinanceUrlBuilder.BuildTradesUrl(_apiOptions.BaseUrl, request);
        
        return await HttpClientHelper.PerformJsonRequest<List<BinanceTradeResponse>>(
            async client => await client.GetAsync(url), _httpClient, _logger);
    }

    public async Task<BinanceTimeResponse> GetTimeAsync()
    {
        var url = BinanceUrlBuilder.BuildTimeUrl(_apiOptions.BaseUrl);
        
        return await HttpClientHelper.PerformJsonRequest<BinanceTimeResponse>(
            async client => await client.GetAsync(url), _httpClient, _logger);
    }

    public async Task GetPingAsync()
    {
        var url = BinanceUrlBuilder.BuildPingUrl(_apiOptions.BaseUrl);
        
        await HttpClientHelper.PerformEmptyRequest(
            async client => await client.GetAsync(url), _httpClient, _logger);
    }
}