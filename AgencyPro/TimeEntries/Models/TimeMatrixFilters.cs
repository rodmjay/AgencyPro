using System;
using AgencyPro.Common.Models;
using AgencyPro.TimeEntries.Enums;

namespace AgencyPro.TimeEntries.Models
{
    public class TimeMatrixFilters : CommonFilters
    {
        public static readonly TimeMatrixFilters NoFilter = new TimeMatrixFilters();

        public TimeMatrixFilters()
        {
            ApprovalStatus = new TimeStatus[]{};
            TimeType = new int[]{};
        }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid? ContractorId { get; set; }
        public Guid? ProjectId { get; set; }
        public Guid? ContractId { get; set; }
        public Guid? ProjectManagerId { get; set; }
        public TimeStatus[] ApprovalStatus { get; set; }
        public int[] TimeType { get; set; }
        public Guid? AccountManagerId { get; set; }
        public Guid? ProviderOrganizationId { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? CustomerOrganizationId { get; set; }
        public Guid? RecruiterId { get; set; }
        public Guid? RecruiterOrganizationId { get; set; }
        public Guid? MarketerId { get; set; }
        public Guid? MarketerOrganizationId { get; set; }
        public Guid? StoryId { get; set; }
    }
}