using AgencyPro.RecruitingOrganizations.Entities;
using AgencyPro.RecruitingOrganizations.Models;
using AutoMapper;

namespace AgencyPro.RecruitingOrganizations.Projections
{
    public class RecruitingOrganizationProjections : Profile
    {
        public RecruitingOrganizationProjections()
        {
            CreateMap<RecruitingOrganization, RecruitingOrganizationOutput>()
                .IncludeMembers(x => x.Organization)
                .ForMember(x => x.DefaultRecruiterId, o => o.MapFrom(x => x.DefaultRecruiterId))
                .IncludeAllDerived();

            CreateMap<RecruitingOrganization, RecruitingOrganizationDetailsOutput>()
                .IncludeAllDerived();

            CreateMap<RecruitingOrganization, AgencyOwnerRecruitingOrganizationDetailsOutput>()
                .IncludeMembers(x => x.Organization)
                .IncludeAllDerived();

            CreateMap<RecruitingOrganization, ProviderAgencyOwnerRecruitingOrganizationOutput>()
                .IncludeMembers(x => x.Organization)
                .IncludeAllDerived();
            
        }

    }
}