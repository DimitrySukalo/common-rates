using CommonRates.Common.Ports.Binance.Responses;

namespace CommonRates.Common.Ports.Binance;

public interface IBinanceApiAdapter
{
    public Task<List<BinanceRateResponse>> GetAllRates();
}