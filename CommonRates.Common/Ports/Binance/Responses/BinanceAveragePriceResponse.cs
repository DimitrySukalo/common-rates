using System.Text.Json.Serialization;

namespace CommonRates.Common.Ports.Binance.Responses;

public class BinanceAveragePriceResponse
{
    [JsonPropertyName("mins")] public long Mins { get; set; }

    [JsonPropertyName("price")] public string Price { get; set; }

    [JsonPropertyName("closeTime")] public long CloseTime { get; set; }
}