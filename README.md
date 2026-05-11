# WebDiaryAPI

A REST API built with ASP.NET Core for managing diary entries.

## Features

- CRUD endpoints for diary entries (GET, POST, PUT, DELETE)
- Entity Framework Core with Code First migrations
- Clean Controllers / Models / Data layer separation
- Configured via `appsettings.json` and dependency injection
- Swagger UI available in development

## Tech Stack

- ASP.NET Core Web API (.NET 9)
- Entity Framework Core
- SQL Server / LocalDB
- Swagger / Swashbuckle

## Getting Started

```bash
# 1. Apply database migrations
dotnet ef database update --project WebDiaryAPI

# 2. Run the application
dotnet run --project WebDiaryAPI
```

Port is assigned automatically — check the console output after dotnet run for the exact URL.
