using System;
using AgencyPro.BonusIntents.Enums;

namespace AgencyPro.BonusIntents.Interfaces
{
    public interface IIndividualBonusIntent
    {
        Guid Id { get; set; }
        Guid PersonId { get; set; }
        BonusType BonusType { get; set; }
        string TransferId { get; set; }
        decimal Amount { get; set; }
        string Description { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
    }
}