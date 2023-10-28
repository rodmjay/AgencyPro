using System;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.OrganizationRoles.Models.OrganizationRecruiters
{
    public class OrganizationRecruiterInput : IOrganizationRecruiter
    {
        public virtual decimal RecruiterStream { get; set; }

        public virtual decimal RecruiterBonus { get; set; }

        public Guid RecruiterId { get; set; }

        public Guid OrganizationId { get; set; }
    }
}