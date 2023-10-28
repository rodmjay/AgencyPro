using System;
using AgencyPro.Roles.Interfaces;

namespace AgencyPro.Roles.ViewModels.Customers
{
    public class CustomerOutput : CustomerInput, ICustomer
    {
        public Guid Id { get; set; }
        public string StripeId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public string DisplayName { get; set; }
    }
}