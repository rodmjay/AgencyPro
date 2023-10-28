using System;

namespace AgencyPro.Stories.Models
{
    public class UpdateStoryInput
    {
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        public virtual int? StoryPoints { get; set; }

        public virtual DateTimeOffset? AssignedDateTime { get; set; }
        public virtual DateTimeOffset? ProjectManagerAcceptanceDate { get; set; }
        public virtual DateTimeOffset? CustomerAcceptanceDate { get; set; }
    }
}