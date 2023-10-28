using System;
using AgencyPro.Common.Metadata;
using AgencyPro.Projects.Enums;
using Newtonsoft.Json;

namespace AgencyPro.Contracts.Models
{
    [FlowDirective(FlowRoleToken.ProjectManager, "contracts")]
    public class ProjectManagerContractOutput : ProviderContractOutput
    {
        public override Guid TargetOrganizationId => ProjectManagerOrganizationId;

        [JsonIgnore] public override decimal ContractorStream { get; set; }


        [JsonIgnore] public override decimal AccountManagerStream { get; set; }
        public override decimal ProjectManagerStream { get; set; }

        [JsonIgnore] public override decimal SystemStream { get; set; }

        [JsonIgnore] public override decimal AgencyStream { get; set; }

        public override decimal TotalHoursLogged { get; set; }
        public override decimal TotalApprovedHours { get; set; }
        public override string ProjectName { get; set; }
        public override string ProjectAbbreviation { get; set; }
        public override ProjectStatus ProjectStatus { get; set; }
        public override int ProviderNumber { get; set; }
       
        [JsonIgnore] public override decimal CustomerRate { get; set; }
        [JsonIgnore] public override decimal MaxCustomerWeekly { get; set; }

        [JsonIgnore] public override decimal MaxContractorWeekly { get; set; }


        public override decimal MaxProjectManagerWeekly { get; set; }

        [JsonIgnore] public override decimal MaxAccountManagerWeekly { get; set; }

        [JsonIgnore] public override decimal MaxAgencyWeekly { get; set; }
        [JsonIgnore] public override decimal MaxSystemWeekly { get; set; }

        [JsonIgnore] public override Guid MarketerOrganizationId { get; set; }
        public override string ProjectManagerName { get; set; }
        public override string ProjectManagerOrganizationName { get; set; }
        public override Guid ProjectManagerId { get; set; }
        public override Guid ProjectManagerOrganizationId { get; set; }
        public override string ProjectManagerImageUrl { get; set; }
        public override string ProjectManagerOrganizationImageUrl { get; set; }
        public override string AccountManagerName { get; set; }
        public override Guid AccountManagerId { get; set; }
        public override Guid AccountManagerOrganizationId { get; set; }
        public override string AccountManagerOrganizationName { get; set; }
        public override string AccountManagerImageUrl { get; set; }
        public override string AccountManagerOrganizationImageUrl { get; set; }
        public override string ContractorName { get; set; }
        public override string ContractorOrganizationName { get; set; }
        public override string ContractorImageUrl { get; set; }
        public override string ContractorOrganizationImageUrl { get; set; }
        public override string CustomerName { get; set; }
        public override string CustomerImageUrl { get; set; }
        public override string CustomerOrganizationName { get; set; }
        public override string CustomerOrganizationImageUrl { get; set; }
        public override Guid CustomerOrganizationId { get; set; }
        public override Guid CustomerId { get; set; }
        [JsonIgnore] public override string MarketerOrganizationImageUrl { get; set; }
        [JsonIgnore] public override string MarketerOrganizationName { get; set; }

        [JsonIgnore] public override Guid RecruiterOrganizationId { get; set; }
        [JsonIgnore] public override string RecruiterOrganizationImageUrl { get; set; }
        [JsonIgnore] public override string RecruiterOrganizationName { get; set; }

        public override Guid TargetPersonId => this.ProjectManagerId;
    }
}