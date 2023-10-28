using System;

namespace AgencyPro.Roles.ViewModels.Marketers
{
    public class MarketerInput : MarketerUpdateInput
    {
        public virtual string AffiliateId { get; set; }

        public virtual Guid PersonId { get; set; }
    }
}