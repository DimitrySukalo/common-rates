using System.Text.Json.Serialization;

namespace CommonRates.Binance.Models.Responses;

public class BinanceBookTickerResponse
{
    [JsonPropertyName("symbol")] public string Symbol { get; set; }

    [JsonPropertyName("bidPrice")] public string BidPrice { get; set; }

    [JsonPropertyName("bidQty")] public string BidQty { get; set; }

    [JsonPropertyName("askPrice")] public string AskPrice { get; set; }

    [JsonPropertyName("askQty")] public string AskQty { get; set; }
}