using System;

namespace AgencyPro.Invoices.Models.InvoiceSummary
{
    public class ProjectInvoiceSummaryItem
    {
        
        public virtual string ProjectName { get; set; }
        public virtual Guid ProjectId { get; set; }
        public virtual string ProjectAbbreviation { get; set; }
        public virtual decimal ApprovedHours { get; set; }
        public virtual decimal ApprovedCustomerAmount { get; set; }
     
        public virtual Guid CustomerOrganizationId { get; set; }
        public virtual Guid CustomerId { get; set; }
        public virtual string CustomerImageUrl { get; set; }
        public virtual string CustomerName { get; set; }
        public virtual string CustomerOrganizationName { get; set; }
        public virtual string CustomerOrganizationImageUrl { get; set; }

    }
}