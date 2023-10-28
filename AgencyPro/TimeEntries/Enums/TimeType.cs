using System.ComponentModel;

namespace AgencyPro.TimeEntries.Enums
{
    public enum TimeType
    {
        [Description("Tasks")] Consulting = 1,
        [Description("Meetings")] Meetings = 2,
        [Description("Research")] Research = 3,
        [Description("Training")] Training = 4
    }
}