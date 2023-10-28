using AgencyPro.Agreements.Models;
using AgencyPro.Email.Interfaces;

namespace AgencyPro.Agreements.Emails
{
    public class MarketingAgencyAgreementEmail : MarketingAgreementOutput, IBasicEmail
    {
        public string RecipientName { get; set; }
        public string RecipientEmail { get; set; }
        public string FlowUrl { get; set; }
        public bool SendMail { get; set; }
    }
}