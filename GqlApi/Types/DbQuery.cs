using Data;
using HotChocolate.Data.Filters;
using HotChocolate.Data.Sorting;
using Models.EnityFramework;

namespace GqlApi.Types;

//[QueryType]
public class DbQuery
{    
    // Use order by with this middleware (MS SQL)
    [UsePaging]
    // Will include for example Brands (EF Include method)
    [UseProjection]
    public IQueryable<Product> GetProducts(CatalogContext context)
        => context.Products.OrderBy(p => p.Id);

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Product> GetOrderedProducts(CatalogContext context, IFilterContext filterContext, ISortingContext sortingContext)
    {
        filterContext.Handled(false);
        sortingContext.Handled(false);

        IQueryable<Product> query = context.Products;

        if (!filterContext.IsDefined)
            query = query.Where(p => p.Id == 1);

        if(!sortingContext.IsDefined)
            query = query.OrderByDescending(p => p.Id);

        return query;
    }

    // We can not use projection here because we are returning a single object
    // Etc. we must use IQueryable
    [UseFirstOrDefault] // Returns a single object
    [UseProjection]
    public async Task<IQueryable<Product?>> GetProductById(CatalogContext context, int id)
        => await Task.FromResult(context.Products.Where(p => p.Id == id));

    [UsePaging(DefaultPageSize = 1, MaxPageSize = 10)]
    [UseProjection]
    // Create filter for this query
    [UseFiltering]
    public IQueryable<Brand> GetBrands(CatalogContext context)
        => context.Brands.OrderBy(p => p.Id);
}
