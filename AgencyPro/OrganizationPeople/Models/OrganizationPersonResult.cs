using System;
using AgencyPro.Common.Models;

namespace AgencyPro.OrganizationPeople.Models
{
    public class OrganizationPersonResult : Result
    {
        public Guid? OrganizationId { get; set; }
        public Guid? PersonId { get; set; }
    }
}