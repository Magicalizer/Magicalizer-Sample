// Copyright © 2024 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Magicalizer.Api.Dto.Abstractions;

namespace App.Api.Dto;

[Magicalized("v1/photos")]
public class Photo : IDto<Domain.Models.Photo>
{
  public Product? Product { get; set; }
  public string? Filename { get; set; }

  public Photo() { }

  public Photo(Domain.Models.Photo _photo) : this(_photo, ignoreProduct: false) { }

  public Photo(Domain.Models.Photo _photo, bool ignoreProduct = false)
  {
    if (!ignoreProduct)
      this.Product = _photo.Product == null ? null : new Product(_photo.Product);

    this.Filename = _photo.Filename;
  }

  public Domain.Models.Photo ToModel()
  {
    return new Domain.Models.Photo()
    {
      Product = this.Product?.ToModel(),
      Filename = this.Filename
    };
  }
}