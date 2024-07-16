using Data;
using Models.EnityFramework;

namespace GqlApi.Types;

public class DbQuery
{    
    // Use order by with this middleware (MS SQL)
    [UsePaging]
    // Will include for example Brands (EF Include method)
    [UseProjection]
    public IQueryable<Product> GetProducts(CatalogContext context)
        => context.Products.OrderBy(p => p.Id);

    // We can not use projection here because we are returning a single object
    // Etc. we must use IQueryable
    [UseFirstOrDefault] // Returns a single object
    [UseProjection]
    public async Task<IQueryable<Product?>> GetProductById(CatalogContext context, int id)
        => await Task.FromResult(context.Products.Where(p => p.Id == id));

    [UsePaging(DefaultPageSize = 1, MaxPageSize = 10)]
    [UseProjection]
    [UseFiltering]
    public IQueryable<Brand> GetBrands(CatalogContext context)
        => context.Brands.OrderBy(p => p.Id);
}
