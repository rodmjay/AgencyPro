using System;
using AgencyPro.People.Enums;

namespace AgencyPro.OrganizationRoles.Models.OrganizationContractors
{
    public class OrganizationContractorOutput : OrganizationContractorInput
    {
        public virtual string PublicDisplayName { get; set; }
        public virtual string DisplayName { get; set; }
        public virtual PersonStatus Status { get; set; }
        public virtual string ImageUrl { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Email { get; set; }
        public virtual Guid RecruiterId { get; set; }
        public virtual Guid RecruiterOrganizationId { get; set; }
        public virtual string RecruiterName { get; set; }
        public virtual string RecruiterOrganizationName { get; set; }
        public virtual string RecruiterImageUrl { get; set; }
        public virtual string RecruiterOrganizationImageUrl { get; set; }
    }
}