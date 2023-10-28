using System;
using AgencyPro.Projects.Enums;

namespace AgencyPro.Projects.Interfaces
{
    public interface IProject
    {
        Guid Id { get; set; }
        ProjectStatus Status { get; set; }
        string Name { get; set; }
        string Abbreviation { get; set; }
        Guid CustomerOrganizationId { get; set; }
        Guid CustomerId { get; set; }
        Guid ProjectManagerId { get; set; }
        Guid ProjectManagerOrganizationId { get; set; }
        Guid AccountManagerId { get; set; }
        Guid AccountManagerOrganizationId { get; set; }
        decimal WeightedContractorAverage { get; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
        Guid CreatedById { get; set; }
        Guid UpdatedById { get; set; }
    }
}