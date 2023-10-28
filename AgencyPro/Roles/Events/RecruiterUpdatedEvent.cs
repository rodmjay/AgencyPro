using AgencyPro.Roles.ViewModels.Recruiters;

namespace AgencyPro.Roles.Events
{
    public class RecruiterUpdatedEvent<T> : RecruiterEvent<T> where T : RecruiterOutput
    {
    }
}