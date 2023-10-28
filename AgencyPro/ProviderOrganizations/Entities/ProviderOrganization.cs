using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AgencyPro.Agreements.Entities;
using AgencyPro.Candidates.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.CustomerAccounts.Entities;
using AgencyPro.Leads.Entities;
using AgencyPro.Orders.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Organizations.Entities;
using AgencyPro.Projects.Entities;
using AgencyPro.ProviderOrganizations.Interfaces;
using AgencyPro.Skills.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.ProviderOrganizations.Entities
{
    public class ProviderOrganization : BaseEntity<ProviderOrganization>, IProviderOrganization
    {
        public Guid Id { get; set; }

        [ForeignKey("Id")] public Organization Organization { get; set; }

        public ICollection<Contract> Contracts { get; set; }

        public ICollection<MarketingAgreement> MarketingAgreements { get; set; }
        public ICollection<RecruitingAgreement> RecruitingAgreements { get; set; }

        public ICollection<Project> Projects { get; set; }
        public ICollection<Lead> Leads { get; set; }

        public decimal AccountManagerStream { get; set; }
        public decimal ProjectManagerStream { get; set; }
        public decimal AgencyStream { get; set; }

        public decimal ContractorStream { get; set; }

        public string ProviderInformation { get; set; }
        public string ProjectManagerInformation { get; set; }
        public string AccountManagerInformation { get; set; }
        public string ContractorInformation { get; set; }
        public string RecruiterInformation { get; set; }
        public string MarketerInformation { get; set; }

        public bool Discoverable { get; set; }


        public int EstimationBasis { get; set; }

        public int FutureDaysAllowed { get; set; }
        public int PreviousDaysAllowed { get; set; }

        public decimal SystemStream { get; set; }

        public Guid DefaultContractorId { get; set; }
        public Guid DefaultProjectManagerId { get; set; }
        public Guid DefaultAccountManagerId { get; set; }

        public OrganizationContractor DefaultContractor { get; set; }
        public OrganizationProjectManager DefaultProjectManager { get; set; }
        public OrganizationAccountManager DefaultAccountManager { get; set; }


        public ICollection<WorkOrder> WorkOrders { get; set; }
        
        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<CustomerAccount> CustomerAccounts { get; set; }

        public bool AutoApproveTimeEntries { get; set; }


        //public ICollection<OrganizationProjectManager> ProjectManagers { get; set; }
        //public ICollection<OrganizationAccountManager> AccountManagers { get; set; }
        //public ICollection<OrganizationContractor> Contractors { get; set; }

        public ICollection<OrganizationSkill> Skills { get; set; }

        public override void Configure(EntityTypeBuilder<ProviderOrganization> builder)
        {
            throw new NotImplementedException();
        }
    }
}