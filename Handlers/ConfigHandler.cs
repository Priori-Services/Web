namespace PRIORI_SERVICES_WEB.Handler;
using System;

public static class ConfigHandler
{
    public static string PRIORI_API_ENDPOINT { get; set; } = Environment.GetEnvironmentVariable(nameof(PRIORI_API_ENDPOINT).ToString()) ?? "localhost:5135";

}
