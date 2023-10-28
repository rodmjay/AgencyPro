using AgencyPro.Common.Services.Interfaces;
using AgencyPro.Roles.Entities;
using AgencyPro.Roles.ViewModels.AccountManagers;

namespace AgencyPro.Roles.Interfaces
{
    public interface IAccountManagerService : IService<AccountManager>,
        IRoleService<AccountManagerInput, AccountManagerUpdateInput, AccountManagerOutput, IAccountManager>
    {
    }
}