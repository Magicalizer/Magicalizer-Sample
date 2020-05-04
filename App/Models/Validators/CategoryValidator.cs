﻿using FluentValidation;
using Magicalizer.Validators.Abstractions;

namespace App.Domain.Models.Validators
{
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
}
