using System.Text.Json.Serialization;

namespace CommonRates.Common.Ports.Binance.Responses;

public class BinanceDepthResponse
{
    [JsonPropertyName("lastUpdateId")] public long LastUpdateId { get; set; }

    [JsonPropertyName("bids")] public string[][] Bids { get; set; }

    [JsonPropertyName("asks")] public string[][] Asks { get; set; }
}