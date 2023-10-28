using System.Collections.Generic;
using AgencyPro.CustomerAccounts.Models;
using AgencyPro.Leads.Models;

namespace AgencyPro.OrganizationRoles.Models.OrganizationAccountManagers
{
    public class AccountManagerOrganizationAccountManagerDetailsOutput : OrganizationAccountManagerStatistics
    {
        public virtual IList<AccountManagerCustomerAccountOutput> Accounts { get; set; }
        public virtual IList<AccountManagerLeadOutput> Leads { get; set; }
    }
}