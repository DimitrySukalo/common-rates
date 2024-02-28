using System.Reflection;
using CommonRates.Common.Attributes;
using CommonRates.Common.Enums.Behaviours;

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
            _ => throw new ArgumentOutOfRangeException($"Unknown url build behaviour: {Attribute.Behaviour}.")
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
            throw new Exception();
        }
        
        var result = "[" + string.Join(", ", array.Select(n => $"\"{n}\"")) + "]";
            
        return $"{paramName}={result}";

    }
}