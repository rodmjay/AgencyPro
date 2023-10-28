using AgencyPro.Common.Enums;

namespace AgencyPro.Candidates.Events
{
    public class CandidateRejectedEvent : CandidateEvent
    {
        public CandidateRejectedEvent()
        {
            // recruiter or
            // agency owner
            Action = ModelAction.Reject;
        }
    }
}