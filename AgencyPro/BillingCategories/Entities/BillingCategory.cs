using System;
using System.Collections.Generic;
using AgencyPro.Common.Data.Bases;
using AgencyPro.TimeEntries.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.BillingCategories.Entities
{
    public class BillingCategory : BaseEntity<BillingCategory>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsStoryBucket { get; set; }
        public bool IsPrivate { get; set; }
        public Guid? OrganizationId { get; set; }

        public ICollection<ProjectBillingCategory> ProjectBillingCategories { get; set; }
        public ICollection<TimeEntry> TimeEntries { get; set; }
        public ICollection<CategoryBillingCategory> CategoryBillingCategories { get; set; }
        public ICollection<OrganizationBillingCategory> OrganizationBillingCategories { get; set; }
        public override void Configure(EntityTypeBuilder<BillingCategory> builder)
        {
            throw new NotImplementedException();
        }
    }
}