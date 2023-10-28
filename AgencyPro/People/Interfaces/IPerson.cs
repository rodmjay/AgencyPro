using System;
using AgencyPro.People.Enums;

namespace AgencyPro.People.Interfaces
{
    public interface IPerson
    {
        Guid Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string ImageUrl { get; set; }
        string City { get; set; }
        string Iso2 { get; set; }
        string ProvinceState { get; set; }
        
        PersonStatus Status { get; set; }
        string DisplayName { get; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
    }
}