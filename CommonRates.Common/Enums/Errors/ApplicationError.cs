namespace CommonRates.Common.Enums.Errors;

public enum ApplicationError
{
    #region General

    UrlParameterBehaviourNotFound = RequestErrorCode.General + 1,
    ValueIsNotArray,
    ValueIsNotValid,

    #endregion

    #region Binance

    CannotReadKlinesResponse = RequestErrorCode.Binance + 1,

    #endregion
}