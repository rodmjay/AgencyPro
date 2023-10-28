using System;

namespace AgencyPro.TimeEntries.Models
{
    public class TimeEntryInput
    {
        public virtual Guid ContractId { get; set; }

        public virtual DateTimeOffset StartDate { get; set; }

        public virtual int? MinutesDuration { get; set; }

        public virtual DateTimeOffset EndDate { get; set; }

        public virtual string Notes { get; set; }

        public virtual int TimeType { get; set; }
        public virtual Guid? StoryId { get; set; }
        public virtual bool? CompleteStory { get; set; }


    }
}