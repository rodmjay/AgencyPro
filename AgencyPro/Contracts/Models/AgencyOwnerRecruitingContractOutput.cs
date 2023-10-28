using System;

namespace AgencyPro.Contracts.Models
{
    public class AgencyOwnerRecruitingContractOutput : RecruitingContractOutput
    {
        public override Guid TargetOrganizationId => RecruiterOrganizationId;
        public override int RecruitingNumber { get; set; }
        public override decimal MaxRecruiterWeekly { get; set; }
        public override decimal MaxRecruitingAgencyWeekly { get; set; }
        public override Guid RecruiterId { get; set; }
        public override Guid RecruiterOrganizationId { get; set; }
        public override decimal RecruiterStream { get; set; }
        public override decimal RecruitingAgencyStream { get; set; }
        public override Guid AccountManagerOrganizationId { get; set; }
        public override string AccountManagerOrganizationName { get; set; }
        public override string AccountManagerImageUrl { get; set; }
        public override string AccountManagerOrganizationImageUrl { get; set; }
        public override string ContractorName { get; set; }
        public override string ContractorEmail { get; set; }
        public override string ContractorPhoneNumber { get; set; }
        public override string ContractorOrganizationName { get; set; }
        public override string ContractorImageUrl { get; set; }
        public override string ContractorOrganizationImageUrl { get; set; }
        public override string CustomerOrganizationName { get; set; }
        public override string CustomerOrganizationImageUrl { get; set; }
        public override Guid CustomerOrganizationId { get; set; }
        public override string RecruiterName { get; set; }
        public override string RecruiterEmail { get; set; }
        public override string RecruiterPhoneNumber { get; set; }
        public override string RecruiterImageUrl { get; set; }
        public override string RecruiterOrganizationName { get; set; }
        public override string RecruiterOrganizationImageUrl { get; set; }
        public override decimal TotalHoursLogged { get; set; }
        public override decimal TotalApprovedHours { get; set; }

        public override Guid TargetPersonId => this.RecruitingOrganizationOwnerId;
    }
}