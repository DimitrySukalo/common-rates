using System.Text.Json.Serialization;

namespace CommonRates.Binance.Models.Responses;

public class BinanceTradeResponse
{
    [JsonPropertyName("id")] public long Id { get; set; }

    [JsonPropertyName("price")] public string Price { get; set; }

    [JsonPropertyName("qty")] public string Qty { get; set; }

    [JsonPropertyName("quoteQty")] public string QuoteQty { get; set; }

    [JsonPropertyName("time")] public long Time { get; set; }

    [JsonPropertyName("isBuyerMaker")] public bool IsBuyerMaker { get; set; }

    [JsonPropertyName("isBestMatch")] public bool IsBestMatch { get; set; }
}