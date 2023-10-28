using System;

namespace AgencyPro.Roles.ViewModels.Contractors
{
    public class ContractorInput : ContractorUpdateInput
    {
        public virtual Guid RecruiterId { get; set; }
        public virtual Guid RecruiterOrganizationId { get; set; }

        public virtual Guid PersonId { get; set; }

    }
}