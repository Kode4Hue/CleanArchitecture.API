# Kode4Hue.CleanArchitecture.API

A .NET 6 MVC API template based on the principles of clean architecture. Feel free to grab it and use it on your next .NET API project.

### Prerequisites:
* Install the [.NET 6 SDK] (https://dotnet.microsoft.com/download/dotnet/6.0)
* Install Visual Studio

### Getting Started:
* Open a Terminal Window and set the current directory to the root directory of this template.
* Run `dotnet new --install Kode4Hue.CleanArchitecture.API` to install the API template
* Confirm the template is installed by running the `dotnet new --list` command to view all installed templates
* Once the template is installed, you then can use the template either from Visual Studio or using the dotnet cli by running: `dotnet new Kode4Hue.CleanArchitecture.API -o YourProjectName`

### Clean Architecture Layers:
* Presentation - CleanArchitecture.API.Presentation
* Infrastructure - CleanArchitecture.Infrastructure
* Application - CleanArchitecture.Application
* Domain - CleanArchitecture.Domain

### Core Technology Stack:
* [ASP.NET Core 6](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-6.0)
* [Kode4Hue.CleanArchitecture.SharedLibrary](https://github.com/Kode4Hue/CleanArchitecture.SharedLibrary)
* [Kode4Hue.JamaicaOpenData.SharedLibrary](https://github.com/Kode4Hue/JamaicaOpenData.SharedLibrary)
* [MediatR](https://github.com/jbogard/MediatR)
* [FluentValidation](https://fluentvalidation.net/)
* [AutoMapper](https://automapper.org/)
* [Newtonsoft.Json](https://www.newtonsoft.com/json)

### Third-Party Integrations:
* [Jamaica Open Data](https://data.gov.jm/search/type/dataset)

