namespace PRIORI_SERVICES_WEB.Handler;
using System;

public static class ConfigHandler
{
    public static string PRIORI_API_ENDPOINT { get; set; } = Environment.GetEnvironmentVariable(nameof(PRIORI_API_ENDPOINT).ToString()) ?? "localhost:5135";
    public static string PRIORI_EMAIL_ADDRESS { get; set; } = Environment.GetEnvironmentVariable(nameof(PRIORI_EMAIL_ADDRESS).ToString()) ?? "";
    public static string PRIORI_EMAIL_PASSWORD { get; set; } = Environment.GetEnvironmentVariable(nameof(PRIORI_EMAIL_PASSWORD).ToString()) ?? "";
    public static string SMTP_SERVICE_URL { get; set; } = Environment.GetEnvironmentVariable(nameof(SMTP_SERVICE_URL).ToString()) ?? "smtp.gmail.com";
    public static int SMTP_SERVICE_PORT { get; set; } = Convert.ToInt32(Environment.GetEnvironmentVariable(nameof(SMTP_SERVICE_PORT).ToString()));
}
