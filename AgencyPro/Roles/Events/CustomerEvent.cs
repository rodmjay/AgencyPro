using AgencyPro.Common.Events;
using AgencyPro.Roles.ViewModels.Customers;

namespace AgencyPro.Roles.Events
{
    public abstract class CustomerEvent<T> : BaseEvent where T : CustomerOutput
    {
        public T Customer { get; set; }
    }
}