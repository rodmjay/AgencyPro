using AgencyPro.Positions.Entities;
using AgencyPro.Positions.Models;
using AutoMapper;

namespace AgencyPro.Positions.Projections
{
    public class PositionProjections : Profile
    {
        public PositionProjections()
        {
            CreateMap<Position, PositionOutput>()
                .ForMember(x => x.Levels, opt => opt.MapFrom(x => x.Levels))
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Name));

            CreateMap<OrganizationPosition, OrganizationPositionOutput>()
                .IncludeMembers(x => x.Position)
                .ForMember(x => x.OrganizationId, opt => opt.MapFrom(x => x.OrganizationId));

            CreateMap<Position, OrganizationPositionOutput>();
        }
    }
}
