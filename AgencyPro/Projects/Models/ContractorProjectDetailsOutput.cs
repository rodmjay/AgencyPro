using System;
using System.Collections.Generic;
using AgencyPro.Comments.Models;
using AgencyPro.Contracts.Models;
using AgencyPro.Projects.Enums;
using AgencyPro.Stories.Models;

namespace AgencyPro.Projects.Models
{
    public class ContractorProjectDetailsOutput : ContractorProjectOutput
    {
        public ICollection<ContractorStoryOutput> Stories { get; set; }
        public ICollection<ContractorContractOutput> Contracts { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, ProjectStatus> StatusTransitions { get; set; }
    }
}