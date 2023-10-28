using System;
using AgencyPro.Roles.Interfaces;

namespace AgencyPro.Roles.ViewModels.AccountManagers
{
    public class AccountManagerOutput : AccountManagerInput, IAccountManager
    {
        public virtual Guid Id { get; set; }
        public virtual DateTimeOffset Created { get; set; }
        public virtual DateTimeOffset Updated { get; set; }
    }
}