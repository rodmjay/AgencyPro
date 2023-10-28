using AgencyPro.Roles.Entities;
using AgencyPro.Roles.ViewModels.ProjectManagers;
using AutoMapper;

namespace AgencyPro.Roles.Projections
{
    public class ProjectManagerProjectionMap : Profile
    {
        public ProjectManagerProjectionMap()
        {
            CreateMap<ProjectManager, ProjectManagerOutput>()
                .IncludeAllDerived();

            CreateMap<ProjectManager, ProjectManagerDetailsOutput>();
            CreateMap<ProjectManager, AccountManagerProjectManagerOutput>();
            CreateMap<ProjectManager, AgencyOwnerProjectManagerOutput>();
        }
    }
}