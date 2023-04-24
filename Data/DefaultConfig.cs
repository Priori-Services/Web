namespace PRIORI_SERVICES_WEB.Data;

public static class DefaultConfig
{
    public static string API_ENDPOINT { get; set; } = System.Environment.GetEnvironmentVariable("PRIORI_API_ENDPOINT") ?? "localhost:5135";
}
