# Magicalizer 1.1.0 Sample Web Application

![Magicalizer logotype](https://magicalizer.net/magicalizer_github_icon.png)

## Introduction

Magicalizer allows you to get a fully featured REST API ASP.NET Core web application almost without writing any routine code.
In most of the cases all you need to write are DTO/model/entity classes and validators for them. That’s all.
Your web application will automatically support complex filtering (multiple nested objects properties, ranges etc.),
complex sorting (multiple nested objects properties, different directions), paging, complex inclusions (multiple nested objects properties too),
flexible and powerful validation on the DTO and model levels (using FluentValidation), policy-based authorization for GET, POST, PUT, PATCH,
and DELETE requests independently (and yes, you will have PATCH requests support too).

Important thing. While Magicalizer does all the work, you can still replace any default implementation with your own when needed.
Once you create and register a concrete service implementation for some of the models, it will be used instead of the default one automatically.
The same thing with the controllers and repositories. Moreover, Magicalizer is built on top of the [ExtCore framework](https://github.com/ExtCore/ExtCore),
so it is modular and extendable by default. It is not important where you put your DTO/model/entity classes, your validators, services,
or controllers. They will be found and resolved automatically (even from the DLLs at runtime). It makes it amazingly simple to reuse the code
and create decoupled software.

## Quick Start

Run the web application and try the following requests (you can use a test database from the sample project).

GET: /v1/categories

GET: /v1/categories?name.contains=izza

GET: /v1/categories/1

GET: /v1/categories/5?fields=products

GET: /v1/products

GET: /v1/products?category.id=5&sorting=+name&offset=0&limit=5

GET: /v1/products?category.id=5&sorting=-name&offset=0&limit=5

GET: /v1/products?category.name.equals=Pizza&name.contains=ana&fields=category

POST: /v1/categories

```
{"name": "Sushi"}
```

PUT: /v1/categories

```
{"id": 1, "name": "Not sushi"}
```

PATCH: /v1/categories/1

```
[{"op": "replace", "path":"name", "value":"Sushi again o_O"}]
```

DELETE: /v1/categories/1

## Links

Sources on GitHub: https://github.com/Magicalizer/Magicalizer

Author: http://sikorsky.pro/

Patreon: https://www.patreon.com/dmitry_sikorsky (you can support this project)
