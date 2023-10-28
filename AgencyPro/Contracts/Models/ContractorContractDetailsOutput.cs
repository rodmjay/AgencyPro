using System;
using System.Collections.Generic;
using AgencyPro.Comments.Models;
using AgencyPro.Contracts.Enums;
using AgencyPro.Stories.Models;
using AgencyPro.TimeEntries.Models;

namespace AgencyPro.Contracts.Models
{
    public class ContractorContractDetailsOutput : ContractorContractOutput
    {
        public ICollection<ContractorTimeEntryOutput> TimeEntries { get; set; }
        public ICollection<ContractorStoryOutput> Stories { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, ContractStatus> StatusTransitions { get; set; }
    }
}