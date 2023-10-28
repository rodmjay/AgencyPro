using AgencyPro.Roles.Models;
using AgencyPro.Roles.ViewModels.Marketers;
using AutoMapper;

namespace AgencyPro.Roles.Projections
{
    public class MarketerProjections : Profile
    {
        public MarketerProjections()
        {
            CreateMap<Marketer, MarketerOutput>()
                .IncludeAllDerived();

            CreateMap<Marketer, MarketerDetailsOutput>();
        }
    }
}