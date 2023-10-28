using AgencyPro.Charges.Entities;
using AgencyPro.Charges.Models;
using AutoMapper;

namespace AgencyPro.Charges.Projections
{
    public class ChargeProjections : Profile
    {
        public ChargeProjections()
        {
            CreateMap<StripeCharge, ChargeOutput>()
                .ForMember(x=>x.CustomerOrganizationName, 
                    opt=>opt.MapFrom(x=>x.Customer.OrganizationBuyerAccount.Organization.Name));
        }
    }
}
