using System;
using AgencyPro.CustomerAccounts.Enums;
using Newtonsoft.Json;

namespace AgencyPro.CustomerAccounts.Models
{
    public class ProjectManagerCustomerAccountOutput
    {
        public string CustomerName { get; set; }
        public string CustomerOrganizationName { get; set; }
        public int Number { get; set; }
        public Guid CustomerId { get; set; }
        public Guid CustomerOrganizationId { get; set; }
        [JsonIgnore] public virtual bool IsDeactivated { get; set; }
        public virtual AccountStatus Status => IsDeactivated ? AccountStatus.Inactive : AccountStatus.Active;
    }
}