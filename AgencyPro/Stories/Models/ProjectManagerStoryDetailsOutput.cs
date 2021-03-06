﻿using System;
using System.Collections.Generic;
using AgencyPro.Comments.Models;
using AgencyPro.Stories.Enums;

namespace AgencyPro.Stories.Models
{
    public class ProjectManagerStoryDetailsOutput : ProjectManagerStoryOutput
    {
        public ICollection<CommentOutput> Comments { get; set; }
        public Dictionary<DateTimeOffset, StoryStatus> StatusTransitions { get; set; }
    }
}