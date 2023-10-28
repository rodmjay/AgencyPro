using AgencyPro.PayoutIntents.Entities;
using AgencyPro.PayoutIntents.Models;

namespace AgencyPro.PayoutIntents.Projections
{
    public partial class PayoutIntentProjections
    {
        private void CreateIndividualPayoutMaps()
        {
            CreateMap<IndividualPayoutIntent, IndividualPayoutIntentOutput>()
                .ForMember(x => x.ContractorName, opt => opt.MapFrom(x => x.InvoiceItem.Contract.Contractor.Person.DisplayName))
                .ForMember(x => x.ContractorImageUrl, opt => opt.MapFrom(x => x.InvoiceItem.Contract.Contractor.Person.ImageUrl))
                .ForMember(x => x.ContractorId, opt => opt.MapFrom(x => x.InvoiceItem.Contract.ContractorId))
                .ForMember(x => x.PersonId, opt => opt.MapFrom(x => x.PersonId))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.Person.DisplayName))
                .ForMember(x => x.ProviderOrganizationId, opt => opt.MapFrom(x => x.InvoiceItem.Contract.ProviderOrganization.Id))
                .ForMember(x => x.ProviderOrganizationName, opt => opt.MapFrom(x => x.InvoiceItem.Contract.ProviderOrganization.Organization.Name))
                .ForMember(x => x.ProviderOrganizationImageUrl, opt => opt.MapFrom(x => x.InvoiceItem.Contract.ProviderOrganization.Organization.ImageUrl))
                .ForMember(x => x.PeriodStart, opt => opt.MapFrom(x => x.InvoiceItem.PeriodStart))
                .ForMember(x => x.PeriodEnd, opt => opt.MapFrom(x => x.InvoiceItem.PeriodStart))
                .ForMember(x => x.ProjectId, opt => opt.MapFrom(x => x.InvoiceItem.Contract.ProjectId))
                .ForMember(x => x.ProjectName, opt => opt.MapFrom(x => x.InvoiceItem.Contract.Project.Name))
                .ForMember(x => x.InvoiceNumber, opt => opt.MapFrom(x => x.Invoice.Number))
                .ForMember(x => x.InvoiceDueDate, opt => opt.MapFrom(x => x.Invoice.DueDate))
                .ForMember(x => x.Created, opt => opt.MapFrom(x => x.Created))
                .ForMember(x => x.TransferAmount, opt => opt.MapFrom(x => x.InvoiceTransfer.Transfer.Amount + x.InvoiceTransfer.Transfer.AmountReversed))
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(x => x.PayoutsEnabled, opt => opt.MapFrom(x => x.Person.IndividualFinancialAccount != null && x.Person.IndividualFinancialAccount.FinancialAccount.PayoutsEnabled))
                .ForMember(x => x.Amount, opt => opt.MapFrom(x => x.Amount));
        }
    }
}