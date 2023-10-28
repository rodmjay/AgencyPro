using System;
using System.Collections.Generic;
using AgencyPro.Comments.Models;
using AgencyPro.Contracts.Enums;
using AgencyPro.Contracts.Models;
using AgencyPro.Projects.Enums;
using AgencyPro.Proposals.Models;
using AgencyPro.Stories.Enums;
using AgencyPro.Stories.Models;
using AgencyPro.TimeEntries.Enums;

namespace AgencyPro.Projects.Models
{
    public class AccountManagerProjectDetailsOutput : AccountManagerProjectOutput
    {
        public AccountManagerFixedPriceProposalDetailModel Proposal { get; set; }
        public ICollection<AccountManagerContractOutput> Contracts { get; set; }
        public ICollection<AccountManagerStoryOutput> Stories { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, ProjectStatus> StatusTransitions { get; set; }

        public IDictionary<TimeStatus, int> TimeEntryStatus { get; set; }
        public IDictionary<StoryStatus, int> StoryStatus { get; set; }
        public IDictionary<ContractStatus, int> ContractStatus { get; set; }
    }
}