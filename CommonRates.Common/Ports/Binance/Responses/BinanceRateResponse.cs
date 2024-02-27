using System.Text.Json.Serialization;

namespace CommonRates.Common.Ports.Binance.Responses;

public class BinanceRateResponse
{
    [JsonPropertyName("symbol")] public string Symbol { get; set; }
    
    [JsonPropertyName("lastPrice")] public string LastPrice { get; set; }
    
    [JsonPropertyName("priceChange")] public string PriceChange { get; set; }
    
    [JsonPropertyName("priceChangePercent")] public string PriceChangePercent { get; set; }
    
    [JsonPropertyName("weightedAvgPrice")] public string WeightedAvgPrice { get; set; }
    
    [JsonPropertyName("prevClosePrice")] public string PrevClosePrice { get; set; }
    
    [JsonPropertyName("lastQty")] public string LastQty { get; set; }
    
    [JsonPropertyName("bidPrice")] public string BidPrice { get; set; }
    
    [JsonPropertyName("bidQty")] public string BidQty { get; set; }
    
    [JsonPropertyName("askPrice")] public string AskPrice { get; set; }
    
    [JsonPropertyName("askQty")] public string AskQty { get; set; }
    
    [JsonPropertyName("openPrice")] public string OpenPrice { get; set; }
    
    [JsonPropertyName("highPrice")] public string HighPrice { get; set; }
    
    [JsonPropertyName("lowPrice")] public string LowPrice { get; set; }
    
    [JsonPropertyName("volume")] public string Volume { get; set; }
    
    [JsonPropertyName("quoteVolume")] public string QuoteVolume { get; set; }
    
    [JsonPropertyName("openTime")] public object OpenTime { get; set; }
    
    [JsonPropertyName("closeTime")] public object CloseTime { get; set; }
    
    [JsonPropertyName("firstId")] public long FirstId { get; set; }
    
    [JsonPropertyName("lastId")] public long LastId { get; set; }
    
    [JsonPropertyName("count")] public int Count { get; set; }
}