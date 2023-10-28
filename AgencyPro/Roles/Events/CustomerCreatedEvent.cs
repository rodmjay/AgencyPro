using AgencyPro.Roles.ViewModels.Customers;

namespace AgencyPro.Roles.Events
{
    public class CustomerCreatedEvent<T> : CustomerEvent<T> where T : CustomerOutput
    {
        // marketer
    }
}