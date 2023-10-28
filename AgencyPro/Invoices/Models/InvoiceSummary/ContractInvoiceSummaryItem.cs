using System;

namespace AgencyPro.Invoices.Models.InvoiceSummary
{
    public class ContractInvoiceSummaryItem
    {
        public Guid ContractId { get; set; }
        public string ContractorName { get; set; }
        public string ContractorOrganizationName { get; set; }
        public string ContractorImageUrl { get; set; }
        public string ContractorOrganizationImageUrl { get; set; }
        public Guid ContractorId { get; set; }
        public Guid ContractorOrganizationId { get; set; }
        public decimal ApprovedHours { get; set; }
        public decimal ApprovedCustomerAmount { get; set; }
    }
}