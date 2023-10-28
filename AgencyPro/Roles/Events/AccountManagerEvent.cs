using AgencyPro.Common.Events;
using AgencyPro.Roles.ViewModels.AccountManagers;

namespace AgencyPro.Roles.Events
{
    public abstract class AccountManagerEvent : BaseEvent
    {
        public AccountManagerOutput AccountManager { get; set; }
    }
}