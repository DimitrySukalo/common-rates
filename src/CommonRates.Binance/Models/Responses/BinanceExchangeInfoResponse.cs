using System.Text.Json.Serialization;

namespace CommonRates.Binance.Models.Responses;

public class BinanceExchangeInfoResponse
{
    [JsonPropertyName("timezone")] public string Timezone { get; set; }

    [JsonPropertyName("serverTime")] public long ServerTime { get; set; }

    [JsonPropertyName("rateLimits")] public BinanceExchangeInfoRateLimit[] RateLimits { get; set; }

    [JsonPropertyName("exchangeFilters")] public object[] ExchangeFilters { get; set; }

    [JsonPropertyName("symbols")] public BinanceExchangeInfoSymbol[] Symbols { get; set; }
}

public class BinanceExchangeInfoRateLimit
{
    [JsonPropertyName("rateLimitType")] public string RateLimitType { get; set; }

    [JsonPropertyName("interval")] public string Interval { get; set; }

    [JsonPropertyName("intervalNum")] public long IntervalNum { get; set; }

    [JsonPropertyName("limit")] public long Limit { get; set; }
}

public class BinanceExchangeInfoSymbol
{
    [JsonPropertyName("symbol")] public string SymbolSymbol { get; set; }

    [JsonPropertyName("status")] public string Status { get; set; }

    [JsonPropertyName("baseAsset")] public string BaseAsset { get; set; }

    [JsonPropertyName("baseAssetPrecision")] public long BaseAssetPrecision { get; set; }

    [JsonPropertyName("quoteAsset")] public string QuoteAsset { get; set; }

    [JsonPropertyName("quotePrecision")] public long QuotePrecision { get; set; }

    [JsonPropertyName("quoteAssetPrecision")] public long QuoteAssetPrecision { get; set; }

    [JsonPropertyName("baseCommissionPrecision")] public long BaseCommissionPrecision { get; set; }

    [JsonPropertyName("quoteCommissionPrecision")] public long QuoteCommissionPrecision { get; set; }

    [JsonPropertyName("orderTypes")] public string[] OrderTypes { get; set; }

    [JsonPropertyName("icebergAllowed")] public bool IcebergAllowed { get; set; }

    [JsonPropertyName("ocoAllowed")] public bool OcoAllowed { get; set; }

    [JsonPropertyName("quoteOrderQtyMarketAllowed")] public bool QuoteOrderQtyMarketAllowed { get; set; }

    [JsonPropertyName("allowTrailingStop")] public bool AllowTrailingStop { get; set; }

    [JsonPropertyName("cancelReplaceAllowed")] public bool CancelReplaceAllowed { get; set; }

    [JsonPropertyName("isSpotTradingAllowed")] public bool IsSpotTradingAllowed { get; set; }

    [JsonPropertyName("isMarginTradingAllowed")] public bool IsMarginTradingAllowed { get; set; }

    [JsonPropertyName("filters")] public BinanceExchangeInfoFilter[] Filters { get; set; }

    [JsonPropertyName("permissions")] public string[] Permissions { get; set; }

    [JsonPropertyName("defaultSelfTradePreventionMode")] public string DefaultSelfTradePreventionMode { get; set; }

    [JsonPropertyName("allowedSelfTradePreventionModes")] public string[] AllowedSelfTradePreventionModes { get; set; }
}

public class BinanceExchangeInfoFilter
{
    [JsonPropertyName("filterType")]
    public string FilterType { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minPrice")]
    public string MinPrice { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxPrice")]
    public string MaxPrice { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tickSize")]
    public string TickSize { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minQty")]
    public string MinQty { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxQty")]
    public string MaxQty { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stepSize")]
    public string StepSize { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minTrailingAboveDelta")]
    public long? MinTrailingAboveDelta { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxTrailingAboveDelta")]
    public long? MaxTrailingAboveDelta { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minTrailingBelowDelta")]
    public long? MinTrailingBelowDelta { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxTrailingBelowDelta")]
    public long? MaxTrailingBelowDelta { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bidMultiplierUp")]
    public string BidMultiplierUp { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bidMultiplierDown")]
    public string BidMultiplierDown { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("askMultiplierUp")]
    public string AskMultiplierUp { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("askMultiplierDown")]
    public string AskMultiplierDown { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avgPriceMins")]
    public long? AvgPriceMins { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minNotional")]
    public string MinNotional { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applyMinToMarket")]
    public bool? ApplyMinToMarket { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxNotional")]
    public string MaxNotional { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applyMaxToMarket")]
    public bool? ApplyMaxToMarket { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxNumOrders")]
    public long? MaxNumOrders { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxNumAlgoOrders")]
    public long? MaxNumAlgoOrders { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxPosition")]
    public string MaxPosition { get; set; }
}