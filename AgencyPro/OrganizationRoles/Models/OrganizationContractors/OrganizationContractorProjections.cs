using System.Linq;
using AgencyPro.OrganizationPeople.Models;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.ProviderOrganizations.Models;
using AgencyPro.TimeEntries.Enums;
using AutoMapper;

namespace AgencyPro.OrganizationRoles.Models.OrganizationContractors
{
    public partial class OrganizationContractorProjections : Profile
    {
        public OrganizationContractorProjections()
        {

            CreateMap<OrganizationContractor, ContractorOrganizationOutput>()
                .IncludeMembers(x => x.Organization)
                .ForMember(x => x.ContractorStream, o => o.MapFrom(x => x.ContractorStream))
                .IncludeAllDerived();


            CreateMap<OrganizationContractor, OrganizationContractorOutput>()
                .ForMember(x => x.Status, opt => opt.MapFrom(x => x.OrganizationPerson.Status))
                .ForMember(x => x.DisplayName, opt => opt.MapFrom(x => x.Contractor.Person.DisplayName))
                .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Contractor.Person.User.Email))
                .ForMember(x => x.PhoneNumber, opt => opt.MapFrom(x => x.Contractor.Person.User.PhoneNumber))
                .ForMember(x => x.ImageUrl, opt => opt.MapFrom(x => x.Contractor.Person.ImageUrl))
                .ForMember(x => x.RecruiterId, opt => opt.MapFrom(x => x.Contractor.RecruiterId))
                .ForMember(x => x.RecruiterOrganizationId, opt => opt.MapFrom(x => x.Contractor.RecruiterOrganizationId))
                .ForMember(x => x.RecruiterName, opt => opt.MapFrom(x => x.Contractor.Recruiter.Person.DisplayName))
                .ForMember(x => x.RecruiterImageUrl, opt => opt.MapFrom(x => x.Contractor.Recruiter.Person.ImageUrl))
                .ForMember(x => x.RecruiterOrganizationName, opt => opt.MapFrom(x => x.Contractor.OrganizationRecruiter.Organization.Name))
                .ForMember(x => x.RecruiterOrganizationImageUrl, opt => opt.MapFrom(x => x.Contractor.OrganizationRecruiter.Organization.ImageUrl))

                .ForMember(x => x.PublicDisplayName,
                    opt => opt.MapFrom(x =>
                        x.Contractor.Person.FirstName + " " + x.Contractor.Person.LastName.Substring(0, 1) + "."))
                .IncludeAllDerived();

            CreateMap<OrganizationContractor, OrganizationContractorStatistics>()
                .ForMember(x=>x.MaxWeeklyHours, opt=>opt.MapFrom(x=>x.Contractor.HoursAvailable))
                .ForMember(x => x.TotalContracts,
                    opt => opt.MapFrom(x => x.Contracts.Count))
                .ForMember(x => x.TotalStories,
                    opt => opt.MapFrom(x => x.Stories.Count))
                
                .ForMember(x=>x.TimeEntryHours, opt=>opt.MapFrom(y=>y.TimeEntries.GroupBy(z=>z.Status).ToDictionary(a=>a.Key, a=>a.Sum(b=>b.TotalHours))))
                .ForMember(x=>x.TimeEntryEarnings, opt=>opt.MapFrom(y=>y.TimeEntries.GroupBy(z=>z.Status).ToDictionary(a=>a.Key, a=>a.Sum(b=>b.TotalContractorStream))))

                .ForMember(x => x.MaxBillableHours, opt => opt.MapFrom(x=>x.Contracts.Sum(y=>y.MaxWeeklyHours)))
                .ForMember(x => x.AvailableHours, opt => opt.MapFrom(x => x.Contractor.HoursAvailable))
               .IncludeAllDerived();

            CreateMap<OrganizationContractor, AccountManagerOrganizationContractorDetailsOutput>()
                .ForMember(x => x.Contracts, opt => opt.MapFrom(x => x.Contracts))
                .ForMember(x => x.Skills, opt => opt.MapFrom(x => x.Contractor.ContractorSkills))
                .ForMember(x=>x.Stories, opt=>opt.MapFrom(x=>x.Stories));

            CreateMap<OrganizationContractor, AgencyOwnerOrganizationContractorDetailsOutput>()
                .ForMember(x => x.Contracts, opt => opt.MapFrom(x => x.Contracts))
                // todo: filter this for just skills within the organization
                .ForMember(x => x.Skills, opt => opt.MapFrom(x => x.Contractor.ContractorSkills))
                .ForMember(x => x.Stories, opt => opt.MapFrom(x => x.Stories));

            CreateMap<OrganizationContractor, CustomerOrganizationContractorOutput>();
            CreateMap<OrganizationContractor, AgencyOwnerOrganizationContractorOutput>();
            CreateMap<OrganizationContractor, AccountManagerOrganizationContractorOutput>();
            CreateMap<OrganizationContractor, RecruiterOrganizationContractorOutput>();
            CreateMap<OrganizationContractor, ProjectManagerOrganizationContractorOutput>();
            CreateMap<OrganizationContractor, MarketerOrganizationContractorOutput>();
            CreateMap<OrganizationContractor, ProviderContractorOutput>();

           
            CreateMap<OrganizationContractor, ContractorCounts>()
                .ForMember(x => x.TimeEntries, opt => opt.MapFrom(x => x.TimeEntries.Count(a => a.Status == TimeStatus.Logged)))
                .ForMember(x => x.Stories, opt => opt.MapFrom(x => x.Stories.Count))
                .ForMember(x => x.Contracts, opt => opt.MapFrom(x => x.Contracts.Count));

            StoryOutputMappings();
        }
    }
}