using System;
using AgencyPro.Leads.Enums;
using AgencyPro.Leads.Interfaces;

namespace AgencyPro.Leads.Models
{
    public class LeadMatrixOutput : ILeadMatrix
    {
        public virtual Guid MarketerId { get; set; }
        public virtual Guid MarketerOrganizationId { get; set; }
        public int Count { get; set; }
        public virtual LeadStatus Status { get; set; }
        public DateTime Date { get; set; }
    }
}
