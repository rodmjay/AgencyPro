using System.Collections.Generic;

namespace AgencyPro.Common.EventHandling
{
    public interface IEventSource
    {
        IEnumerable<IEvent> GetEvents();
        void Clear();
    }
}