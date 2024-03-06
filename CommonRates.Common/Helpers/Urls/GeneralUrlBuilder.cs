using System.Reflection;
using System.Text;
using CommonRates.Common.Attributes;
using CommonRates.Common.Classes.Urls;

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
            
            // Append parameter to the URL

            if (prop.GetValue(payload) is null)
            {
                continue;
            }
            
            urlBuilder.Append(isFirstParam ? "?" : "&");
            
            var behaviourHandler = new UrlBuilderBehaviourHandler<T>(attribute, prop, payload);

            var part = behaviourHandler.HandleBehaviour();

            urlBuilder.Append(part);

            isFirstParam = false;
        }

        return urlBuilder.ToString();
    }
}