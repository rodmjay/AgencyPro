using AgencyPro.Leads.Emails;
using AgencyPro.Leads.Entities;

namespace AgencyPro.Leads.Projections
{
    public partial class LeadProjections
    {
        private void EmailMaps()
        {
            CreateMap<Lead, AgencyOwnerLeadEmail>()
                .ForMember(x=>x.SendMail, opt=>opt.MapFrom(x=>x.ProviderOrganization.Organization.Customer.Person.User.SendMail))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.Customer.Person.DisplayName))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.Customer.Person.User.Email));

            CreateMap<Lead, MarketerLeadEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.Marketer.Person.User.SendMail))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.Marketer.Person.User.Email))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.Marketer.Person.DisplayName));

            CreateMap<Lead, AccountManagerLeadEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.AccountManager.Person.User.SendMail))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x =>x.AccountManager.Person.User.Email))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.AccountManager.Person.DisplayName));

            CreateMap<Lead, MarketingAgencyOwnerLeadEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.MarketerOrganization.Customer.Person.User.SendMail))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.MarketerOrganization.Customer.Person.DisplayName))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.MarketerOrganization.Customer.Person.User.Email));
        }
    }
}