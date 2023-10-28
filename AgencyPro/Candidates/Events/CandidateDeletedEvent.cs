using AgencyPro.Common.Enums;

namespace AgencyPro.Candidates.Events
{
    public class CandidateDeletedEvent : CandidateEvent
    {
        
        public CandidateDeletedEvent()
        {
            Action = ModelAction.Delete;
        }
    }
}