﻿// Copyright © 2024 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Magicalizer.Data.Entities.Abstractions;

namespace App.Data.Entities;

public class Photo : IEntity<int>
{
  public int Id { get; set; }
  public int ProductId { get; set; }
  public string? Filename { get; set; }

  public virtual Product? Product { get; set; }
}