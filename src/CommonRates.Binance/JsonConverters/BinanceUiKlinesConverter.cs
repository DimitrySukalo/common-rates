using System.Text.Json;
using System.Text.Json.Serialization;
using CommonRates.Binance.Models.Responses;
using CommonRates.Common.Enums.Errors;
using CommonRates.Common.Exceptions;

namespace CommonRates.Binance.JsonConverters;

public class BinanceUiKlinesConverter : JsonConverter<BinanceUiKlinesResponse>
{
    public override BinanceUiKlinesResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        switch (reader.TokenType)
        {
            case JsonTokenType.Number:
                var decimalValue = reader.GetDecimal();
                return new BinanceUiKlinesResponse { Field = new BinanceUiKlinesDecimalField {Decimal = decimalValue} };
            case JsonTokenType.String:
                var stringValue = reader.GetString();
                return new BinanceUiKlinesResponse { Field = new BinanceUiKlinesStringField {String = stringValue} };
        }

        throw new ApplicationErrorException(ApplicationError.CannotReadKlinesResponse);
    }

    public override void Write(Utf8JsonWriter writer, BinanceUiKlinesResponse value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}