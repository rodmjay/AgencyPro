using AgencyPro.Common.Events;
using AgencyPro.Roles.ViewModels.Marketers;

namespace AgencyPro.Roles.Events
{
    public abstract class MarketerEvent<T> : BaseEvent where T : MarketerOutput
    {
        public T Marketer { get; set; }
    }
}