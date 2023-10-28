using System;
using System.Collections.Generic;
using AgencyPro.TimeEntries.Enums;

namespace AgencyPro.TimeEntries.Models
{
    public class ProjectManagerTimeEntryDetailsOutput : ProjectManagerTimeEntryOutput
    {
        public Dictionary<DateTimeOffset, TimeStatus> StatusTransitions { get; set; }
    }
}