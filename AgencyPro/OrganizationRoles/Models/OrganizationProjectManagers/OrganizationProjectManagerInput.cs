using System;
using AgencyPro.OrganizationRoles.Interfaces;

namespace AgencyPro.OrganizationRoles.Models.OrganizationProjectManagers
{
    public class OrganizationProjectManagerInput : IOrganizationProjectManager
    {
        public virtual decimal ProjectManagerStream { get; set; }

        public virtual Guid ProjectManagerId { get; set; }
        public virtual Guid OrganizationId { get; set; }
    }
}