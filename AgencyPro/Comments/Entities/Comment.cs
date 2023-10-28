using System;
using AgencyPro.Candidates.Entities;
using AgencyPro.Comments.Interfaces;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Contracts.Entities;
using AgencyPro.CustomerAccounts.Entities;
using AgencyPro.Leads.Entities;
using AgencyPro.OrganizationPeople.Entities;
using AgencyPro.Projects.Entities;
using AgencyPro.Stories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Comments.Entities
{
    public class Comment : BaseEntity<Comment>, IComment
    {
        public Guid Id { get; set; }
        public string Body { get; set; }

        public bool Internal { get; set; }

        public Guid? StoryId { get; set; }
        public Story Story { get; set; }
        public Guid? ProjectId { get; set; }
        public Project Project { get; set; }
        public Guid? ContractId { get; set; }
        public Contract Contract { get; set; }

        public Guid? LeadId { get; set; }
        public Lead Lead { get; set; }

        public Guid? CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }


        public Guid? AccountManagerId { get; set; }
        public Guid? AccountManagerOrganizationId { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? CustomerOrganizationId { get; set; }

        public CustomerAccount CustomerAccount { get; set; }

        /// <summary>
        /// This is the organization of the person creating the comment
        /// </summary>
        public Guid OrganizationId { get; set; }

        public OrganizationPerson Creator { get; set; }

        public bool IsDeleted { get; set; }
        public DateTimeOffset Created { get; set; }

        public override void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Story).WithMany(x => x.Comments)
                .HasForeignKey(x => x.StoryId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Contract).WithMany(x => x.Comments)
                .HasForeignKey(x => x.ContractId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Project).WithMany(x => x.Comments)
                .HasForeignKey(x => x.ProjectId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Lead).WithMany(x => x.Comments)
                .HasForeignKey(x => x.LeadId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Candidate).WithMany(x => x.Comments)
                .HasForeignKey(x => x.CandidateId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.CustomerAccount).WithMany(x => x.Comments)
                .HasForeignKey(x => new
                {
                    x.CustomerOrganizationId,
                    x.CustomerId,
                    x.AccountManagerOrganizationId,
                    x.AccountManagerId
                }).IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(x => x.Creator).WithMany(x => x.Comments)
                .HasForeignKey(x => new
                {
                    x.OrganizationId,
                    x.CreatedById
                }).IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
