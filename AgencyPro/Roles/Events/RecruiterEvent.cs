using AgencyPro.Common.Events;
using AgencyPro.Roles.ViewModels.Recruiters;

namespace AgencyPro.Roles.Events
{
    public abstract class RecruiterEvent<T> : BaseEvent where T : RecruiterOutput
    {
        public T Recruiter { get; set; }
    }
}