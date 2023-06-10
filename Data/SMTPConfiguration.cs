namespace PRIORI_SERVICES_WEB.Data.Model;

public class SMTPConfiguration
{
    public const string DefaultSectionName = "SMTPConfiguration";
    public const string DefaultPrefix = "PRIORI_EMAIL_";
    public string USERNAME { get; set; } = Environment.GetEnvironmentVariable($"{DefaultPrefix}{nameof(USERNAME)}") ?? "";
    public string PASSWORD { get; set; } = Environment.GetEnvironmentVariable($"{DefaultPrefix}{nameof(PASSWORD)}") ?? "";
    public string HOST { get; set; } = Environment.GetEnvironmentVariable($"{DefaultPrefix}{nameof(HOST)}") ?? "";
    public int PORT { get; set; } = Convert.ToInt32(Environment.GetEnvironmentVariable($"{DefaultPrefix}{nameof(PORT)}"));
}
