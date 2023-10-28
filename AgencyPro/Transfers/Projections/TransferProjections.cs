using AgencyPro.Transfers.Entities;
using AgencyPro.Transfers.Models;
using AutoMapper;

namespace AgencyPro.Transfers.Projections
{
    public class TransferProjections : Profile
    {
        public TransferProjections()
        {
            CreateMap<StripeTransfer, TransferOutput>()
                .ForMember(x => x.AmountReversed, opt => opt.MapFrom(x => x.AmountReversed))
                .ForMember(x => x.Created, opt => opt.MapFrom(x => x.Created))
                .ForMember(x => x.Amount, opt =>  opt.MapFrom(x => x.Amount))
                .ForMember(x => x.Description, opt =>
                    opt.MapFrom(x => x.Description))
                .ForMember(x => x.DestinationId, opt => 
                    opt.MapFrom(x => x.DestinationId))
                .ForMember(x => x.DestinationPaymentId, 
                    opt => opt.MapFrom(x => x.DestinationPaymentId))
                .ForMember(x => x.InvoiceId, 
                    opt => opt.MapFrom(x => x.InvoiceTransfer.InvoiceId))
                .ForMember(x => x.RecipientName, 
                    opt => opt.MapFrom(x => x.InvoiceTransfer.Transfer.DestinationAccount.IndividualFinancialAccount.Person.DisplayName))
                .ForMember(x => x.OrganizationName, 
                    opt => opt.MapFrom(x => x.InvoiceTransfer.Transfer.DestinationAccount.OrganizationFinancialAccount.Organization.Name))
                .ForMember(x => x.IndividualTransfer,
                    opt => opt.MapFrom(x => x.InvoiceTransfer.Transfer.DestinationAccount.IndividualFinancialAccount != null))
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id));

            CreateMap<InvoiceTransfer, TransferOutput>()
                .IncludeMembers(x => x.Transfer);

        }
    }
}
