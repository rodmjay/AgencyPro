using System.Linq;
using AgencyPro.Candidates.Entities;
using AgencyPro.Candidates.Models;
using AutoMapper;

namespace AgencyPro.Candidates.Projections
{
    public partial class CandidateProjections : Profile
    {
        public CandidateProjections()
        {
            CreateMap<Candidate, CandidateOutput>()
                .ForMember(x=>x.ProviderOrganizationId, opt=>opt.MapFrom(x=>x.ProviderOrganization.Id))
                .ForMember(x=>x.ProviderOrganizationImageUrl, opt=>opt.MapFrom(x=>x.ProviderOrganization.Organization.ImageUrl))
                .ForMember(x=>x.ProviderOrganizationName, opt=>opt.MapFrom(x=>x.ProviderOrganization.Organization.Name))


                .ForMember(x => x.RecruitingOrganizationOwnerId, opt => opt.MapFrom(x => x.RecruiterOrganization.CustomerId))
                .ForMember(x => x.ProviderOrganizationOwnerId, opt => opt.MapFrom(x => x.ProviderOrganization.Organization.CustomerId))


                .ForMember(x => x.RecruiterOrganizationImageUrl,
                    opt => opt.MapFrom(x => x.OrganizationRecruiter.Organization.ImageUrl))
                .ForMember(x => x.RecruiterOrganizationName,
                    opt => opt.MapFrom(x => x.OrganizationRecruiter.Organization.Name))
                .ForMember(x => x.RecruiterName,
                    opt => opt.MapFrom(x => x.Recruiter.Person.DisplayName))
                .ForMember(x => x.RecruiterEmail,
                    opt => opt.MapFrom(x => x.Recruiter.Person.User.Email))
                .ForMember(x => x.RecruiterPhoneNumber,
                    opt => opt.MapFrom(x => x.Recruiter.Person.User.PhoneNumber))
                .ForMember(x => x.RecruiterImageUrl,
                    opt => opt.MapFrom(x => x.Recruiter.Person.ImageUrl))
                .ForMember(x => x.ProjectManagerOrganizationImageUrl,
                    opt => opt.MapFrom(x => x.OrganizationProjectManager.Organization.ImageUrl))
                .ForMember(x => x.ProjectManagerOrganizationName,
                    opt => opt.MapFrom(x => x.OrganizationProjectManager.Organization.Name))
                .ForMember(x => x.ProjectManagerName,
                    opt => opt.MapFrom(x => x.ProjectManager.Person.DisplayName))
                .ForMember(x => x.ProjectManagerImageUrl,
                    opt => opt.MapFrom(x => x.ProjectManager.Person.ImageUrl))


                .ForMember(x=>x.StatusTransitions, opt=>opt.MapFrom(x=>x.StatusTransitions.ToDictionary(a=>a.Created, b=>b.Status)))

                .ForMember(x=>x.RecruiterBonus, opt=>opt.MapFrom(x=>x.RecruiterBonus))
                .ForMember(x=>x.RecruiterStream, opt=>opt.MapFrom(x=>x.RecruiterStream))
                .ForMember(x=>x.RecruitingAgencyBonus, opt=>opt.MapFrom(x=>x.RecruitingAgencyBonus))
                .ForMember(x=>x.RecruitingAgencyStream, opt=>opt.MapFrom(x=>x.RecruitingAgencyStream))
                .IncludeAllDerived();

            CreateMap<Candidate, AgencyOwnerCandidateOutput>()
                
                .IncludeAllDerived();

            CreateMap<Candidate, AgencyOwnerCandidateDetailsOutput>()
                .ForMember(x => x.Comments, o => o.MapFrom(x => x.Comments.OrderBy(y => y.Created)));

            CreateMap<Candidate, RecruiterCandidateOutput>()
                .IncludeAllDerived();

            CreateMap<Candidate, RecruiterCandidateDetailsOutput>()
                .ForMember(x => x.Comments, o => o.MapFrom(x => x.Comments.OrderBy(y => y.Created)));

            CreateMap<Candidate, RecruitingAgencyCandidateOutput>()
                .IncludeAllDerived();

            CreateMap<Candidate, ProjectManagerCandidateOutput>()
                .IncludeAllDerived();

            CreateMap<Candidate, ProjectManagerCandidateDetailsOutput>()
                .ForMember(x => x.Comments, o => o.MapFrom(x => x.Comments.OrderBy(y => y.Created)));

            CreateEmailsMaps();
        }
    }
}