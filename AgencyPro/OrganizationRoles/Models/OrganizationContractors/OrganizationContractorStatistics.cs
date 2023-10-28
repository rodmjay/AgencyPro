using System.Collections.Generic;
using AgencyPro.TimeEntries.Enums;

namespace AgencyPro.OrganizationRoles.Models.OrganizationContractors
{
    public class OrganizationContractorStatistics : OrganizationContractorOutput
    {
        public virtual int TotalContracts { get; set; }
        public virtual int TotalStories { get; set; }

        public int MaxBillableHours { get; set; }
        public int MaxWeeklyHours { get; set; }

        public int AvailableHours => MaxWeeklyHours - MaxBillableHours;

        public Dictionary<TimeStatus, decimal> TimeEntryHours { get; set; }
        public Dictionary<TimeStatus, decimal> TimeEntryEarnings { get; set; }
    }
}