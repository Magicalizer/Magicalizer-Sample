// Copyright © 2024 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Magicalizer.Api.Dto.Abstractions;

namespace App.Api.Dto;

[Magicalized("v1/products")]
public class Product : IDto<Domain.Models.Product>
{
  public int Id { get; set; }
  public Category? Category { get; set; }
  public string? Name { get; set; }
  public decimal Price { get; set; }
  public DateTime Created { get; set; }
  public IEnumerable<Photo>? Photos { get; set; }

  public Product() { }

  public Product(Domain.Models.Product _product) : this(_product, ignoreCategory: false, ignorePhotos: false) { }

  public Product(Domain.Models.Product _product, bool ignoreCategory = false, bool ignorePhotos = false)
  {
    this.Id = _product.Id;

    if (!ignoreCategory)
      this.Category = _product.Category == null ? null : new Category(_product.Category, ignoreProducts: true);

    this.Name = _product.Name;
    this.Price = _product.Price;
    this.Created = _product.Created;

    if (!ignorePhotos)
      this.Photos = _product.Photos?.Select(p => new Photo(p, ignoreProduct: true));
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