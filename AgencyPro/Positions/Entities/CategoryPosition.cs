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
            throw new System.NotImplementedException();
        }
    }
}