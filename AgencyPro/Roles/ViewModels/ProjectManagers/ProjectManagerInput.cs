using System;

namespace AgencyPro.Roles.ViewModels.ProjectManagers
{
    public class ProjectManagerInput : ProjectManagerUpdateInput
    {
        public Guid PersonId { get; set; }
    }
}