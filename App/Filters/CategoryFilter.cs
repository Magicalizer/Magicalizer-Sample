﻿// Copyright © 2024 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Magicalizer.Filters.Abstractions;

namespace App.Filters;

public class CategoryFilter : IFilter
{
  public IntegerFilter? Id { get; set; }
  public StringFilter? Name { get; set; }
  public EnumerableFilter<ProductFilter>? Products { get; set; }

  public CategoryFilter() { }

  public CategoryFilter(IntegerFilter? id = null, StringFilter? name = null, EnumerableFilter<ProductFilter>? products = null)
  {
    this.Id = id;
    this.Name = name;
    this.Products = products;
  }
}