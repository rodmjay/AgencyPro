using AgencyPro.Email.Interfaces;
using AgencyPro.Leads.Models;

namespace AgencyPro.Leads.Emails
{
    public class MarketingAgencyOwnerLeadEmail : MarketerLeadOutput, IBasicEmail
    {
        public string RecipientName { get; set; }
        public string RecipientEmail { get; set; }
        public string FlowUrl { get; set; }
        public bool SendMail { get; set; }
    }
}