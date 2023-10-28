using System;

namespace AgencyPro.Stories.Models
{
    public class ProposedStoryOutput
    {
        public virtual Guid Id { get; set; }
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        public virtual int? StoryPoints { get; set; }
    }
}