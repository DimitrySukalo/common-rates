using CommonRates.Common.Enums.Behaviours;

namespace CommonRates.Common.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class UrlParameterAttribute : Attribute
{
    public string Name { get; }
    
    public UrlParameterConvertingBehaviour Behaviour { get; }

    public UrlParameterAttribute(
        string name, 
        UrlParameterConvertingBehaviour behaviour = UrlParameterConvertingBehaviour.Default)
    {
        Name = name;
        Behaviour = behaviour;
    }
}