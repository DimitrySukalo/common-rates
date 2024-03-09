using System.Text.Json;
using System.Text.Json.Serialization;
using CommonRates.Binance.Models.Responses;
using CommonRates.Common.Enums.Errors;
using CommonRates.Common.Exceptions;

namespace CommonRates.Binance.JsonConverters;

public class BinanceKlinesConverter : JsonConverter<BinanceKlinesResponse>
{
    public override BinanceKlinesResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        switch (reader.TokenType)
        {
            case JsonTokenType.Number:
                var decimalValue = reader.GetDecimal();
                return new BinanceKlinesResponse { Field = new BinanceKlinesDecimalField {Decimal = decimalValue} };
            case JsonTokenType.String:
                var stringValue = reader.GetString();
                return new BinanceKlinesResponse { Field = new BinanceKlinesStringField {String = stringValue} };
        }

        throw new ApplicationErrorException(ApplicationError.CannotReadKlinesResponse);
    }

    public override void Write(Utf8JsonWriter writer, BinanceKlinesResponse value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}