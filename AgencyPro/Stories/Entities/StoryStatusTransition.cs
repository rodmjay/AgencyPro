using System;
using AgencyPro.Common.Data.Enums;
using AgencyPro.Common.Data.Interfaces;
using AgencyPro.Stories.Enums;

namespace AgencyPro.Stories.Entities
{
    public class StoryStatusTransition : IObjectState
    {
        public int Id { get; set; }
        public Guid StoryId { get; set; }
        public StoryStatus Status { get; set; }
        public DateTimeOffset Created { get; set; }
        public ObjectState ObjectState { get; set; }
    }
}