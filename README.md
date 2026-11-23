# East Village Market

East Village Market is an ASP.NET MVC marketplace application for browsing products by category, viewing product details, and managing products through an administrator dashboard.

## Features

- Category-based product browsing
- Product details and search
- Administrator product and category management
- Role-based authorization for admin pages
- User registration and login with ASP.NET Identity
- External login support through OWIN
- Product image uploads
- Contact form with email delivery
- Responsive Bootstrap-based interface
- Custom branding, fonts, carousel, and visual effects
- Entity Framework migrations for database setup

## Technology Stack

- ASP.NET MVC 5
- .NET Framework 4.6.2
- Entity Framework 6
- ASP.NET Identity
- OWIN
- Microsoft SQL Server LocalDB
- Bootstrap
- jQuery
- Leaflet

## Getting Started

### Prerequisites

- Visual Studio with ASP.NET and web development tools
- .NET Framework 4.6.2 developer pack
- SQL Server Express LocalDB
- NuGet package restore enabled

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/Ryadba/East-Village.git
Open East Village.sln in Visual Studio.

Restore the NuGet packages.

Review the database connection string in:

Text
East Village/Web.config
The default configuration uses SQL Server LocalDB and a database named EVMDB.

Run the Entity Framework migrations from the Package Manager Console if required:

PowerShell
Update-Database
Set East Village as the startup project and run the application with IIS Express.

Project Structure
Text
East Village/
├── Controllers/       MVC controllers
├── Models/             Categories, products, and identity models
├── Views/              Razor views
├── Content/            CSS, fonts, images, and frontend assets
├── Scripts/            JavaScript libraries
├── Migrations/         Entity Framework database migrations
├── Uploads/            Product images
└── Web.config          Application and database configuration
Administration
Administrative actions require the Admins role. Admin users can manage:

Categories
Products
Product images
Application roles
Configuration and Security
Before deploying this application:

Move email credentials and other secrets out of source code.
Store secrets in environment variables or protected configuration.
Rotate any credentials that may have previously been committed.
Configure production database and SMTP settings.
Enable HTTPS in production.
Validate and restrict uploaded file types and sizes.
Status
This project is an older ASP.NET MVC application and may require Visual Studio and Windows-specific tooling to build and run.
