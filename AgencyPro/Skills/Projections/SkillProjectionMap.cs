using AgencyPro.Skills.Entities;
using AgencyPro.Skills.Models;
using AutoMapper;

namespace AgencyPro.Skills.Projections
{
    public class SkillProjectionMap : Profile
    {
        public SkillProjectionMap()
        {
            CreateMap<Skill, SkillOutput>()
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(x => x.Priority, opt => opt.MapFrom(x => x.Priority))
                .ForMember(x => x.IconUrl, opt => opt.MapFrom(x => x.IconUrl))
                .IncludeAllDerived();

            //CreateMap<OrganizationSkill, SkillOutput>()
            //    .ForMember(x=>x.Id, opt=>opt.MapFrom(x=>x.Skill.Id))
            //    .ForMember(x=>x.Name, opt=>opt.MapFrom(x=>x.Skill.Name))
            //    .ForMember(x=>x.Priority, opt=>opt.MapFrom(x=>x.Priority))
            //    .ForMember(x=>x.IconUrl, opt=>opt.MapFrom(x=>x.Skill.IconUrl))
            //    .IncludeAllDerived();

            CreateMap<OrganizationSkill, OrganizationSkillOutput>()
                .ForMember(x => x.SkillName, opt => opt.MapFrom(x => x.Skill.Name))
                .ForMember(x => x.SkillId, opt => opt.MapFrom(x => x.Skill.Id))
                .ForMember(x => x.Priority, opt => opt.MapFrom(x => x.Priority))
                .IncludeAllDerived();

            CreateMap<OrganizationSkill, SkillOutput>()
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Skill.Id))
                .ForMember(x => x.Priority, opt => opt.MapFrom(x => x.Priority))
                .ForMember(x => x.Name, o => o.MapFrom(x => x.Skill.Name))
                .IncludeAllDerived();

            CreateMap<ContractorSkill, ContractorSkillOutput>()
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Skill.Name))
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Skill.Id))
                .ForMember(x => x.Priority, opt => opt.MapFrom(x => x.Skill.Priority))
                .IncludeAllDerived();

            CreateMap<ContractorSkill, SkillOutput>()
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Skill.Id))
                .ForMember(x => x.Priority, opt => opt.MapFrom(x => x.Skill.Priority))
                .ForMember(x => x.Name, o => o.MapFrom(x => x.Skill.Name))
                .IncludeAllDerived();

        }
    }
}