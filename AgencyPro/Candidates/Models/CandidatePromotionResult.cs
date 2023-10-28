using System;
using AgencyPro.Common.Models;

namespace AgencyPro.Candidates.Models
{
    public class CandidatePromotionResult : Result
    {
        public Guid? CandidateId { get; set; }
        public Guid? PersonId { get; set; }
    }
}