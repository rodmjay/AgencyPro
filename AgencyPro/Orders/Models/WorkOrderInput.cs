using System;

namespace AgencyPro.Orders.Models
{
    public class WorkOrderInput
    {
        public Guid AccountManagerId { get; set; }
        public Guid AccountManagerOrganizationId { get; set; }
        public string Description { get; set; }
        public bool IsDraft { get; set; }
    }
}