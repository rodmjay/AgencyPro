using System;
using System.Collections.Generic;
using AgencyPro.Comments.Models;
using AgencyPro.Leads.Enums;

namespace AgencyPro.Leads.Models
{
    public class MarketerLeadDetailsOutput : MarketerLeadOutput
    {
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, LeadStatus> StatusTransitions { get; set; }
    }
}