using CommonRates.Binance.Options;
using CommonRates.Common.Helpers.HttpClients;
using CommonRates.Common.Ports.Binance;
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

    public async Task<List<BinanceRateResponse>> GetAllRates()
    {
        return await HttpClientHelper.PerformJsonRequest<List<BinanceRateResponse>>(
            async client => await client.GetAsync(_apiOptions.RatesUrl), _httpClient, _logger);
    }
}