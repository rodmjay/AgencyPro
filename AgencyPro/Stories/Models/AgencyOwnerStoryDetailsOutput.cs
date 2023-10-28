using System;
using System.Collections.Generic;
using AgencyPro.Comments.Models;
using AgencyPro.Stories.Enums;
using AgencyPro.TimeEntries.Models;

namespace AgencyPro.Stories.Models
{
    public class AgencyOwnerStoryDetailsOutput : AgencyOwnerStoryOutput
    {
        public ICollection<ProviderAgencyOwnerTimeEntryOutput> TimeEntries { get; set; }
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, StoryStatus> StatusTransitions { get; set; }
    }
}