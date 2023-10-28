using AgencyPro.Common.Events;
using AgencyPro.Roles.ViewModels.ProjectManagers;

namespace AgencyPro.Roles.Events
{
    public class ProjectManagerEvent : BaseEvent
    {
        public ProjectManagerOutput ProjectManager { get; set; }
    }
}