namespace PRIORI_SERVICES_WEB.Handler;

public static class ConfigHandler
{
    public static string API_ENDPOINT { get; set; } = System.Environment.GetEnvironmentVariable("PRIORI_API_ENDPOINT") ?? "localhost:5135";
    public static string PRIORI_EMAIL_ADDRESS { get; set; } = System.Environment.GetEnvironmentVariable("PRIORI_EMAIL_ADDRESS") ?? "priori@cyberservices.com";
    public static string PRIORI_EMAIL_PASSWORD { get; set; } = System.Environment.GetEnvironmentVariable("PRIORI_EMAIL_ADDRESS") ?? "";

}
