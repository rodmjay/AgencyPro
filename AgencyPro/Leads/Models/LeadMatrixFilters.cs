using System;

namespace AgencyPro.Leads.Models
{
    public class LeadMatrixFilters
    {
        public static readonly LeadMatrixFilters NoFilter = new LeadMatrixFilters();

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Guid? MarketerId { get; set; }
        public Guid? MarketerOrganizationId { get; set; }

    }
}