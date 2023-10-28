using System;
using AgencyPro.Common.Events;

namespace AgencyPro.Projects.Events
{
    public class ProjectEvent : BaseEvent
    {
       public Guid ProjectId { get; set; }
    }
}