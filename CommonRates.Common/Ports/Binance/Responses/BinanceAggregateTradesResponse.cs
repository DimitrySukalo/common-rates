using System.Text.Json.Serialization;

namespace CommonRates.Common.Ports.Binance.Responses;

public class BinanceAggregateTradesResponse
{
    [JsonPropertyName("a")] public long A { get; set; }

    [JsonPropertyName("p")] public string P { get; set; }

    [JsonPropertyName("q")] public string Q { get; set; }

    [JsonPropertyName("f")] public long F { get; set; }

    [JsonPropertyName("l")] public long L { get; set; }

    [JsonPropertyName("T")] public long T { get; set; }

    [JsonPropertyName("m")] public bool TemperatureM { get; set; }

    [JsonPropertyName("M")] public bool M { get; set; }
}