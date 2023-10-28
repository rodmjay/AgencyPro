using System;
using AgencyPro.Common.Models;

namespace AgencyPro.Orders.Models
{
    public class WorkOrderFilters : CommonFilters
    {
        public Guid? AccountManagerOrganizationId { get; set; }
    }
}