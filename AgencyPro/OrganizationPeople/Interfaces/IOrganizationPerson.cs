using System;
using AgencyPro.People.Enums;

namespace AgencyPro.OrganizationPeople.Interfaces
{
    public interface IOrganizationPerson
    {
        Guid OrganizationId { get; set; }
        Guid PersonId { get; set; }
        PersonStatus Status { get; set; }
        bool IsHidden { get; set; }
        long PersonFlags { get; set; }
        long AgencyFlags { get; set; }
        bool IsOrganizationOwner { get; set; }
        bool IsDefault { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset Updated { get; set; }
    }
}