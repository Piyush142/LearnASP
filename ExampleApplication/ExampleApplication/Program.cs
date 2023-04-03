using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build(); // As a result of build method you will get an instance of
// web application which is refered by app.

// app.MapGet("/", () => "Hello World!"); // It is saying that whenever we have a request on port
// '/' The reponse should be Hello World.

app.Run(async (HttpContext context) => // Run function is used to handle request
{
    if(context.Request.Method == "GET") {
        if (context.Request.Query.ContainsKey("id")) {
            string id = context.Request.Query["id"];
            await context.Response.WriteAsync($"<p>{id}</p>");
        }
    }
    //context.Response.StatusCode = 400;
    //context.Response.Headers["MyKey"] = "Value";
    //await context.Response.WriteAsync("Hello");
    //await context.Response.WriteAsync(" World");
});

app.Run(); // Call the run method to start the server.

