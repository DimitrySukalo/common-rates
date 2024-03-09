using System.Text.Json.Serialization;

namespace CommonRates.Binance.Models.Responses;

public class BinanceTickerResponse
{
    [JsonPropertyName("symbol")] public string Symbol { get; set; }

    [JsonPropertyName("priceChange")] public string PriceChange { get; set; }

    [JsonPropertyName("priceChangePercent")] public string PriceChangePercent { get; set; }

    [JsonPropertyName("weightedAvgPrice")] public string WeightedAvgPrice { get; set; }

    [JsonPropertyName("openPrice")] public string OpenPrice { get; set; }

    [JsonPropertyName("highPrice")] public string HighPrice { get; set; }

    [JsonPropertyName("lowPrice")] public string LowPrice { get; set; }

    [JsonPropertyName("lastPrice")] public string LastPrice { get; set; }

    [JsonPropertyName("volume")] public string Volume { get; set; }

    [JsonPropertyName("quoteVolume")] public string QuoteVolume { get; set; }

    [JsonPropertyName("openTime")] public long OpenTime { get; set; }

    [JsonPropertyName("closeTime")] public long CloseTime { get; set; }

    [JsonPropertyName("firstId")] public long FirstId { get; set; }

    [JsonPropertyName("lastId")] public long LastId { get; set; }

    [JsonPropertyName("count")] public long Count { get; set; }
}