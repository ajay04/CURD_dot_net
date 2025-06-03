# CURD_net

This is a simple ASP.NET Core CRUD (Create, Read, Update, Delete) application using Entity Framework Core with SQLite.

## Features
- List, create, edit, and delete items
- Uses SQLite as the database
- Entity Framework Core for data access
- Razor Pages for the UI

## Getting Started

### Prerequisites
- .NET 9 SDK (already included in this dev container)
- Node.js and npm (for front-end assets, already included)

### Setup
1. Restore dependencies:
   ```bash
   dotnet restore
   ```
2. Apply database migrations:
   ```bash
   dotnet ef database update
   ```
3. Run the application:
   ```bash
   dotnet run
   ```

The app will be available at `https://localhost:5001` or `http://localhost:5000` by default.

## Project Structure
- `Controllers/` - MVC controllers
- `Models/` - Entity and DbContext classes
- `Views/` - Razor views
- `Migrations/` - Entity Framework Core migrations
- `wwwroot/` - Static files (CSS, JS, etc.)

## Dev Container
This project is set up to run in a VS Code dev container with all necessary tools pre-installed.

## License
MIT
