using AgencyPro.Candidates.Models;
using AgencyPro.Email.Interfaces;

namespace AgencyPro.Candidates.Emails
{
    public class AgencyOwnerCandidateEmail : AgencyOwnerCandidateOutput, IBasicEmail
    {
        public string RecipientName { get; set; }
        public string RecipientEmail { get; set; }
        public string FlowUrl { get; set; }
        public bool SendMail { get; set; }
    }
}