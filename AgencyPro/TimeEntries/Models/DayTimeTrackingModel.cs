using System;

namespace AgencyPro.TimeEntries.Models
{
    public class DayTimeTrackingModel
    {
        public Guid ContractId { get; set; }
        public Guid? StoryId { get; set; }
        public int TimeType { get; set; }
        public DateTime StartDateTime { get; set; }

        public string Notes { get; set; }
        public bool? CompleteStory { get; set; }
    }
}