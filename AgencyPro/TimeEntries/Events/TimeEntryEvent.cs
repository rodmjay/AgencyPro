using System;
using AgencyPro.Common.Events;

namespace AgencyPro.TimeEntries.Events
{
    public abstract class TimeEntryEvent : BaseEvent
    {
        public Guid TimeEntryId { get; set; }

    }
}