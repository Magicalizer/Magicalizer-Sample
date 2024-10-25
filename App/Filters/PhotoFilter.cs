// Copyright © 2024 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Magicalizer.Filters.Abstractions;

namespace App.Filters;

public class PhotoFilter : IFilter
{
  public ProductFilter? Product { get; set; }
  public StringFilter? Filename { get; set; }

  public PhotoFilter() { }

  public PhotoFilter(ProductFilter? product = null, StringFilter? filename = null)
  {
    this.Product = product;
    this.Filename = filename;
  }
}