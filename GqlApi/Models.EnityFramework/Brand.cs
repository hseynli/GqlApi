using GqlApi.Types;
using System.ComponentModel.DataAnnotations;

namespace Models.EnityFramework;

public sealed class Brand
{
    public int Id { get; set; }

    [Required]
    // This will be converted to uppercase (used our custom middleware)
    [UseToUpper]
    public string Name { get; set; } = default!;

    public ICollection<Product> Products { get; } = new List<Product>();
}
