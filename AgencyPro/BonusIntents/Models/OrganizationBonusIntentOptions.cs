using System;

namespace AgencyPro.BonusIntents.Models
{
    public class CreateBonusIntentOptions
    {
        public Guid? LeadId { get; set; }
        public Guid? CandidateId { get; set; }
    }
}