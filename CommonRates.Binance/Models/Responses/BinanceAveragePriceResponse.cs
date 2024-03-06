using System.Text.Json.Serialization;

namespace CommonRates.Binance.Models.Responses;

public class BinanceAveragePriceResponse
{
    [JsonPropertyName("mins")] public long Mins { get; set; }

    [JsonPropertyName("price")] public string Price { get; set; }

    [JsonPropertyName("closeTime")] public long CloseTime { get; set; }
}