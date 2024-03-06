using System.Text.Json.Serialization;

namespace CommonRates.Binance.Models.Responses;

public class BinanceTimeResponse
{
    [JsonPropertyName("serverTime")] public long ServerTime { get; set; }
}