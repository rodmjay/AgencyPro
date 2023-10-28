using System;
using System.Collections.Generic;
using AgencyPro.Comments.Models;
using AgencyPro.Common.Metadata;
using AgencyPro.Contracts.Enums;
using AgencyPro.Stories.Models;
using AgencyPro.TimeEntries.Models;

namespace AgencyPro.Contracts.Models
{
    [FlowDirective(FlowRoleToken.AccountManager, "contracts")]
    public class AccountManagerContractDetailsOutput : AccountManagerContractOutput
    {
        public ICollection<AccountManagerTimeEntryOutput> TimeEntries { get; set; }
        public ICollection<AccountManagerStoryOutput> Stories { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, ContractStatus> StatusTransitions { get; set; }
    }
}