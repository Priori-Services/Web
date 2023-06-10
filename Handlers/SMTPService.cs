using System.Net.Mail;
using System.Net;
using PRIORI_SERVICES_WEB.Data.Model;
using Microsoft.Extensions.Options;

namespace PRIORI_SERVICES_WEB.Handler.Services;

public interface ISMTPService
{
    public void SendVerificationMailTo(PrioriVerificationEmail mail, string target);
}

public class SMTPService : ISMTPService
{
    private readonly SMTPConfiguration config;

    public SMTPService(IOptions<SMTPConfiguration> config)
    {
        this.config = config.Value;
    }

    /// Summary:
    ///     Envia um email de verificação utilizando o email da Priori para X target
    ///
    /// Exceptions:
    ///     ArgumentNullException
    ///     InvalidOperationException
    ///     ObjectDisposedException
    ///     SmtpException
    ///     SmtpFailedRecipientException
    ///     SmtpFailedRecipientsException
    public void SendVerificationMailTo(PrioriVerificationEmail mail, string target)
    {
        MailMessage message = new()
        {
            IsBodyHtml = true,
            Subject = mail.Titulo,
            Body = mail.Generate(),
            From = new MailAddress(config.USERNAME)
        };

        var smtpClient = new SmtpClient(config.HOST)
        {
            Port = config.PORT,
            EnableSsl = true,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(config.USERNAME, config.PASSWORD)
        };

        message.To.Add(target);

        smtpClient.Send(message);
    }
}
