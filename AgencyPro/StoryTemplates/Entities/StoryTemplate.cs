using System;
using System.Collections.Generic;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Organizations.Entities;
using AgencyPro.Stories.Entities;
using AgencyPro.StoryTemplates.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.StoryTemplates.Entities
{
    public class StoryTemplate : BaseEntity<StoryTemplate>, IStoryTemplate
    {
        public Guid ProviderOrganizationId { get; set; }
        public Organization ProviderOrganization { get; set; }

        public Guid Id { get; set; }
        public int? StoryPoints { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public decimal Hours { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Story> Stories { get; set; }

        public override void Configure(EntityTypeBuilder<StoryTemplate> builder)
        {
            throw new NotImplementedException();
        }
    }
}