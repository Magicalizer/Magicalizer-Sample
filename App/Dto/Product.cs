using System;
using Magicalizer.Api.Dto.Abstractions;

namespace App.Api.Dto
{
  [Magicalized("v1/products")]
  public class Product : IDto<Domain.Models.Product>
  {
    public int Id { get; set; }
    public Category Category { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public DateTime Created { get; set; }

    public Product() { }

    public Product(Domain.Models.Product _product) : this(_product, ignoreCategory: false) { }

    public Product(Domain.Models.Product _product, bool ignoreCategory = false)
    {
      this.Id = _product.Id;

      if (!ignoreCategory)
        this.Category = _product.Category == null ? null : new Category(_product.Category, ignoreProducts: true);

      this.Name = _product.Name;
      this.Price = _product.Price;
      this.Created = _product.Created;
    }

    public Domain.Models.Product ToModel()
    {
      return new Domain.Models.Product()
      {
        Id = this.Id,
        Category = this.Category?.ToModel(),
        Name = this.Name,
        Price = this.Price,
        Created = this.Created
      };
    }
  }
}