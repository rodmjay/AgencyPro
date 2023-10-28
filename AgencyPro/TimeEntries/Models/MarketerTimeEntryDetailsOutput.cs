using System;
using System.Collections.Generic;
using AgencyPro.TimeEntries.Enums;

namespace AgencyPro.TimeEntries.Models
{
    public class MarketerTimeEntryDetailsOutput : MarketerTimeEntryOutput
    {
        public Dictionary<DateTimeOffset, TimeStatus> StatusTransitions { get; set; }
    }
}