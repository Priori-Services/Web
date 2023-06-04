using System.Net.Mail;
using System.Net;

namespace PRIORI_SERVICES_WEB.Handler.Services;

public interface ISMTPService
{
    public void SendMailTo(MailMessage message, string target);
}



public class SMTPService : ISMTPService
{

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
