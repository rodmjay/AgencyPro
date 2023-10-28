using AgencyPro.Common.Enums;

namespace AgencyPro.Candidates.Events
{
    public class CandidatePromotedEvent : CandidateEvent
    {
        // recruiter
        // agency owner
        public CandidatePromotedEvent()
        {
            this.Action = ModelAction.Approve;
        }
    }
}