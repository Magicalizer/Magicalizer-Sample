// Copyright © 2024 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Magicalizer.Domain.Models.Abstractions;

namespace App.Domain.Models;

public class Category : IModel<Data.Entities.Category, Filters.CategoryFilter>
{
  public int Id { get; set; }
  public string? Name { get; set; }
  public IEnumerable<Product>? Products { get; set; }

  public Category() { }

  public Category(Data.Entities.Category _category)
  {
    this.Id = _category.Id;
    this.Name = _category.Name;
    this.Products = _category.Products?.Select(p => new Product(p));
  }

  public Data.Entities.Category ToEntity()
  {
    return new Data.Entities.Category()
    {
      Id = this.Id,
      Name = this.Name
    };
  }
}