using System;
using System.Collections.Generic;
using AgencyPro.TimeEntries.Enums;

namespace AgencyPro.TimeEntries.Models
{
    public class RecruiterTimeEntryDetailsOutput : RecruiterTimeEntryOutput
    {
        public Dictionary<DateTimeOffset, TimeStatus> StatusTransitions { get; set; }
    }
}