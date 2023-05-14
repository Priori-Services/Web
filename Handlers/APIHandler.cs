using System.Text;
using System.Text.Json;

namespace PRIORI_SERVICES_WEB.Data.API;

public static class APIHandler
{
    private static string api_endpoint { get; set; } = DefaultConfig.API_ENDPOINT;
    public static HttpClient static_client = new HttpClient(); 

    public static async Task<T?> FetchAbstractJsonObjectAsync<T>(string target_url)
    {
        string? response = await static_client.GetStringAsync($"http://{api_endpoint}/api{target_url}");

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

    public static async Task<HttpResponseMessage> PostApiRequestAsync(Dictionary<string, string> json_object, string target_url)
    {

        string json_string = Encoding.UTF8.GetString(
            JsonSerializer.SerializeToUtf8Bytes(json_object)
        );

        var content = new StringContent(
            json_string, 
            UnicodeEncoding.UTF8, 
            "application/json"
        );


        var response = await static_client.PostAsync(
            $"http://{api_endpoint}/api{target_url}", 
            content
        );

        return response;
    }
}
