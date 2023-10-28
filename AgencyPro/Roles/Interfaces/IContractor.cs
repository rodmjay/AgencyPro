using System;

namespace AgencyPro.Roles.Interfaces
{
    public interface IContractor
    {
        Guid Id { get; set; }
        Guid RecruiterId { get; set; }
        Guid RecruiterOrganizationId { get; set; }
        bool IsAvailable { get; set; }
        DateTime? LastWorkedUtc { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
        int HoursAvailable { get; set; }
    }
}