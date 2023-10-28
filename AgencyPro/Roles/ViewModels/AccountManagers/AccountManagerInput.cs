using System;

namespace AgencyPro.Roles.ViewModels.AccountManagers
{
    public class AccountManagerInput : AccountManagerUpdateInput
    {
        public Guid PersonId { get; set; }
    }
}