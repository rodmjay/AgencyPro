using System;
using AgencyPro.Organizations.Enums;

namespace AgencyPro.Organizations.Interfaces
{
    public interface IOrganization : IOrganizationTheme
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string ImageUrl { get; set; }
      
        int CategoryId { get; set; }
        OrganizationType OrganizationType { get; set; }

        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
        string City { get; set; }
        string Iso2 { get; set; }
        string ProvinceState { get; set; }
        string PostalCode { get; set; }
    }
}