using AgencyPro.Common.Enums;

namespace AgencyPro.Candidates.Events
{
    public class CandidateQualifiedEvent : CandidateEvent
    {
        public CandidateQualifiedEvent()
        {
            // recruiter 
            // project manager
            Action = ModelAction.Qualify;
        }
    }
}