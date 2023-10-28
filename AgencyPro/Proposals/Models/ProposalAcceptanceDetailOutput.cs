using System;

namespace AgencyPro.Proposals.Models
{
    public class ProposalAcceptanceDetailOutput : ProposalAcceptanceOutput
    {
        public string ProjectName { get; set; }
        public string ProjectAbbreviation { get; set; }

        public string ProjectManagerName { get; set; }
        public string ProjectManagerOrganizationName { get; set; }
        public Guid ProjectManagerId { get; set; }
        public Guid ProjectManagerOrganizationId { get; set; }
        public string ProjectManagerImageUrl { get; set; }
        public string ProjectManagerOrganizationImageUrl { get; set; }

        public string AccountManagerName { get; set; }
        public Guid AccountManagerId { get; set; }
        public Guid AccountManagerOrganizationId { get; set; }
        public string AccountManagerOrganizationName { get; set; }
        public string AccountManagerImageUrl { get; set; }
        public string AccountManagerOrganizationImageUrl { get; set; }
    }
}