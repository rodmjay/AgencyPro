using AgencyPro.Common.Services.Interfaces;
using AgencyPro.Roles.Models;
using AgencyPro.Roles.ViewModels.ProjectManagers;

namespace AgencyPro.Roles.Interfaces
{
    public interface IProjectManagerService : IService<ProjectManager>,
        IRoleService<ProjectManagerInput, ProjectManagerUpdateInput, ProjectManagerOutput, IProjectManager>
    {
    }
}