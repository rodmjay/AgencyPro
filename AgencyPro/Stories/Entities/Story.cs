using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using AgencyPro.Comments.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Notifications.Entities;
using AgencyPro.OrganizationRoles.Entities;
using AgencyPro.Projects.Entities;
using AgencyPro.Roles.Models;
using AgencyPro.Stories.Enums;
using AgencyPro.Stories.Interfaces;
using AgencyPro.StoryTemplates.Entities;
using AgencyPro.TimeEntries.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Stories.Entities
{
    public class Story : BaseEntity<Story>, IStory
    {
        public Project Project { get; set; }
        public OrganizationContractor OrganizationContractor { get; set; }

        public ICollection<TimeEntry> TimeEntries { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<StoryNotification> Notifications { get; set; }

        public Guid Id { get; set; }
        public string StoryId { get; set; }
        public Guid ProjectId { get; set; }
        public Guid? ContractorId { get; set; }
        public Contractor Contractor { get; set; }
        public Guid? ContractorOrganizationId { get; set; }
        public int? StoryPoints { get; set; }


        private ICollection<StoryStatusTransition> _statusTransitions;

        public virtual ICollection<StoryStatusTransition> StatusTransitions
        {
            get => _statusTransitions ??= new Collection<StoryStatusTransition>();
            set => _statusTransitions = value;
        }

        /// <summary>
        /// This gets set when the proposal is accepted
        /// </summary>
        public decimal? CustomerApprovedHours { get; set; }

        public DateTimeOffset? DueDate { get; set; }
        public StoryStatus Status { get; set; }
        public DateTimeOffset? AssignedDateTime { get; set; }
        public DateTimeOffset? ProjectManagerAcceptanceDate { get; set; }
        public DateTimeOffset? CustomerAcceptanceDate { get; set; }

        [MaxLength(500)] public string Title { get; set; }

        [MaxLength(5000)] public string Description { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public string ConcurrencyStamp { get; set; }

        public Guid? StoryTemplateId { get; set; }
        public StoryTemplate StoryTemplate { get; set; }
        public bool IsDeleted { get; set; }

        public decimal TotalHoursLogged { get; set; }
        public override void Configure(EntityTypeBuilder<Story> builder)
        {
            throw new NotImplementedException();
        }
    }
}