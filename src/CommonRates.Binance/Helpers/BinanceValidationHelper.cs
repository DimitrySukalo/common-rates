using CommonRates.Common.Enums.Errors;
using CommonRates.Common.Exceptions;

namespace CommonRates.Binance.Helpers;

public static class BinanceValidationHelper
{
    public static void ValidateLimit(int? limit, int min, int max)
    {
        if (limit.HasValue && (limit.Value < min || limit.Value > max))
        {
            throw new ApplicationErrorException(ApplicationError.ValueIsNotValid);
        }
    }
    
    public static void ValidateStringValue(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ApplicationErrorException(ApplicationError.ValueIsNotValid);
        }
    }
    
    public static void ValidateSymbols(string[] symbol)
    {
        if (symbol.Length <= 0)
        {
            throw new ApplicationErrorException(ApplicationError.ValueIsNotValid);
        }
    }
    
    public static void ValidatePermissions(string[] permissions)
    {
        if (permissions.Length <= 0)
        {
            throw new ApplicationErrorException(ApplicationError.ValueIsNotValid);
        }
    }
}