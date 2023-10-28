using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Leads.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Leads.Entities
{
   
    public class LeadStatusTransition : BaseEntity<LeadStatusTransition>
    {
        public int Id { get; set; }
        public Guid LeadId { get; set; }
        public LeadStatus Status { get; set; }
        public DateTimeOffset Created { get; set; }
        public override void Configure(EntityTypeBuilder<LeadStatusTransition> builder)
        {
            throw new NotImplementedException();
        }
    }
}