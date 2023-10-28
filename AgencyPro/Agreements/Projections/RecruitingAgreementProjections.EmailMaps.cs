using AgencyPro.Agreements.Emails;
using AgencyPro.Agreements.Entities;

namespace AgencyPro.Agreements.Projections
{
    public partial class RecruitingAgreementProjections
    {
        private void CreateEmails()
        {
            CreateMap<RecruitingAgreement, RecruitingAgencyAgreementEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.RecruitingOrganization.Organization.Customer.Person.User.SendMail))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.RecruitingOrganization.Organization.Customer.Person.DisplayName))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.RecruitingOrganization.Organization.Customer.Person.User.Email));

            CreateMap<RecruitingAgreement, ProviderRecruitingAgreementEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.Customer.Person.User.SendMail))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.Customer.Person.DisplayName))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.Customer.Person.User.Email));

        }
    }
}