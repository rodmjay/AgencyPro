using AgencyPro.Common.Enums;

namespace AgencyPro.Candidates.Events
{
    public class CandidateCreatedEvent : CandidateEvent
    {
        // agency owner
        public CandidateCreatedEvent()
        {
            this.Action = ModelAction.Create;
        }
    }
}