using AgencyPro.Levels.Entities;
using AgencyPro.Levels.Models;
using AutoMapper;

namespace AgencyPro.Levels.Projections
{
    public class LevelProjections : Profile
    {
        public LevelProjections()
        {
            CreateMap<Level, LevelOutput>()
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id));
        }
    }
}
