using CommonRates.Common.Enums.Errors;

namespace CommonRates.Common.Exceptions;

public class ApplicationErrorException : Exception
{
    public ApplicationErrorException(ApplicationError error) : base(((int)error).ToString())
    {
    }
}