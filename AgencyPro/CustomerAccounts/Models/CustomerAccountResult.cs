using System;
using AgencyPro.Common.Models;

namespace AgencyPro.CustomerAccounts.Models
{
    public class CustomerAccountResult : Result
    {
        public Guid? CustomerOrganizationId { get; set; }
        public Guid? AccountManagerOrganizationId { get; set; }
        public Guid? AccountManagerId { get; set; }
        public Guid? CustomerId { get; set; }
        public int? Number { get; set; }
        public int? BuyerNumber { get; set; }
    }
}