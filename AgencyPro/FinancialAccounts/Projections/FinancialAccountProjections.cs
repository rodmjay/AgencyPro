using AgencyPro.FinancialAccounts.Entities;
using AgencyPro.FinancialAccounts.Models;
using AutoMapper;

namespace AgencyPro.FinancialAccounts.Projections
{
    public class FinancialAccountProjections : Profile
    {
        public FinancialAccountProjections()
        {
            CreateMap<FinancialAccount, FinancialAccountOutput>()
                .ForMember(x => x.AccountId, opt => opt.MapFrom(x => x.AccountId))
                .IncludeAllDerived();

            CreateMap<FinancialAccount, FinancialAccountDetails>()
                .ForMember(x => x.Transfers, opt => opt.MapFrom(x => x.Transfers))
                .IncludeAllDerived();


            CreateMap<OrganizationFinancialAccount, FinancialAccountDetails>()
                .IncludeMembers(x => x.FinancialAccount);


            CreateMap<IndividualFinancialAccount, FinancialAccountDetails>()
                .IncludeMembers(x => x.FinancialAccount);
        }
    }
}
