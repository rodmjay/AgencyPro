using AgencyPro.Roles.ViewModels.Marketers;

namespace AgencyPro.Roles.Events
{
    public class MarketerCreatedEvent<T> : MarketerEvent<T> where T : MarketerOutput
    {
    }
}