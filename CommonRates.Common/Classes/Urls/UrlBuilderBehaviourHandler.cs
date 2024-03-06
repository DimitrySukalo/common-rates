using System.Reflection;
using CommonRates.Common.Attributes;
using CommonRates.Common.Enums.Behaviours;
using CommonRates.Common.Enums.Errors;
using CommonRates.Common.Exceptions;

namespace CommonRates.Common.Classes.Urls;

public class UrlBuilderBehaviourHandler<T>
{
    private UrlParameterAttribute Attribute { get; }
    
    private PropertyInfo Property { get; }

    private T Payload { get; }

    public UrlBuilderBehaviourHandler(UrlParameterAttribute attribute, PropertyInfo property, T payload)
    {
        Attribute = attribute;
        Property = property;
        Payload = payload;
    }
    
    public string HandleBehaviour()
    {
        return Attribute.Behaviour switch
        {
            UrlParameterConvertingBehaviour.Default => ProcessDefaultBehaviour(),
            UrlParameterConvertingBehaviour.BinanceArray => ProcessBinanceArrayBehaviour(),
            _ => throw new ApplicationErrorException(ApplicationError.UrlParameterBehaviourNotFound)
        };
    }

    private string ProcessDefaultBehaviour()
    {
        var paramName = Attribute != null ? Attribute.Name : Property.Name;

        return $"{paramName}={Property.GetValue(Payload)}";
    }
    
    private string ProcessBinanceArrayBehaviour()
    {
        var paramName = Attribute != null ? Attribute.Name : Property.Name;

        var value = Property.GetValue(Payload);

        if (value is not string[] array)
        {
            throw new ApplicationErrorException(ApplicationError.ValueIsNotArray);
        }
        
        var result = "[" + string.Join(", ", array.Select(n => $"\"{n}\"")) + "]";
            
        return $"{paramName}={result}";

    }
}