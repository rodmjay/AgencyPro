using System;
using AgencyPro.Organizations.Enums;
using AgencyPro.Organizations.Interfaces;

namespace AgencyPro.Organizations.Models
{
    public class OrganizationOutput : OrganizationCreateInput, IOrganization
    {
        public virtual string CategoryName { get; set; }

        public virtual Guid Id { get; set; }

        public int CategoryId { get; set; }
        public virtual OrganizationType OrganizationType { get; set; }
        public virtual DateTimeOffset Created { get; set; }
        public virtual DateTimeOffset Updated { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public virtual string ImageUrl { get; set; }

        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string TertiaryColor { get; set; }


    }
}