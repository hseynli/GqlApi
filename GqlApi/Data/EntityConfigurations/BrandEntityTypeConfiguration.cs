using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.EnityFramework;

namespace Data.EntityConfigurations;

internal sealed  class BrandEntityTypeConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder
            .ToTable("Brands");

        builder
            .Property(cb => cb.Name)
            .HasMaxLength(100);
    }
}
