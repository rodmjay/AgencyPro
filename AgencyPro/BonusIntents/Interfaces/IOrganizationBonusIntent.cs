using System;
using AgencyPro.BonusIntents.Enums;

namespace AgencyPro.BonusIntents.Interfaces
{
    public interface IOrganizationBonusIntent
    {
        Guid Id { get; set; }
        Guid OrganizationId { get; set; }
        BonusType BonusType { get; set; }
        string TransferId { get; set; }
        decimal Amount { get; set; }
        string Description { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
    }
}