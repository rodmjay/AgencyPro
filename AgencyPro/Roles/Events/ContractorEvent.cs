using AgencyPro.Common.Events;
using AgencyPro.Roles.ViewModels.Contractors;

namespace AgencyPro.Roles.Events
{
    public abstract class ContractorEvent<T> : BaseEvent where T : ContractorOutput
    {
        // notify recruiter

        public T Contractor { get; set; }
    }
}