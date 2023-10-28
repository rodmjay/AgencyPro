using AgencyPro.Proposals.Emails;
using AgencyPro.Proposals.Entities;

namespace AgencyPro.Proposals.Projections
{
    public partial class ProposalProjections
    {
        private void CreateEmailProjections()
        {
            CreateMap<FixedPriceProposal, AccountManagerProposalEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.Project.AccountManager.Person.User.SendMail))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.Project.AccountManager.Person.User.Email))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.Project.AccountManager.Person.DisplayName));

            CreateMap<FixedPriceProposal, AgencyOwnerProposalEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.Project.ProviderOrganization.Organization.Customer.Person.User.SendMail))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.Project.ProviderOrganization.Organization.Customer.Person.DisplayName))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.Project.ProviderOrganization.Organization.Customer.Person.User.Email));

            CreateMap<FixedPriceProposal, CustomerProposalEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.Project.Customer.Person.User.SendMail))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.Project.Customer.Person.DisplayName))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.Project.Customer.Person.User.Email));



            CreateMap<FixedPriceProposal, ProjectManagerProposalEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.Project.ProjectManager.Person.User.SendMail))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.Project.ProjectManager.Person.User.Email))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.Project.ProjectManager.Person.DisplayName));

        }
    }
}