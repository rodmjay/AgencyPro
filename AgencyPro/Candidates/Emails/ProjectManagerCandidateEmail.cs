using AgencyPro.Candidates.Models;
using AgencyPro.Email.Interfaces;

namespace AgencyPro.Candidates.Emails
{
    public class ProjectManagerCandidateEmail : ProjectManagerCandidateOutput, IBasicEmail
    {
        public string RecipientEmail { get; set; }
        public string RecipientName { get; set; }
        public string FlowUrl { get; set; }
        public bool SendMail { get; set; }
    }
}