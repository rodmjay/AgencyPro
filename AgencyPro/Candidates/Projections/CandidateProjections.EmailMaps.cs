using AgencyPro.Candidates.Emails;
using AgencyPro.Candidates.Entities;

namespace AgencyPro.Candidates.Projections
{
    public partial class CandidateProjections
    {
        private void CreateEmailsMaps()
        {
            CreateMap<Candidate, AgencyOwnerCandidateEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.Customer.Person.User.SendMail))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.Customer.Person.DisplayName))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.Customer.Person.User.Email));

            CreateMap<Candidate, RecruiterCandidateEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.Recruiter.Person.User.SendMail))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.Recruiter.Person.User.Email))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.Recruiter.Person.DisplayName));

            CreateMap<Candidate, ProjectManagerCandidateEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.ProjectManager.Person.User.SendMail))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.ProjectManager.Person.User.Email))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.ProjectManager.Person.DisplayName));

            CreateMap<Candidate, RecruitingAgencyOwnerCandidateEmail>()
                .ForMember(x => x.SendMail, opt => opt.MapFrom(x => x.RecruiterOrganization.Customer.Person.User.SendMail))
                .ForMember(x => x.RecipientName, opt => opt.MapFrom(x => x.RecruiterOrganization.Customer.Person.DisplayName))
                .ForMember(x => x.RecipientEmail, opt => opt.MapFrom(x => x.RecruiterOrganization.Customer.Person.User.Email));

        }
    }
}