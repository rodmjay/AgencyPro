using AgencyPro.Agreements.Emails;
using AgencyPro.Agreements.Entities;

namespace AgencyPro.Agreements.Projections
{
    public partial class MarketingAgreementProjections
    {
        private void CreateEmailMaps()
        {
            CreateMap<MarketingAgreement, MarketingAgencyAgreementEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.MarketingOrganization.Organization.Customer.Person.User.SendMail))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.MarketingOrganization.Organization.Customer.Person.DisplayName))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.MarketingOrganization.Organization.Customer.Person.User.Email));

            CreateMap<MarketingAgreement, ProviderMarketingAgreementEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.Customer.Person.User.SendMail))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.Customer.Person.DisplayName))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.Customer.Person.User.Email));

        }
    }
}