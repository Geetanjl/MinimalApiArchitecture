﻿# Minimal API Vertical Slice Architecture

This project is an experiment trying to create a solution template with Minimal APIs and Carter.



## Technologies and patterns used

- API
  - Minimal API with .NET 6 and Carter
  - Vertical Slice Architecture
  - CQRS with MediatR
  - Validations with FluentValidation
  - AutoMapper
  - Entity Framework Core
  - Swagger

- Angular
  - HttpClient generated with NSwag Studio and OpenAPI definition
  - Simple CRUD and nothing more


## Getting started

The easiest way to get started is using Visual Studio 2022 or with `dotnet run` installing the .NET 6 SDK.

## Database Migrations

To create a new migration with `dotnet-ef` you first locate to API folder:
```bash
dotnet ef migrations add <MigrationName> -o Data/Migrations
```

And to update de database:
```bash
dotnet ef database update
```


## Under construction 🏗️🚧🏗️
