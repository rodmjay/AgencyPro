using System.Collections.Generic;
using AgencyPro.CustomerAccounts.Models;
using AgencyPro.Leads.Models;

namespace AgencyPro.OrganizationRoles.Models.OrganizationAccountManagers
{
    public class AgencyOwnerOrganizationAccountManagerDetailsOutput : OrganizationAccountManagerStatistics
    {
        public virtual IList<AgencyOwnerCustomerAccountOutput> Accounts { get; set; }
        public virtual IList<AgencyOwnerLeadOutput> Leads { get; set; }


    }
}