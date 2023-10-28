using System;

namespace AgencyPro.Invoices.Interfaces
{
    public interface IInvoiceContractLineItem
    {
        Guid InvoiceId { get; set; }
        Guid ContractId { get; set; }
        decimal HoursBilled { get; set; }
        decimal EffectiveContractorHourlyStream { get; set; }
        decimal EffectiveRecruiterHourlyStream { get; set; }
        decimal EffectiveMarketerHourlyStream { get; set; }
        decimal EffectiveProjectManagerHourlyStream { get; set; }
        decimal EffectiveAccountManagerHourlyStream { get; set; }
        decimal EffectiveAgencyHourlyStream { get; set; }
        decimal EffectiveSystemHourlyStream { get; set; }
        decimal TotalRecruiterStream { get; set; }
        decimal TotalMarketerStream { get; set; }
        decimal TotalProjectManagerStream { get; set; }
        decimal TotalAccountManagerStream { get; set; }
        decimal TotalAgencyStream { get; set; }
        decimal TotalSystemStream { get; set; }
        decimal TotalContractorStream { get; set; }
        decimal CustomerTotal { get; set; }
        decimal EffectiveCustomerHourlyRate { get; set; }
        string Description { get; set; }
    }
}