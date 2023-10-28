using System;
using AgencyPro.Leads.Enums;
using AgencyPro.Leads.Interfaces;
using AgencyPro.OrganizationRoles.Entities;

namespace AgencyPro.Leads.Entities
{
    public class LeadMatrix : ILeadMatrix
    {
        public OrganizationMarketer OrganizationMarketer { get; set; }

        public Guid MarketerId { get; set; }
        public Guid MarketerOrganizationId { get; set; }
        public int Count { get; set; }
        public LeadStatus Status { get; set; }
        public DateTime Date { get; set; }
    }
}