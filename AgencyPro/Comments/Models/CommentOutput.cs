using System;
using AgencyPro.Comments.Interfaces;

namespace AgencyPro.Comments.Models
{
    public class CommentOutput : CommentInput, IComment
    {
        public Guid PersonId { get; set; }
        public Guid OrganizationId { get; set; }
        public string PersonName { get; set; }
        public string PersonImageUrl { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationImageUrl { get; set; }

        public DateTimeOffset Created { get; set; }

        public override bool Internal { get; set; }
    }
}
