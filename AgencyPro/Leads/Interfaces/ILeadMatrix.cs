using System;
using AgencyPro.Leads.Enums;

namespace AgencyPro.Leads.Interfaces
{
    public interface ILeadMatrix
    {
        Guid MarketerId { get; set; }
        Guid MarketerOrganizationId { get; set; }
        int Count { get; set; }
        LeadStatus Status { get; set; }
        DateTime Date { get; set; }


    }
}