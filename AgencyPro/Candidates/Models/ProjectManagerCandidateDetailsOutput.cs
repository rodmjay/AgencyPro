using System.Collections.Generic;
using AgencyPro.Comments.Models;

namespace AgencyPro.Candidates.Models
{
    public class ProjectManagerCandidateDetailsOutput : ProjectManagerCandidateOutput
    {
        public ICollection<CommentOutput> Comments { get; set; }

    }
}