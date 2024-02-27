using System.Reflection;
using System.Text;
using CommonRates.Common.Attributes;

namespace CommonRates.Common.Helpers.Urls;

public static class GeneralUrlBuilder
{
    public static string AppendUrlQueryParams<T>(T payload, string url)
    {
        var urlBuilder = new StringBuilder(url);

        // Check if the base URL already contains a query string
        var isFirstParam = !url.Contains('?');

        // Iterate through the properties of the class
        foreach (var prop in typeof(T).GetProperties())
        {
            // Get the custom attribute if exists
            var attribute = prop.GetCustomAttribute<UrlParameterAttribute>();

            // Determine the parameter name
            var paramName = attribute != null ? attribute.Name : prop.Name;

            // Append parameter to the URL
            urlBuilder.Append(isFirstParam ? "?" : "&");

            urlBuilder.Append($"{paramName}={prop.GetValue(payload)}");

            isFirstParam = false;
        }

        return urlBuilder.ToString();
    }
}