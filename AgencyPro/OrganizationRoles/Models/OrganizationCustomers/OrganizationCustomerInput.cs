using System;

namespace AgencyPro.OrganizationRoles.Models.OrganizationCustomers
{
    public class OrganizationCustomerInput
    {
        public virtual Guid CustomerId { get; set; }
        public virtual Guid OrganizationId { get; set; }
    }
}