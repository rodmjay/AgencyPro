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
            throw new NotImplementedException();
        }
    }
}
