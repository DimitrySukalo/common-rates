using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace CommonRates.Common.Helpers.HttpClients;

public static class HttpClientHelper
{
    public static async Task<T> PerformJsonRequest<T>(
        Func<HttpClient, Task<HttpResponseMessage>> request, 
        HttpClient httpClient, 
        ILogger logger, 
        JsonSerializerOptions options = null)
    {
        HttpResponseMessage response;
        try
        {
            response = await request.Invoke(httpClient);
        }
        catch (Exception e)
        {
            throw new ValidationException($"Api server response error. Message: {e.Message}");
        }

        if (response.IsSuccessStatusCode)
        {
            options ??= new JsonSerializerOptions();
            
            await using var stream = await response.Content.ReadAsStreamAsync();
            
            return await JsonSerializer.DeserializeAsync<T>(stream, options);
        }
        
        var error = await response.Content.ReadAsStringAsync();
        
        logger.LogInformation(
            "Error request to api {@request}. Response code: {@statusCode}. Response body: {@response}.", 
            request, response.StatusCode, error);
        
        throw new ValidationException(
            $"Error request to api. Response code: {response.StatusCode}. Response body: {error}.");
    }
}