using System.Net.Mail;
using System.Net;

namespace PRIORI_SERVICES_WEB.Handler.Services;

public interface ISMTPService
{
    public string GenerateAuthenticationID(int digits);
    public void SendMailTo(MailMessage message, string target);
}

public class SMTPService : ISMTPService
{
    /// Exceptions:
    ///     ArgumentOutOfRangeException
    ///     FormatException
    public string GenerateAuthenticationID(int digits = 6)
    {
        const int MINIMUM_CONST = 0;
        int MAXIMUM = (int)(Math.Pow(10, digits));

        return new Random().Next(MINIMUM_CONST, MAXIMUM).ToString($"D{digits}");
    }

    /// Summary:
    ///     Envia um email utilizando o email da Priori para X target
    ///
    /// Exceptions:
    ///     ArgumentNullException
    ///     InvalidOperationException
    ///     ObjectDisposedException
    ///     SmtpException
    ///     SmtpFailedRecipientException
    ///     SmtpFailedRecipientsException
    public void SendMailTo(MailMessage message, string target)
    {
        var smtpClient = new SmtpClient(ConfigHandler.SMTP_SERVICE_URL)
        {
            Port = ConfigHandler.SMTP_SERVICE_PORT,
            EnableSsl = true,
        };

        smtpClient.UseDefaultCredentials = false;
        smtpClient.Credentials = new NetworkCredential(ConfigHandler.PRIORI_EMAIL_ADDRESS, ConfigHandler.PRIORI_EMAIL_PASSWORD);

        message.To.Add(target);

        smtpClient.Send(message);
    }
}
