# Bonus Challenges

## Challenge 2: Database Integration with Entity Framework Core

**Difficulty:** 🔥🔥 Advanced

!!! info
    Take this challenge further by replacing the static JSON data source with a real database.

In this challenge, you'll enhance the C# weather API by replacing the static JSON file with a SQL Server or SQLite database using Entity Framework Core (EF Core). This is a practical real-world scenario where you'll learn to work with data persistence, migrations, and async database operations.

### Learning Objectives

By completing this challenge, you will:

- Understand how to integrate Entity Framework Core into an ASP.NET Core Minimal API
- Create data models and DbContext for managing database operations
- Learn about database migrations and schema management
- Implement async/await patterns for database queries
- Use dependency injection for data repository patterns

#### Challenge Steps

**Step 1: Set up Entity Framework Core**

Use GitHub Copilot in Agent mode to:

1. Add Entity Framework Core NuGet packages to your C# project (e.g., `Microsoft.EntityFrameworkCore`, `Microsoft.EntityFrameworkCore.Sqlite` or `Microsoft.EntityFrameworkCore.SqlServer`)
2. Create appropriate data models (Country, Weather, City entities) based on the structure in `weather.json`
3. Create a `WeatherDbContext` class that inherits from `DbContext` and defines your database tables

!!! tip
    Ask Copilot to analyze the `weather.json` file and suggest appropriate entity models and relationships.

**Step 2: Configure Database & Create Migrations**

Use Agent mode to:

1. Configure the database connection in `Program.cs`
2. Create an initial database migration using `dotnet ef migrations add`
3. Update the database schema using `dotnet ef database update`

!!! important
    Monitor Copilot's actions as it modifies your `Program.cs` and creates migration files. Review the generated migration code to understand the schema changes being applied.

**Step 3: Seed Initial Data**

Use Agent mode to:

1. Create a data seeding mechanism that populates the database with the weather data from `weather.json`
2. Call the seeding logic during application startup

!!! note
    You can seed data from the existing JSON file to ensure your database contains the same information as the original static data source.

**Step 4: Update Endpoints to Use Database**

Use Agent mode to update your endpoints to:

1. Inject `WeatherDbContext` into your endpoint handlers
2. Replace JSON file reads with EF Core database queries
3. Use async/await patterns for all database operations
4. Ensure all endpoints return the same responses as before

!!! success
    After updating the endpoints, run your Python tests to ensure the API still works correctly with the database backend.

**Step 5: Validation & Testing**

Use the Python test suite to validate that:

1. The `/` endpoint returns 200
2. The `/countries` endpoint returns the correct list of countries
3. The weather endpoint returns correct data for valid countries
4. Invalid countries still return 404 responses

Run the tests as you did before:

```bash
cd src/python-app/webapp
pytest test_main.py -v
```

### Optional Enhancements

- Add filtering and pagination to the countries endpoint
- Implement a more sophisticated data model with relationships
- Create C# unit tests using xUnit with mocked DbContext
- Add query performance optimizations with indexing
