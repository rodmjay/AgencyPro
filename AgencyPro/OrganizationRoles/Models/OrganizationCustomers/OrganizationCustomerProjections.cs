using System.Linq;
using AgencyPro.Orders.Enums;
using AgencyPro.OrganizationPeople.Models;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Proposals.Enums;
using AgencyPro.ProviderOrganizations.Models;
using AutoMapper;

namespace AgencyPro.OrganizationRoles.Models.OrganizationCustomers
{
    public class OrganizationCustomerProjections : Profile
    {
        public OrganizationCustomerProjections()
        {
            CreateMap<OrganizationCustomer, CustomerOrganizationOutput>()
                .IncludeMembers(x => x.Organization)
                .IncludeAllDerived();
            
            CreateMap<OrganizationCustomer, OrganizationCustomerOutput>()
                .ForMember(x => x.IsProviderOwner, opt => opt.MapFrom(x => x.Organization.ProviderOrganization != null))
                .ForMember(x => x.IsRecruitingOwner, opt => opt.MapFrom(x => x.Organization.RecruitingOrganization != null))
                .ForMember(x => x.IsMarketingOwner, opt => opt.MapFrom(x => x.Organization.MarketingOrganization != null))
                .ForMember(x => x.OrganizationName, opt => opt.MapFrom(x => x.Organization.Name))
                .ForMember(x => x.OrganizationImageUrl, opt => opt.MapFrom(x => x.Organization.ImageUrl))
                .ForMember(x => x.DisplayName, opt => opt.MapFrom(x => x.Customer.Person.DisplayName))
                .ForMember(x => x.ImageUrl, opt => opt.MapFrom(x => x.Customer.Person.ImageUrl))
                .IncludeAllDerived();

            CreateMap<OrganizationCustomer, RecruiterOrganizationCustomerOutput>().IncludeAllDerived();
            CreateMap<OrganizationCustomer, ProjectManagerOrganizationCustomerOutput>().IncludeAllDerived();
            CreateMap<OrganizationCustomer, MarketerOrganizationCustomerOutput>().IncludeAllDerived();
            CreateMap<OrganizationCustomer, CustomerOrganizationCustomerOutput>().IncludeAllDerived();
            CreateMap<OrganizationCustomer, ContractorOrganizationCustomerOutput>().IncludeAllDerived();
            CreateMap<OrganizationCustomer, AgencyOwnerOrganizationCustomerOutput>().IncludeAllDerived();
            CreateMap<OrganizationCustomer, AccountManagerOrganizationCustomerOutput>().IncludeAllDerived();

            CreateMap<OrganizationCustomer, CustomerCounts>()
                .ForMember(x => x.Proposals, opt => opt.MapFrom(x => x.Projects.Count(y => y.Proposal != null && y.Proposal.Status != ProposalStatus.Draft && y.Proposal.Status != ProposalStatus.Rejected)))
                .ForMember(x => x.Accounts, opt => opt.MapFrom(x => x.Accounts.Count))
                .ForMember(x => x.FinancialAccounts, opt => opt.MapFrom(x => x.Organization.OrganizationFinancialAccount == null ? 0 : 1))
                .ForMember(x => x.Projects, opt => opt.MapFrom(x => x.Projects.Count(p => p.Proposal != null && p.Proposal.Status == ProposalStatus.Accepted)))
                .ForMember(x => x.Contracts, opt => opt.MapFrom(x => x.Projects.SelectMany(y => y.Contracts.Where(z => z.Project.Proposal != null && z.Project.Proposal.Status == ProposalStatus.Accepted)).Count()))
                .ForMember(x => x.Invoices, opt => opt.MapFrom(x => x.Invoices.Count(y => y.Invoice.Status == "open" || y.Invoice.Status == "paid")))
                .ForMember(x => x.WorkOrders, opt => opt.MapFrom(x => x.Organization.BuyerWorkOrders.Count(y => y.Status != OrderStatus.Rejected)));
        }
    }
}