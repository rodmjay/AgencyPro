using AgencyPro.Common.Enums;

namespace AgencyPro.Common.Events
{
    public class UserProfileDeletedEvent : UserProfileEvent
    {
        public UserProfileDeletedEvent()
        {
            Action = ModelAction.Delete;
        }
    }
}