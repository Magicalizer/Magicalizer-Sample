// Copyright © 2024 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Magicalizer.Domain.Models.Abstractions;

namespace App.Domain.Models;

public class Product : IModel<Data.Entities.Product, Filters.ProductFilter>
{
  public int Id { get; set; }
  public Category? Category { get; set; }
  public string? Name { get; set; }
  public decimal Price { get; set; }
  public DateTime Created { get; set; }
  public IEnumerable<Photo>? Photos { get; set; }

  public Product() { }

  public Product(Data.Entities.Product _product)
  {
    this.Id = _product.Id;
    this.Category = _product.Category == null ? new Category { Id = _product.CategoryId } : new Category(_product.Category);
    this.Name = _product.Name;
    this.Price = _product.Price;
    this.Created = _product.Created;
    this.Photos = _product.Photos?.Select(p => new Photo(p));
  }

  public Data.Entities.Product ToEntity()
  {
    return new Data.Entities.Product()
    {
      Id = this.Id,
      CategoryId = this.Category == null ? 0 : this.Category.Id,
      Name = this.Name,
      Price = this.Price,
      Created = this.Created == DateTime.MinValue ? DateTime.Now : this.Created
    };
  }
}