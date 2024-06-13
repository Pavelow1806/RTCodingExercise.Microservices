using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.API.Data.Configurations
{
    public class PlateConfiguration : IEntityTypeConfiguration<Plate>
    {
        public void Configure(EntityTypeBuilder<Plate> builder)
        {
            builder.HasKey(plate => plate.Id);
            builder.Ignore(plate => plate.MarkupPrice);
        }
    }
}
