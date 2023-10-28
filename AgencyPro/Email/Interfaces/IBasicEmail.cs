using AgencyPro.Common.Settings;

namespace AgencyPro.Email.Interfaces
{
    public static class BasicEmailExtensions
    {
        public static void Initialize(this IBasicEmail email, AppSettings settings)
        {
            email.FlowUrl = settings.Urls.Flow;
        }
    }

    public interface IBasicEmail
    {
        string RecipientName { get; set; }
        string RecipientEmail { get; set; }
        string FlowUrl { get; set; }
        bool SendMail { get; set; }
    }
}