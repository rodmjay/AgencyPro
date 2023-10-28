using System;
using AgencyPro.Common.Models;

namespace AgencyPro.TimeEntries.Models
{
    public class TimeEntryResult : Result
    {
        public Guid? TimeEntryId { get; set; }
        public Guid[] TimeEntryIds { get; set; }
    }
}