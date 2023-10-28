using System;
using System.ComponentModel.DataAnnotations;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.OrganizationRoles.Models.OrganizationContractors
{
    public class OrganizationContractorInput : IOrganizationContractor
    {
        public virtual bool IsFeatured { get; set; }
        public virtual string Biography { get; set; }
        public virtual string PortfolioMediaUrl { get; set; }

        [Range(0, 999)]
        public virtual decimal ContractorStream { get; set; }

        public Guid ContractorId { get; set; }
        public Guid OrganizationId { get; set; }
        public bool AutoApproveTimeEntries { get; set; }

    }
}