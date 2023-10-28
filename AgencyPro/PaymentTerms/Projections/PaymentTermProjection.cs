using AgencyPro.PaymentTerms.Entities;
using AgencyPro.PaymentTerms.Models;
using AutoMapper;

namespace AgencyPro.PaymentTerms.Projections
{
    class PaymentTermProjection : Profile
    {
        public PaymentTermProjection()
        {
            CreateMap<PaymentTerm, PaymentTermOutput>()
                .ForMember(x => x.Name, o => o.MapFrom(x => x.Name))
                .ForMember(x => x.NetValue, o => o.MapFrom(x => x.NetValue))
                .ForMember(x => x.PaymentTermId, o => o.MapFrom(x => x.PaymentTermId));

            CreateMap<CategoryPaymentTerm, PaymentTermOutput>()
                .ForMember(x => x.Name, o => o.MapFrom(x => x.PaymentTerm.Name))
                .ForMember(x => x.NetValue, o => o.MapFrom(x => x.PaymentTerm.NetValue))
                .ForMember(x => x.PaymentTermId, o => o.MapFrom(x => x.PaymentTerm.PaymentTermId));

            CreateMap<OrganizationPaymentTerm, PaymentTermOutput>()
                .ForMember(x => x.Name, o => o.MapFrom(x => x.PaymentTerm.Name))
                .ForMember(x => x.NetValue, o => o.MapFrom(x => x.PaymentTerm.NetValue))
                .ForMember(x => x.PaymentTermId, o => o.MapFrom(x => x.PaymentTerm.PaymentTermId));
        }
    }
}
