using CommonRates.Binance.Adapters;
using CommonRates.Binance.Contracts;
using CommonRates.Binance.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CommonRates.Binance;

public static class DependencyInjection
{
    public static void AddBinance(this IServiceCollection services, IConfiguration configuration)
    { 
        services.Configure<BinanceApiOptions>(configuration.GetSection("Services:Binance"));
        
        services.AddHttpClient<IBinanceApiAdapter, BinanceApiAdapter>();
    }
}