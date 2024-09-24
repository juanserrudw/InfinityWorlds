using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string message)
    {
        var smtpClient = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
        {
            Credentials = new NetworkCredential("22f4710d5c4ab3", "11b365390d2813"),
            EnableSsl = true,
        };

        return smtpClient.SendMailAsync(
            new MailMessage("from@example.com", email, subject, message) { IsBodyHtml = true }
        );
    }
}
