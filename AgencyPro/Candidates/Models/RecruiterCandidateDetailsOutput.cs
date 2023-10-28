using System.Collections.Generic;
using AgencyPro.Comments.Models;
using AgencyPro.Common.Metadata;

namespace AgencyPro.Candidates.Models
{
    [FlowDirective(FlowRoleToken.Recruiter, "candidates")]
    public class RecruiterCandidateDetailsOutput : RecruiterCandidateOutput
    {
        public ICollection<CommentOutput> Comments { get; set; }

    }
}