// Copyright © 2024 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using FluentValidation.Resources;

namespace App;

/// <summary>
/// Customizes validation error messages by overriding the default translations provided by FluentValidation.
/// This class adds custom English translations for common validation messages, ensuring consistency and clarity.
/// </summary>
public class CustomLanguageManager : LanguageManager
{
  /// <summary>
  /// Initializes a new instance of the <see cref="CustomLanguageManager"/> class with custom translations for validation messages.
  /// The translations replace the default error messages for various validators, such as "NotNullValidator" and "MaximumLengthValidator".
  /// </summary>
  public CustomLanguageManager()
  {
    this.AddTranslation("en", "NullValidator", "Value must be null.");
    this.AddTranslation("en", "NotNullValidator", "Value must not be null.");
    this.AddTranslation("en", "NotEmptyValidator", "Value must not be null or empty.");
    this.AddTranslation("en", "EqualValidator", "Value must be equal to {ComparisonValue}.");
    this.AddTranslation("en", "NotEqualValidator", "Value must not be equal to {ComparisonValue}.");
    this.AddTranslation("en", "EmptyValidator", "Value must be empty.");
    this.AddTranslation("en", "ExactLengthValidator", "Value must be exactly {MaxLength} characters long.");
    this.AddTranslation("en", "LengthValidator", "Value must be between {MinLength} and {MaxLength} characters long.");
    this.AddTranslation("en", "MinimumLengthValidator", "Value must be at least {MinLength} characters long.");
    this.AddTranslation("en", "MaximumLengthValidator", "Value must be no more than {MaxLength} characters long.");
    this.AddTranslation("en", "LessThanValidator", "Value must be less than {ComparisonValue}.");
    this.AddTranslation("en", "LessThanOrEqualValidator", "Value must be less than or equal to {ComparisonValue}.");
    this.AddTranslation("en", "GreaterThanValidator", "Value must be greater than {ComparisonValue}.");
    this.AddTranslation("en", "GreaterThanOrEqualValidator", "Value must be greater than or equal to {ComparisonValue}.");
    this.AddTranslation("en", "InclusiveBetweenValidator", "Value must be between {From} and {To} inclusively.");
    this.AddTranslation("en", "ExclusiveBetweenValidator", "Value must be between {From} and {To}.");
    this.AddTranslation("en", "ScalePrecisionValidator", "Value cannot have more than {ExpectedPrecision} digits in total, with {ExpectedScale} decimal places.");
    this.AddTranslation("en", "EnumValidator", "Value must be one of the defined options.");
    this.AddTranslation("en", "MatchesValidator", "Value does not match the required format.");
    this.AddTranslation("en", "RegularExpressionValidator", "Value does not match the required pattern.");
    this.AddTranslation("en", "PredicateValidator", "Value is invalid.");
    this.AddTranslation("en", "AsyncPredicateValidator", "Value is invalid.");
  }
}
