using System;

namespace AgencyPro.Invoices.Models
{
    public class InvoiceContractLineItemInput
    {
        public virtual Guid ContractId { get; set; }
        public virtual Guid InvoiceId { get; set; }

        public virtual decimal HoursBilled { get; set; }
        public virtual decimal EffectiveContractorHourlyStream { get; set; }
        public virtual decimal EffectiveRecruiterHourlyStream { get; set; }
        public virtual decimal EffectiveMarketerHourlyStream { get; set; }
        public virtual decimal EffectiveProjectManagerHourlyStream { get; set; }
        public virtual decimal EffectiveAccountManagerHourlyStream { get; set; }
        public virtual decimal EffectiveAgencyHourlyStream { get; set; }
        public virtual decimal EffectiveSystemHourlyStream { get; set; }
    }
}