using System;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.OrganizationRoles.Models.OrganizationAccountManagers
{
    public class OrganizationAccountManagerInput : IOrganizationAccountManager
    {
        public virtual decimal AccountManagerStream { get; set; }
        public virtual Guid AccountManagerId { get; set; }
        public virtual Guid OrganizationId { get; set; }
    }
}