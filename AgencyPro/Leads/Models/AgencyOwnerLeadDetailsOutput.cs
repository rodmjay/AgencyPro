using System;
using System.Collections.Generic;
using AgencyPro.Comments.Models;
using AgencyPro.Common.Metadata;
using AgencyPro.Leads.Enums;

namespace AgencyPro.Leads.Models
{
    [FlowDirective(FlowRoleToken.AgencyOwner, "leads")]
    public class AgencyOwnerLeadDetailsOutput : AgencyOwnerLeadOutput
    {
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, LeadStatus> StatusTransitions { get; set; }
    }
}