using System;
using System.Collections.Generic;
using AgencyPro.Comments.Models;
using AgencyPro.Contracts.Enums;

namespace AgencyPro.Contracts.Models
{
    public class AgencyOwnerRecruitingContractDetailsOutput : AgencyOwnerRecruitingContractOutput
    {
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, ContractStatus> StatusTransitions { get; set; }
    }
}