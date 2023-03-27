**What is Kestrel and what are advantages of Kestrel in Asp.Net Core?**

Asp.Net Core application uses Kestrel by default.

Kestrel is an event-driven, I/O-based, open-source, cross-platform, and asynchronous server which hosts .NET applications. It is provided as a default server for .NET Core; therefore, it is compatible with all the platforms and their versions which .NET Core supports.

It is a listening server with a command-line interface.

It can be used to reverse proxy servers such as IIS, Nginx etc.

Features of Kestrel are:

- Lightweight and fast.
- Cross-platform and supports all versions of .NET Core.
- Supports HTTP & HTTPS.
- Easy configuration
- Multiple apps on the same port is not supported
- Windows authentication is not supported

**What is the difference between IIS and Kestrel? Why do we need two web servers?**

The main difference between IIS and Kestrel is that Kestrel is a cross-platform server. It runs on Windows, Linux, and Mac, whereas IIS only runs on Windows.

Another essential difference between the two is that Kestrel is fully open-source, whereas IIS is closed-source and developed and maintained only by Microsoft.

IIS is very old software and comes with a considerable legacy and bloat. With Kestrel, Microsoft started with high-performance in mind. They developed it from scratch, which allowed them to ignore the legacy/compatibility issues and focus on speed and efficiency.

However, Kestrel doesn’t provide all the rich functionality of a full-fledged web server such as IIS, Nginx, or Apache. Hence, we typically use it as an application server, with one of the above servers acting as a reverse proxy.

**What is the purpose of launchSettings.json in asp.net core?**

The launchSettings.json file is used to store the configuration information, which describes how to start the ASP.NET Core application, in Visual Studio.

It mainly contains the run time profiles to configure application urls’ and environment.

The file is used only during the development of the application using Visual Studio. It contains only those settings that required to run the application.

launchSettings.json is only used by Visual Studio.

You don't need launchSettings.json for publishing an app (on production server).

**What is generic host or HostBuilder in .NET Core?**

.NET generic host called ‘HostBuilder’ helps us to manage all the below tasks.

- Dependency Injection
- Service lifetime management
- Configuration
- Logging

The generic host was previously present as ‘Web Host’, in .NET Core for web applications. Later, the ‘Web Host’ was deprecated and a generic host was introduced to cater to the web, Windows, Linux, and console applications.

**What is the purpose of the .csproj file?**

The project file is one of the most important files in our application. It tells .NET how to build (compile) the project.

The csproj file stores list of package dependencies of the current project, target .net version and other compilation settings.

The .csproj file also contains all the information that .NET tooling needs to build the project. It includes the type of project you are building (console, web, desktop, etc.), the platform this project targets, and any dependencies on other projects or 3rd party libraries.

Here is an example of a .csproj file that lists the NuGet packages and their specific versions.

```
<Project Sdk="Microsoft.NET.Sdk.Web">
<PropertyGroup>
  <TargetFramework>net6.0</TargetFramework>
</PropertyGroup>

<ItemGroup>
  <PackageReference Include="PackageName" Version="1.0.0.0" />
</ItemGroup>
</Project>
```

**What is IIS?**

IIS stands for Internet Information Services. It is a powerful web server developed by Microsoft. IIS can also act as a load balancer to distribute incoming HTTP requests to different application servers to allow high reliability and scalability.

It can also act as a reverse proxy, i.e. accept a client’s request, forward it to an application server, and return the client’s response. A reverse proxy improves the security, reliability, and performance of your application.

A limitation of IIS is that it only runs on Windows. However, it is very configurable. You can configure it to suit your application’s specific needs.

**What is the “Startup” class in ASP.NET core prior to Asp.Net Core 6?**

The startup class is the entry point of the ASP.NET Core application. Every Asp.NET Core (Asp.Net Core 5 and earlier) application must have this class. It contains the necessary code to bootstrap the application. This class contains two methods Configure() and ConfigureServices().

- Configure(): The Configure() method is used to essential middleware(s) to the application request pipeline.
- ConfigureServices(): The ConfigureServices() method is used to add services to the IoC container.

In Asp.Net Core 6 (.NET 6), Microsoft unifies Startup.cs and Program.cs into a single Program.cs.

In asp.net core 6 (and up), we need to add all such as registering middleware to the application pipeline, adding services to the IoC container, configuring the ‘application configuration’, configuring the logger, authentication and adding DbContext in Program.cs file.

**What does WebApplication.CreateBuilder() do?**

This method does the following things.

- Configure the app to use Kestrel as web server.
- Specify to use the current project directory as root directory for the application.
- Setup the configuration sub-system to read setting from appsettings.json and appsettings.{env}.json to environment specific configuration.
- Set Local user secrets storage only for the development environment.
- Configure environment variables to allow for server-specific settings.
- Configure command line arguments (if any).
- Configure logging to read from the Logging section of the appsettings.json file and log to the Console and Debug window.
- Configure integration with IIS
- Configure the default service provider.
