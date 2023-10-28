using System;
using AgencyPro.Candidates.Enums;
using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Candidates.Entities
{
    public class CandidateStatusTransition : BaseEntity<CandidateStatusTransition>
    {
        public int Id { get; set; }

        public Candidate Candidate { get; set; }
        public Guid CandidateId { get; set; }

        public CandidateStatus Status { get; set; }
        public DateTimeOffset Created { get; set; }
        public override void Configure(EntityTypeBuilder<CandidateStatusTransition> builder)
        {
            throw new NotImplementedException();
        }
        
    }
}