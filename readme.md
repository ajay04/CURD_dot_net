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
   dotnet restore CURD_net.sln
   ```
2. Apply database migrations (optional, handled automatically at runtime):
   ```bash
   dotnet ef database update
   ```
3. Publish a single-file, self-contained Linux executable (includes static files):
   ```bash
   dotnet publish -c Release -r linux-x64 --self-contained true /p:PublishSingleFile=true
   ```
   The output will be in `bin/Release/net9.0/linux-x64/publish/`.
4. Run the application from the publish directory:
   ```bash
   cd bin/Release/net9.0/linux-x64/publish/
   ./YourProjectName
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
