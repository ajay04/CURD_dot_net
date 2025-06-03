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
4. Publish a single-file, self-contained Windows executable:
   ```bash
   dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true
   ```
   The output will be in `bin/Release/net9.0/win-x64/publish/`.
5. Run the application from the publish directory:
   - On Linux:
     ```bash
     cd bin/Release/net9.0/linux-x64/publish/
     ./YourProjectName
     ```
   - On Windows:
     ```cmd
     cd bin\Release\net9.0\win-x64\publish
     YourProjectName.exe
     ```
6. (Optional) Create a Windows installer (.exe) for easy distribution:
   - Use a tool like [Inno Setup](https://jrsoftware.org/isinfo.php), [NSIS](https://nsis.sourceforge.io/), or [WiX Toolset](https://wixtoolset.org/) on Windows.
   - Package all files from `bin/Release/net9.0/win-x64/publish/` into your installer.
   - The installer can create shortcuts and add your app to the Start menu.

   Example (Inno Setup):
   1. Download and install Inno Setup on your Windows machine.
   2. Use the Inno Setup Wizard to select your published folder and configure installer options.
   3. Build the installer to generate a single .exe setup file for distribution.

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
