# AspNetCRUDEFCore

A simple ASP.NET Core CRUD project using Entity Framework Core.

## Features
- Create, Read, Update, Delete (CRUD) operations for Employees.
- Entity Framework Core database migrations.
- SQL Server database connection (Azure-ready).

## Getting Started

1. Clone the repository.
2. Run database migrations:
   ```bash
   dotnet ef migrations add "Initial Migration"
   dotnet ef database update
    ```

## Technologies
ASP.NET Core
Entity Framework Core
SQL Server / Azure SQL

## Notes
Configure your database connection string in appsettings.json.

Enable retry logic for transient Azure errors.

## SQL
```sql
Selet * from Sys.Tables
```
## Source 
https://www.youtube.com/watch?v=6YIRKBsRWVI&ab_channel=SameerSaini
## Author
Mohammad Meftauddin