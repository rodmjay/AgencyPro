using System.Threading.Tasks;

namespace AgencyPro.Messaging.Sms
{
    public interface ISmsSender
    {
        Task<string> SendSmsAsync(SmsMessage message);
    }
}