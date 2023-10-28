using System;
using AgencyPro.Common.Models;

namespace AgencyPro.Candidates.Models
{
    public class CandidateResult : Result
    {
        public Guid? CandidateId { get; set; }
    }
}