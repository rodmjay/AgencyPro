using AgencyPro.Roles.ViewModels.Recruiters;

namespace AgencyPro.Roles.Events
{
    public class RecruiterCreatedEvent<T> : RecruiterEvent<T> where T : RecruiterOutput
    {
    }
}