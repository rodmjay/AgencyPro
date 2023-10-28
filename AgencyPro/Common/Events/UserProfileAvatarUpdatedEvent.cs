using AgencyPro.Common.Enums;

namespace AgencyPro.Common.Events
{
    public class UserProfileAvatarUpdatedEvent : UserProfileEvent
    {
        public UserProfileAvatarUpdatedEvent()
        {
            ModelType = ModelType.UserAvatar;
            Action = ModelAction.Update;
        }
    }
}