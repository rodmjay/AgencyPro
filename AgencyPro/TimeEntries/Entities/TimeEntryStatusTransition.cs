using System;
using AgencyPro.Common.Data.Enums;
using AgencyPro.Common.Data.Interfaces;
using AgencyPro.TimeEntries.Enums;

namespace AgencyPro.TimeEntries.Entities
{
    public class TimeEntryStatusTransition : IObjectState
    {
        public int Id { get; set; }
        
        public Guid TimeEntryId { get; set; }

        public TimeStatus Status { get; set; }
        public DateTimeOffset Created { get; set; }
        public ObjectState ObjectState { get; set; }
    }
}