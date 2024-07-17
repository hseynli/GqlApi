using HotChocolate.Data.Sorting;
using Models.EnityFramework;

namespace GqlApi.Types.Sorting;

// Only this field will be available for sorting
public sealed class ProductSortInputType : SortInputType<Product>
{
    protected override void Configure(ISortInputTypeDescriptor<Product> descriptor)
    {
        descriptor.BindFieldsExplicitly();

        descriptor.Field(p => p.Name);
        descriptor.Field(p => p.Price);
        descriptor.Field(p => p.Brand).Type<BrandSortInputType>();
        descriptor.Field(p => p.Type).Type<ProductTypeSortInputType>();
    }
}

public sealed class BrandSortInputType : SortInputType<Brand>
{
    protected override void Configure(ISortInputTypeDescriptor<Brand> descriptor)
    {
        descriptor.BindFieldsExplicitly();

        descriptor.Field(p => p.Name);
    }
}

public sealed class ProductTypeSortInputType : SortInputType<ProductType>
{
    protected override void Configure(ISortInputTypeDescriptor<ProductType> descriptor)
    {
        descriptor.BindFieldsExplicitly();

        descriptor.Field(p => p.Name);
    }
}