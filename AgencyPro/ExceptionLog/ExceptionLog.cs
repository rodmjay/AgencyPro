using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Users.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.ExceptionLog
{
    public class ExceptionLog : BaseEntity<ExceptionLog>
    {
        public int Id { get; set; }
        public int HResult { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public string RequestUri { get; set; }
        public string Method { get; set; }
        public string StackTrace { get; set; }
        public Guid? UserId { get; set; }
        public DateTimeOffset Created { get; set; }
        public virtual User User { get; set; }
        public override void Configure(EntityTypeBuilder<ExceptionLog> builder)
        {
            throw new NotImplementedException();
        }
    }
}