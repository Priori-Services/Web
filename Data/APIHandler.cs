using System.Text;
using System.Text.Json;

namespace PRIORI_SERVICES_WEB.Data.API;

public static class APIHandler
{
    public static async Task<T?> FetchAbstractJsonObjectAsync<T>(string target_url, string? api_endpoint = null)
    {
        if (api_endpoint == null)
            api_endpoint = DefaultConfig.API_ENDPOINT;

        string? response = await new HttpClient().GetStringAsync($"http://{api_endpoint}/{target_url}");

        MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(response));

        return await JsonSerializer.DeserializeAsync<T>(stream);
    }

    public static async Task<T> FetchOrFallbackAsync<T>(string target_url, T fallback_object)
    {
        T? initial_object;
        try
        {
            initial_object = await FetchAbstractJsonObjectAsync<T>(target_url);
        }
        catch (HttpRequestException)
        {
            initial_object = fallback_object;
        }
        if (initial_object == null)
        {
            return fallback_object;
        }
        return initial_object;
    }

    public static async Task<HttpContent> PostApiRequestAsync(Dictionary<string, string> json_object, string target_url, string? api_endpoint = null) {
        if (api_endpoint == null)
            api_endpoint = DefaultConfig.API_ENDPOINT;

        var content = new FormUrlEncodedContent(json_object);
        var response = await new HttpClient().PostAsync($"http://{api_endpoint}/{target_url}", content);
        return response.Content;
    }
}
