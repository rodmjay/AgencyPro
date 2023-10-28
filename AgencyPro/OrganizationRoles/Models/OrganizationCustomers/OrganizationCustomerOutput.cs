using AgencyPro.OrganizationRoles.Interfaces;
using Newtonsoft.Json;

namespace AgencyPro.OrganizationRoles.Models.OrganizationCustomers
{
    public class OrganizationCustomerOutput : OrganizationCustomerInput, IOrganizationCustomer, IAgencyOwner, IMarketingAgencyOwner, IRecruitingAgencyOwner, IProviderAgencyOwner
    {
        public virtual string OrganizationImageUrl { get; set; }
        public virtual string OrganizationName { get; set; }
        public virtual string DisplayName { get; set; }
        public virtual string ImageUrl { get; set; }
        public bool IsMarketingOwner { get; set; }
        public bool IsRecruitingOwner { get; set; }
        public bool IsProviderOwner { get; set; }

        [JsonIgnore]
        public string StripeCustomerId { get; }
    }
}