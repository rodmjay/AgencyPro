using System.Threading.Tasks;
using AgencyPro.Messaging.Email;

namespace AgencyPro.Email.Interfaces
{
    public interface IEmailSender2
    {
        void Send(EmailMessage message, EmailAttachment attachment = null);

        Task SendAsync(EmailMessage message, EmailAttachment attachment = null);
    }
}