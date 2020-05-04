using System.Collections.Generic;
using System.Linq;
using Magicalizer.Api.Dto.Abstractions;

namespace App.Api.Dto
{
  [Magicalized("v1/categories")]
  public class Category : IDto<Domain.Models.Category>
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<Product> Products { get; set; }

    public Category() { }

    public Category(Domain.Models.Category _category) : this(_category, ignoreProducts: false) { }

    public Category(Domain.Models.Category _category, bool ignoreProducts = false)
    {
      this.Id = _category.Id;
      this.Name = _category.Name;

      if (!ignoreProducts)
        this.Products = _category.Products?.Select(p => new Product(p, ignoreCategory: true));
    }

    public Domain.Models.Category ToModel()
    {
      return new Domain.Models.Category()
      {
        Id = this.Id,
        Name = this.Name,
        Products = this.Products?.Select(p => p.ToModel())
      };
    }
  }
}