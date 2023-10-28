using System.Collections.Generic;

namespace AgencyPro.Common.EventHandling
{
    public class AggregateEventBus : List<IEventBus>, IEventBus
    {
        public void RaiseEvent(IEvent evt)
        {
            foreach (var eb in this) eb.RaiseEvent(evt);
        }
    }
}