using AgencyPro.Common.Services.Interfaces;
using AgencyPro.Roles.Entities;
using AgencyPro.Roles.ViewModels.ProjectManagers;

namespace AgencyPro.Roles.Interfaces
{
    public interface IProjectManagerService : IService<ProjectManager>,
        IRoleService<ProjectManagerInput, ProjectManagerUpdateInput, ProjectManagerOutput, IProjectManager>
    {
    }
}