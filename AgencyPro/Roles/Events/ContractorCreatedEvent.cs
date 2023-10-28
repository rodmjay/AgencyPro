using AgencyPro.Roles.ViewModels.Contractors;

namespace AgencyPro.Roles.Events
{
    public class ContractorCreatedEvent<T> : ContractorEvent<T> where T : ContractorOutput
    {
    }
}