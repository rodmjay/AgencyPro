using AgencyPro.PayoutIntents.Entities;
using AgencyPro.PayoutIntents.Models;

namespace AgencyPro.PayoutIntents.Projections
{
    public partial class PayoutIntentProjections
    {
        private void CreateOrganizationPayoutMaps()
        {
            CreateMap<OrganizationPayoutIntent, OrganizationPayoutIntentOutput>()
                .ForMember(x => x.ContractorName, opt => opt.MapFrom(x => x.InvoiceItem.Contract.Contractor.Person.DisplayName))
                .ForMember(x => x.ContractorImageUrl, opt => opt.MapFrom(x => x.InvoiceItem.Contract.Contractor.Person.ImageUrl))
                .ForMember(x => x.ContractorId, opt => opt.MapFrom(x => x.InvoiceItem.Contract.ContractorId))
                .ForMember(x => x.ProviderOrganizationId, opt => opt.MapFrom(x => x.InvoiceItem.Contract.ProviderOrganization.Id))
                .ForMember(x => x.ProviderOrganizationName, opt => opt.MapFrom(x => x.InvoiceItem.Contract.ProviderOrganization.Organization.Name))
                .ForMember(x => x.ProviderOrganizationImageUrl, opt => opt.MapFrom(x => x.InvoiceItem.Contract.ProviderOrganization.Organization.ImageUrl))
                .ForMember(x => x.PeriodStart, opt => opt.MapFrom(x => x.InvoiceItem.PeriodStart))
                .ForMember(x => x.PeriodEnd, opt => opt.MapFrom(x => x.InvoiceItem.PeriodStart))
                .ForMember(x => x.ProjectId, opt => opt.MapFrom(x => x.InvoiceItem.Contract.ProjectId))
                .ForMember(x => x.ProjectName, opt => opt.MapFrom(x => x.InvoiceItem.Contract.Project.Name))
                .ForMember(x => x.InvoiceNumber, opt => opt.MapFrom(x => x.InvoiceItem.Invoice.Number))
                .ForMember(x => x.InvoiceDueDate, opt => opt.MapFrom(x => x.InvoiceItem.Invoice.DueDate))
                .ForMember(x => x.Created, opt => opt.MapFrom(x => x.Created))
                .ForMember(x => x.OrganizationId, opt => opt.MapFrom(x => x.OrganizationId))
                .ForMember(x => x.OrganizationName, opt => opt.MapFrom(x => x.Organization.Name))
                .ForMember(x => x.PayoutsEnabled, opt => opt.MapFrom(x => x.Organization.OrganizationFinancialAccount != null && x.Organization.OrganizationFinancialAccount.FinancialAccount.PayoutsEnabled))
                .ForMember(x => x.TransferAmount, opt => opt.MapFrom(x => x.InvoiceTransfer.Transfer.Amount + x.InvoiceTransfer.Transfer.AmountReversed))
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id));
        }
    }
}