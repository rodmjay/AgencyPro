using System;

namespace AgencyPro.Skills.Interfaces
{
    public interface IOrganizationSkill
    {
        Guid OrganizationId { get; set; }
        Guid SkillId { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
        int Priority { get; set; }
    }
}