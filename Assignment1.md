## QNA

1. What is Asp.Net Core?
   Asp.net is a cross-platform, high performance and opensource framework developed by microsoft. It is used for building could enable web applications and services.

2. What are the features of Asp.Net Core?

- Open source : It is open source and anyone can contribute on github.
- Cross Platform: It can now be hosted on Windows, Linux and Mac.
- High Performance: It's build keeping performance in mind. Can be hosted on different servers.
- Cloud Enabled: It has out of the box support for cloud.

3. What are the advantages of ASP.NET Core over ASP.NET (.NET Framework)?

- We have to add dependency injection in ASP.NET Framework.
- Dependency injection is inbuild in ASP.NET Core.
- ASP.NET Core supports Cross Platform that is it can be hosted on Windows, Linux and Mac.
- ASP.NET Core has higher performance and can be hosted on servers like Apache, Kestrel, IIS, Nginx, Docker.
- ASP.NET is modern and supports Cloud platforms like Azure out of the box.

4. What is Asp.Net Core meta package?

- As we know that any ASP.NET Core application contains a package known as Microsoft.AspNetCore.
  This package does not contain any dll or code in itself but it includes all the dlls and packages required for ASP.NET Core application and together these dependencies are know as metapackage for ASP.NET Core application.
  This package delivers many of the crucial packages required for ASP.NET core applications.

5. When do you choose classic ASP.NET MVC over ASP.NET Core?

- Choosing between ASP.NET MVC over ASP.NET Core depends on multiple factors

1. If you have nearear release schedules you should prefer ASP.NET MVC over Core.
2. If you already have an application and extending its functionality you should use ASP.NET MVC over ASP.NET Core.
3. Need a stable enviornment use ASP.NET MVC.
4. If you are not afraid of breaking things and fixing things, you can use ASP.NET Core.
5. Want to target your web application to support Window, Linux and Mac you should use ASP.NET Core.
6. If you are not afraid of learing new things you can switch to ASP.NET Core.

- Already have an existing team with ASP.NET Framework expertise.

6. What is a web application framework, and what are its benefits?

- Web application framework came into picture to reduce hand-code and improve the overall performance of your web application, these frameworks helps in simplifying the overall developement process. Web application framework supports multiple databases, provide static and dynamic templates, manage system users, assist adminstrators to assing roles, add/modify and delete users, are quick to code and less prone to errors.

---------------------- Instructor Answers ----------------------------

1. What is Asp.Net Core?

ASP.NET Core is a free, open-source, and cross-platform framework for building cloud-based applications, such as web apps, IoT apps, and mobile backends. It is designed to run on the cloud as well as on-premises.

ASP.NET Core is not an upgraded version of ASP.NET. ASP.NET Core is completely rewriting that work with the .net Core framework. It is much faster, configurable, modular, scalable, extensible, and has cross-platform support. It is best suitable for developing cloud-based such as web applications, mobile applications, and IoT applications.

2. What are the features of Asp.Net Core?

Following are the core features that are provided by the ASP.NET Core

- Built-in supports for Dependency Injection
- Built-in supports for the logging framework and it can be extensible
- Introduced a new, fast and cross-platform web server - Kestrel. So, a web application can run without IIS, Apache, and Nginx.
- Multiple hosting platforms are supported
- It supports modularity, so the developer needs to include the module required by the application.
- Command-line supports to creating, building, and running of the application
- There is no web .config file. We can store the custom configuration into an appsettings.json file
- It has good support for asynchronous programming

3. What are the advantages of ASP.NET Core over ASP.NET (.NET Framework)?

There are the following advantages of ASP.NET Core over ASP.NET:

- It offers faster performance due to its minimalistic design
- It is cross-platform, so it can be run on Windows, Linux, and Mac.
- It is open-source

There is no dependency on framework installation because all the required dependencies are shipped with our application to the production server

Multiple deployment platforms available with ASP.NET Core

4. What is Asp.Net Core meta package?

The ASP.NET Core shared framework (Microsoft.AspNetCore.App) contains assemblies that are developed and supported by Microsoft. Microsoft.AspNetCore.App is installed when the .NET Core 3.0 or later SDK is installed. The shared framework is the set of assemblies (.dll files) that are installed on the machine and includes a runtime component and a targeting pack.

<Project Sdk="Microsoft.NET.Sdk.Web">
  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
  </PropertyGroup>
    ...
</Project>

5. When do you choose classic ASP.NET MVC over ASP.NET Core?

Though Asp.Net Core is a better choice in almost all the aspects, you don’t have to switch to ASP.NET Core if you are maintaining a legacy ASP.NET application that you are happy with and that is no longer actively developed.

- ASP.NET MVC is a better choice if you:
- Don’t need cross-platform support for your Web app.
- The existing team is already working on an existing app and extending its functionality.-
- The existing developers needs a learning curve to upgrade themselves to Asp.Net Core

6. What is a web application framework, and what are its benefits?

Learning to build a modern web application can be daunting. Most of the web applications have a standard set of functionality such as:

- Build a dynamic response that corresponds to an HTTP request.
- Allow users to log into the application and manage their data.
- Store the data in the database.
- Handle database connections and transactions.
- Route URLs to appropriate methods.
- Supporting sessions, cookies, and user authorization.
- Format output (e.g. HTML, JSON, XML)
- Improve security.

Frameworks help developers to write, maintain and scale applications. They provide tools and libraries that simplify the above recurring tasks, eliminating a lot of unnecessary complexity.
