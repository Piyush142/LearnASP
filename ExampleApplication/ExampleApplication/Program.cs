var builder = WebApplication.CreateBuilder(args);
var app = builder.Build(); // As a result of build method you will get an instance of
// web application which is refered by app.

app.MapGet("/", () => "Hello World!"); // It is saying that whenever we have a request on port
// '/' The reponse should be Hello World.

app.Run(); // Call the run method to start the server.

