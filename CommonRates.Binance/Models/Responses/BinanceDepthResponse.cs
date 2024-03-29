using System.Text.Json.Serialization;

namespace CommonRates.Binance.Models.Responses;

public class BinanceDepthResponse
{
    [JsonPropertyName("lastUpdateId")] public long LastUpdateId { get; set; }

    [JsonPropertyName("bids")] public string[][] Bids { get; set; }

    [JsonPropertyName("asks")] public string[][] Asks { get; set; }
}