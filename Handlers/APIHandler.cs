using System.Text;
using System.Text.Json;
using System.Net.Http.Headers;

namespace PRIORI_SERVICES_WEB.Handler;

public static class APIHandler
{
    public static string Api_endpoint { get; set; } = ConfigHandler.PRIORI_API_ENDPOINT;
    public static HttpClient static_client = new();

    public static async Task<T> RunTaskWithAuthentication<T>(Task<T> task, string JWT_token) {
        APIHandler.static_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JWT_token);

        T? result;

        try {
            result = await task;
        } finally {
            APIHandler.static_client.DefaultRequestHeaders.Authorization = null;
        }

        return result;
    }

    public static async Task<HttpResponseMessage> GetRequest(string target_url) => await static_client.GetAsync($"http://{Api_endpoint}/api{target_url}");

    public static async Task<HttpResponseMessage> DeleteRequest(string target_url) => await static_client.DeleteAsync($"http://{Api_endpoint}/api{target_url}");

    public static async Task<T?> FetchAbstractJsonObjectAsync<T>(string target_url)
    {
        string? response = await static_client.GetStringAsync($"http://{Api_endpoint}/api{target_url}");

        MemoryStream stream = new(Encoding.UTF8.GetBytes(response));

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
            return fallback_object;
        }

        return (initial_object != null) ? initial_object : fallback_object;
    }

    public static async Task<HttpResponseMessage> PostApiRequestAsync(Dictionary<string, object> json_object, string target_url)
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
            $"http://{Api_endpoint}/api{target_url}",
            content
        );

        return response;
    }

    
    public static async Task<HttpResponseMessage> PutRequestAsync(Dictionary<string, object> json_object, string target_url)
    {
        string json_string = Encoding.UTF8.GetString(
            JsonSerializer.SerializeToUtf8Bytes(json_object)
        );

        var content = new StringContent(
            json_string,
            UnicodeEncoding.UTF8,
            "application/json"
        );

        var response = await static_client.PutAsync(
            $"http://{Api_endpoint}/api{target_url}",
            content
        );

        return response;
    }
}
