using AgencyPro.Email.Interfaces;
using AgencyPro.Proposals.Models;

namespace AgencyPro.Proposals.Emails
{
    public class AccountManagerProposalEmail : AccountManagerFixedPriceProposalOutput, IBasicEmail
    {
        public string RecipientEmail { get; set; }
        public string FlowUrl { get; set; }
        public bool SendMail { get; set; }
        public string RecipientName { get; set; }
    }
}