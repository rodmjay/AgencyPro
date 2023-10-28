using AgencyPro.Categories.Entities;
using AgencyPro.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Positions.Entities
{
    public class CategoryPosition : BaseEntity<CategoryPosition>
    {
        public Category Category { get; set; }
        public Position Position { get; set; }

        public int CategoryId { get; set; }
        public int PositionId { get; set; }
        public override void Configure(EntityTypeBuilder<CategoryPosition> builder)
        {
            builder.HasKey(x => new
            {
                x.CategoryId,
                x.PositionId
            });

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Positions)
                .HasForeignKey(x => x.CategoryId)
                .IsRequired();

            builder.HasOne(x => x.Position)
                .WithMany(x => x.Categories)
                .HasForeignKey(x => x.PositionId)
                .IsRequired();
        }
    }
}