using App.Api.Dto;
using FluentValidation;
using Magicalizer.Validators.Abstractions;

namespace App.Dto.Validators
{
  public class IngredientValidator : AbstractValidator<Category>
  {
    public IngredientValidator()
    {
      this.RuleFor(c => c.Name).NotEmpty().MaximumLength(64);
      this.RuleSet(RuleSetName.Edit, () => {
        this.RuleFor(c => c.Id).NotEmpty();
      });
    }
  }
}
