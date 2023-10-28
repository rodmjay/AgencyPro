using System;
using AgencyPro.Orders.Enums;
using AgencyPro.Orders.Interfaces;
using AgencyPro.Organizations.Interfaces;

namespace AgencyPro.Orders.Models
{
    public abstract class WorkOrderOutput : WorkOrderInput, IWorkOrder, IOrganizationPersonTarget
    {
        public Guid Id { get; set; }
        public virtual int BuyerNumber { get; set; }
        public virtual int ProviderNumber { get; set; }
       
        public OrderStatus Status { get; set; }
        

        public Guid CustomerId { get; set; }
        public Guid CustomerOrganizationId { get; set; }
        public DateTimeOffset? ProviderResponseTime { get; set; }

        public virtual string CustomerName { get; set; }
        public virtual string CustomerEmail { get; set; }
        public virtual string CustomerPhoneNumber { get; set; }
        public virtual string CustomerImageUrl { get; set; }
        public virtual string CustomerOrganizationImageUrl { get; set; }
        public virtual string CustomerOrganizationName { get; set; }

        public virtual string AccountManagerName { get; set; }
        public virtual string AccountManagerEmail { get; set; }
        public virtual string AccountManagerPhoneNumber { get; set; }
        public virtual string AccountManagerImageUrl { get; set; }
        public virtual string AccountManagerOrganizationImageUrl { get; set; }
        public virtual string AccountManagerOrganizationName { get; set; }

        public abstract Guid TargetOrganizationId { get; }
        public abstract Guid TargetPersonId { get; }
    }
}
