﻿// Copyright © 2024 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Magicalizer.Data.Entities.Abstractions;

namespace App.Data.Entities;

public class Category : IEntity<int>
{
  public int Id { get; set; }
  public string? Name { get; set; }

  public virtual ICollection<Product>? Products { get; set; }
}