using System;
using AgencyPro.Common.Events;

namespace AgencyPro.Candidates.Events
{
    public abstract class CandidateEvent : BaseEvent
    {
        public Guid CandidateId { get; set; }
    }
}