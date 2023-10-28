using System;
using AgencyPro.BonusIntents.Enums;
using AgencyPro.BonusIntents.Interfaces;

namespace AgencyPro.BonusIntents.Models
{
    public class IndividualBonusIntentOutput : IIndividualBonusIntent
    {
        public Guid Id { get; set; }
        public Guid PersonId { get; set; }
        public BonusType BonusType { get; set; }
        public string TransferId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
    }
}
