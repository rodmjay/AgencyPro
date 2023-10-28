using AgencyPro.Roles.Models;
using AgencyPro.Roles.ViewModels.AccountManagers;
using AutoMapper;

namespace AgencyPro.Roles.Projections
{
    public class AccountManagerProjections : Profile
    {
        public AccountManagerProjections()
        {
            CreateMap<AccountManager, AccountManagerOutput>()
                .IncludeAllDerived();
            CreateMap<AccountManager, AccountManagerDetailsOutput>();
        }
    }
}