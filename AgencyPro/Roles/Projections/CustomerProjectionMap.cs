using AgencyPro.Roles.Entities;
using AgencyPro.Roles.ViewModels.Customers;
using AutoMapper;

namespace AgencyPro.Roles.Projections
{
    public class CustomerProjectionMap : Profile
    {
        public CustomerProjectionMap()
        {

            CreateMap<Customer, CustomerOutput>()
                .ForMember(x => x.DisplayName, opt => opt.MapFrom(x => x.Person.DisplayName))
                .IncludeAllDerived();

            CreateMap<Customer, CustomerDetailsOutput>()
                .IncludeAllDerived();

            CreateMap<Customer, MarketerCustomerOutput>()
                .IncludeAllDerived();
        }
    }
}