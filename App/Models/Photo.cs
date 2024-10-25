// Copyright © 2024 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Magicalizer.Domain.Models.Abstractions;

namespace App.Domain.Models;

public class Photo : IModel<Data.Entities.Photo, Filters.PhotoFilter>
{
  public Product? Product { get; set; }
  public string? Filename { get; set; }
  public IEnumerable<Product>? Products { get; set; }

  public Photo() { }

  public Photo(Data.Entities.Photo _photo)
  {
    this.Product = _photo.Product == null ? new Product { Id = _photo.ProductId } : new Product(_photo.Product);
    this.Filename = _photo.Filename;
  }

  public Data.Entities.Photo ToEntity()
  {
    return new Data.Entities.Photo()
    {
      ProductId = this.Product?.Id ?? 0,
      Filename = this.Filename
    };
  }
}