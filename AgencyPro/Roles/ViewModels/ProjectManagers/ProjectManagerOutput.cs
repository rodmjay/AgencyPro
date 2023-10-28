using System;
using AgencyPro.Roles.Interfaces;

namespace AgencyPro.Roles.ViewModels.ProjectManagers
{
    public class ProjectManagerOutput : ProjectManagerInput, IProjectManager
    {
        public Guid Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
    }
}