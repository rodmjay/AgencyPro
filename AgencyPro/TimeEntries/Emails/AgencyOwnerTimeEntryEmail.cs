using AgencyPro.Email.Interfaces;
using AgencyPro.TimeEntries.Models;

namespace AgencyPro.TimeEntries.Emails
{
    public class AgencyOwnerTimeEntryEmail : ProviderAgencyOwnerTimeEntryOutput, IBasicEmail
    {
        public string RecipientName { get; set; }
        public string RecipientEmail { get; set; }
        public string FlowUrl { get; set; }
        public bool SendMail { get; set; }
    }
}