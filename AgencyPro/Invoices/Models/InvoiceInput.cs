using System;

namespace AgencyPro.Invoices.Models
{
    public class InvoiceInput
    {
        public InvoiceInput()
        {
        }

        public virtual Guid ProjectId { get; set; }
        
        public virtual Guid[] ContractIds { get; set; }

        public virtual bool IncludeAllContracts { get; set; }
        
        public string RefNo { get; set; }

        public decimal? AdditionalAmount { get; set; }
        public string AdditionalDescription { get; set; }
    }
}