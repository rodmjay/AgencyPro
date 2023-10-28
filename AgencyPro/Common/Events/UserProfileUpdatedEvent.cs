using AgencyPro.Common.Enums;

namespace AgencyPro.Common.Events
{
    public class UserProfileUpdatedEvent : UserProfileEvent
    {
        public UserProfileUpdatedEvent()
        {
            Action = ModelAction.Update;
        }
    }
}