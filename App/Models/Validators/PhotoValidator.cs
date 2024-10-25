// Copyright © 2024 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using FluentValidation;

namespace App.Domain.Models.Validators;

public class PhotoValidator : AbstractValidator<Photo>
{
  public PhotoValidator()
  {
    this.RuleFor(p => p.Product).NotNull().DependentRules(() => {
      this.RuleFor(p => p.Product!.Id).GreaterThan(0);
    });

    this.RuleFor(p => p.Filename).NotEmpty().MaximumLength(64);
  }
}
