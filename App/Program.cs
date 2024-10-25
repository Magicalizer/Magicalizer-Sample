// Copyright © 2024 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using App;
using FluentValidation;
using Magicalizer.Extensions;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContext, AppDbContext>(options => {
  options.UseSqlite(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddMagicalizer();
//ValidatorOptions.Global.LanguageManager = new CustomLanguageManager();
//ValidatorOptions.Global.LanguageManager.Enabled = false;
ValidatorOptions.Global.PropertyNameResolver = (type, memberInfo, expression) =>
{
  if (memberInfo == null) return null;

  return memberInfo.Name.ToCamelCase();
};

WebApplication webApplication = builder.Build();

webApplication.UseMagicalizer();
webApplication.Run();