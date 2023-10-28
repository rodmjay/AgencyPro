using System;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Users.Entities;
using Microsoft.EntityFrameworkCore;
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
            builder
                .Property(e => e.Id).ValueGeneratedOnAdd();

            builder
                .Property(s => s.Created)
                .HasDefaultValueSql("SYSDATETIMEOFFSET()");

            builder
                .Property(p => p.Message)
                .IsRequired()
                .HasMaxLength(800);

            builder
                .Property(p => p.Source)
                .HasMaxLength(400);

            builder
                .Property(p => p.RequestUri)
                .HasMaxLength(200);

            builder
                .Property(p => p.Method)
                .HasMaxLength(20);
        }
    }
}