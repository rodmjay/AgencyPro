using AgencyPro.Orders.Entities;
using AgencyPro.Orders.Models;
using AutoMapper;

namespace AgencyPro.Orders.Projections
{
    public partial class WorkOrderProjections : Profile
    {
        public WorkOrderProjections()
        {
            CreateMap<WorkOrder, WorkOrderOutput>()
                .ForMember(x=>x.BuyerNumber, opt=>opt.MapFrom(x=>x.BuyerNumber))
                .ForMember(x=>x.ProviderNumber, opt=>opt.MapFrom(x=>x.ProviderNumber))
                .ForMember(x=>x.Description, opt=>opt.MapFrom(x=>x.Description))
                .ForMember(x => x.CustomerId, opt => opt.MapFrom(x => x.CustomerId))
                .ForMember(x => x.CustomerName, opt => opt.MapFrom(x => x.Customer.Person.DisplayName))
                .ForMember(x => x.CustomerEmail, opt => opt.MapFrom(x => x.Customer.Person.User.Email))
                .ForMember(x => x.CustomerPhoneNumber, opt => opt.MapFrom(x => x.Customer.Person.User.PhoneNumber))
                .ForMember(x => x.CustomerImageUrl,
                    opt => opt.MapFrom(x => x.Customer.Person.ImageUrl))
                .ForMember(x => x.CustomerOrganizationId, opt => opt.MapFrom(x => x.CustomerOrganizationId))
                .ForMember(x => x.CustomerOrganizationName,
                    opt => opt.MapFrom(x => x.CustomerAccount.OrganizationCustomer.Organization.Name))
                .ForMember(x => x.CustomerOrganizationImageUrl,
                    opt => opt.MapFrom(x => x.CustomerAccount.OrganizationCustomer.Organization.ImageUrl))

                .ForMember(x => x.AccountManagerId, opt => opt.MapFrom(x => x.AccountManagerId))
                .ForMember(x => x.AccountManagerName, opt => opt.MapFrom(x => x.AccountManager.Person.DisplayName))
                .ForMember(x => x.AccountManagerEmail, opt => opt.MapFrom(x => x.AccountManager.Person.User.Email))
                .ForMember(x => x.AccountManagerPhoneNumber, opt => opt.MapFrom(x => x.AccountManager.Person.User.PhoneNumber))

                .ForMember(x => x.AccountManagerImageUrl,
                    opt => opt.MapFrom(x => x.AccountManager.Person.ImageUrl))

                .ForMember(x => x.AccountManagerOrganizationId, opt => opt.MapFrom(x => x.AccountManagerOrganizationId))

                .ForMember(x => x.AccountManagerOrganizationName,
                    opt => opt.MapFrom(x => x.CustomerAccount.OrganizationAccountManager.Organization.Name))
                .ForMember(x => x.AccountManagerOrganizationImageUrl,
                    opt => opt.MapFrom(x => x.CustomerAccount.OrganizationAccountManager.Organization.ImageUrl))
                .IncludeAllDerived();

            CreateMap<WorkOrder, ProviderWorkOrderOutput>().IncludeAllDerived();
            CreateMap<WorkOrder, BuyerWorkOrderOutput>().IncludeAllDerived();

            EmailProjections();
        }
    }
}
