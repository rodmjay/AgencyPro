using AgencyPro.Roles.Entities;
using AgencyPro.Roles.ViewModels.Recruiters;
using AutoMapper;

namespace AgencyPro.Roles.Projections
{
    public class RecruiterProjections : Profile
    {
        public RecruiterProjections()
        {
            CreateMap<Recruiter, RecruiterOutput>()
                .IncludeAllDerived();

            CreateMap<Recruiter, RecruiterDetailsOutput>();
        }
    }
}