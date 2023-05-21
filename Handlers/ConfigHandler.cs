namespace PRIORI_SERVICES_WEB.Handler;

public static class ConfigHandler
{
    public static string API_ENDPOINT { get; set; } = System.Environment.GetEnvironmentVariable("PRIORI_API_ENDPOINT") ?? "localhost:5135";
}
