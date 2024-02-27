namespace CommonRates.Common.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class UrlParameterAttribute : Attribute
{
    public string Name { get; }

    public UrlParameterAttribute(string name)
    {
        Name = name;
    }
}