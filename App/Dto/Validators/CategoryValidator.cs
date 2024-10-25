// Copyright © 2024 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using App.Api.Dto;
using FluentValidation;
using Magicalizer.Validators.Abstractions;

namespace App.Dto.Validators;

public class CategoryValidator : AbstractValidator<Category>
{
  public CategoryValidator()
  {
    this.RuleFor(c => c.Name).NotEmpty().MaximumLength(64);
    this.RuleSet(RuleSetName.Edit, () => {
      this.RuleFor(c => c.Id).NotEmpty();
    });
  }
}