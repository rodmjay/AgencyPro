using System;
using System.ComponentModel.DataAnnotations;

namespace AgencyPro.TimeEntries.Models
{
    public class TimeTrackingModel
    {
        public Guid ContractId { get; set; }
        public Guid? StoryId { get; set; }

        public bool? CompleteStory { get; set; }

        public DateTime StartDateTime { get; set; }

        [Range(0, 3600)] public int Duration { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
        public int TimeType { get; set; }

        public string Notes { get; set; }
    }
}