using System.Text.Json.Serialization;

namespace CommonRates.Binance.Models.Responses;

public class BinanceTickerPriceResponse
{
    [JsonPropertyName("symbol")] public string Symbol { get; set; }

    [JsonPropertyName("price")] public string Price { get; set; }
}