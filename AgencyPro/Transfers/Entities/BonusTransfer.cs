using System.Collections.Generic;
using AgencyPro.BonusIntents.Entities;
using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Transfers.Entities
{
    public class BonusTransfer : BaseEntity<BonusTransfer>
    {
        public string TransferId { get; set; }
        public StripeTransfer Transfer { get; set; }

        public ICollection<IndividualBonusIntent> IndividualBonusIntents { get; set; }
        public ICollection<OrganizationBonusIntent> OrganizationBonusIntents { get; set; }
        public override void Configure(EntityTypeBuilder<BonusTransfer> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}