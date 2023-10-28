using System.Collections.Generic;
using AgencyPro.Comments.Models;

namespace AgencyPro.Candidates.Models
{
    public class AgencyOwnerCandidateDetailsOutput : AgencyOwnerCandidateOutput
    {
        public ICollection<CommentOutput> Comments { get; set; }
    }
}