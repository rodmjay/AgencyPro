using System;
using AgencyPro.Stories.Enums;

namespace AgencyPro.Stories.Interfaces
{
    public interface IStory
    {
        Guid Id { get; set; }
        string StoryId { get; set; }
        Guid ProjectId { get; set; }
        Guid? ContractorId { get; set; }
        Guid? ContractorOrganizationId { get; set; }
        int? StoryPoints { get; set; }
        DateTimeOffset? DueDate { get; set; }
        StoryStatus Status { get; set; }
        DateTimeOffset? AssignedDateTime { get; set; }
        DateTimeOffset? ProjectManagerAcceptanceDate { get; set; }
        DateTimeOffset? CustomerAcceptanceDate { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
    }
}