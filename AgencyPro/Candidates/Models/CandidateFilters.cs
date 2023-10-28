using System;

namespace AgencyPro.Candidates.Models
{
    public class CandidateFilters
    {
        public static readonly CandidateFilters NoFilter = new CandidateFilters();

        public Guid? ProjectManagerId { get; set; }
        public Guid? ProjectManagerOrganizationId { get; set; }
    }
}