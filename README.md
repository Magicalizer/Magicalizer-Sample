# Magicalizer 5.0.0 Sample Web Application

![Magicalizer logotype](https://magicalizer.net/magicalizer_github_icon.png)

## Introduction

Magicalizer is a small, super simple, and lightweight library that allows you to create
a fully featured REST API ASP.NET Core web application with minimal routine code.

In most cases, all you need to write are DTO/model/entity classes, filters, and validators for them.
That’s it. Your web application will automatically support complex filtering
(including multiple nested object properties, ranges, etc.), complex sorting
(multiple nested object properties with different directions), pagination, complex inclusions
(nested object properties), flexible and powerful validation at both the DTO and model levels
(using FluentValidation), and policy-based authorization for GET, POST, PUT, PATCH,
and DELETE requests (yes, PATCH requests are supported too).

One important point: While Magicalizer handles the heavy lifting, you can still replace
any default implementation with your own when needed. Once you create
a custom service implementation for any model, it will automatically replace the default one.
The same applies to controllers. It doesn’t matter where you place your DTO/model/entity classes,
validators, services, or controllers—they will be discovered and resolved automatically.
This makes it incredibly easy to reuse code and create decoupled software.

## Quick Start

Run the web application and try the following requests (you can use a test database from this project).

```console
GET: /v1/categories
```

```console
GET: /v1/categories?name.contains=izza
```

```console
GET: /v1/categories?products.any.photos.any.filename.contains=.jpg&fields=products.photos
```

```console
GET: /v1/categories/1
```

```console
GET: /v1/categories/5?fields=products.photos
```

```console
GET: /v1/products
```

```console
GET: /v1/products?id.in=1&id.in=2
```

```console
GET: /v1/products?category.id=5&sorting=+name&offset=0&limit=5
```

```console
GET: /v1/products?category.id=5&sorting=-name&offset=0&limit=5
```

```console
GET: /v1/products?category.name.equals=Pizza&name.contains=ana&fields=category
```

```console
POST: /v1/categories
```

````json
{"name": "Sushi"}
````

```console
PUT: /v1/categories
```

````json
{"id": 1, "name": "Not sushi"}
````

```console
PATCH: /v1/categories/1
```

````json
[{"op": "replace", "path":"name", "value":"Sushi again o_O"}]
````

```console
DELETE: /v1/categories/1
```

## Links

Sources on GitHub: https://github.com/Magicalizer/Magicalizer

Author: http://sikorsky.pro/
