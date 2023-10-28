using System;
using AgencyPro.Common.Metadata;
using Newtonsoft.Json;

namespace AgencyPro.Contracts.Models
{
    [FlowDirective(FlowRoleToken.Recruiter, "contracts")]
    public class RecruiterContractOutput : RecruitingContractOutput
    {
        public override Guid TargetOrganizationId => RecruiterOrganizationId;
        [JsonIgnore] public override Guid RecruiterId { get; set; }
        [JsonIgnore] public override Guid RecruiterOrganizationId { get; set; }
        [JsonIgnore] public override string RecruiterImageUrl { get; set; }
        [JsonIgnore] public override string RecruiterOrganizationImageUrl { get; set; }

        public override decimal TotalHoursLogged { get; set; }

        public override decimal TotalApprovedHours { get; set; }
        [JsonIgnore] public override string RecruiterName { get; set; }
        [JsonIgnore] public override string RecruiterOrganizationName { get; set; }

        public override decimal RecruiterStream { get; set; }
        [JsonIgnore] public override decimal RecruitingAgencyStream { get; set; }
        [JsonIgnore] public override Guid AccountManagerOrganizationId { get; set; }
        [JsonIgnore] public override string AccountManagerOrganizationName { get; set; }
        [JsonIgnore] public override string AccountManagerImageUrl { get; set; }
        [JsonIgnore] public override string AccountManagerOrganizationImageUrl { get; set; }
        public override string ContractorName { get; set; }
        public override string ContractorOrganizationName { get; set; }
        public override string ContractorImageUrl { get; set; }
        public override string ContractorOrganizationImageUrl { get; set; }
        [JsonIgnore] public override string CustomerOrganizationName { get; set; }
        [JsonIgnore] public override string CustomerOrganizationImageUrl { get; set; }
        [JsonIgnore] public override Guid CustomerOrganizationId { get; set; }

      
        public override int RecruitingNumber { get; set; }
        public override decimal MaxRecruiterWeekly { get; set; }
        [JsonIgnore] public override decimal MaxRecruitingAgencyWeekly { get; set; }

        public override Guid TargetPersonId => this.RecruiterId;
    }
}