using System;
using System.Collections.Generic;
using AgencyPro.BillingCategories.Models;
using AgencyPro.PaymentTerms.Models;
using AgencyPro.Positions.Models;
using AgencyPro.Skills.Models;

namespace AgencyPro.ProviderOrganizations.Models
{
    public abstract class ProviderOrganizationDetailsOutput : ProviderOrganizationOutput
    {
        public virtual ICollection<PositionOutput> AvailablePositions { get; set; }
        public virtual ICollection<BillingCategoryOutput> AvailableBillingCategories { get; set; }
        public virtual ICollection<PaymentTermOutput> AvailablePaymentTerms { get; set; }
        public virtual ICollection<SkillOutput> AvailableSkills { get; set; }

        public virtual IDictionary<Guid, int> Skills { get; set; }

        public virtual IDictionary<int, bool> PaymentTerms { get; set; }
        public virtual IList<int> BillingCategories { get; set; }
        public virtual IList<int> Positions { get; set; }
    }
}