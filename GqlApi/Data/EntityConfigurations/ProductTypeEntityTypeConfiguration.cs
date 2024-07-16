using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.EnityFramework;

namespace Data.EntityConfigurations;

internal sealed class ProductTypeEntityTypeConfiguration : IEntityTypeConfiguration<ProductType>
{
    public void Configure(EntityTypeBuilder<ProductType> builder)
    {
        builder
            .ToTable("ProductTypes");

        builder
            .Property(cb => cb.Name)
            .HasMaxLength(100);
    }
}
