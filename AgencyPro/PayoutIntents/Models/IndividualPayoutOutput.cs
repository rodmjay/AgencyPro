using System;
using AgencyPro.PayoutIntents.Interfaces;

namespace AgencyPro.PayoutIntents.Models
{
    public class IndividualPayoutIntentOutput : PayoutViewModel, IIndividualPayoutIntent
    {
        public Guid PersonId { get; set; }
        public string RecipientName { get; set; }
    }
}
