// Copyright © 2024 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Magicalizer.Filters.Abstractions;

namespace App.Filters;

public class ProductFilter : IFilter
{
  public IntegerFilter? Id { get; set; }
  public CategoryFilter? Category { get; set; }
  public StringFilter? Name { get; set; }
  public DecimalFilter? Price { get; set; }
  public DateTimeFilter? Created { get; set; }
  public EnumerableFilter<PhotoFilter>? Photos { get; set; }

  public ProductFilter() { }

  public ProductFilter(IntegerFilter? id = null, CategoryFilter? category = null, StringFilter? name = null, DecimalFilter? price = null, DateTimeFilter? created = null, EnumerableFilter<PhotoFilter>? photos = null)
  {
    this.Id = id;
    this.Category = category;
    this.Name = name;
    this.Price = price;
    this.Created = created;
    this.Photos = photos;
  }
}