//Returns an instances of WebApplicationBuilder class
var builder = WebApplication.CreateBuilder(args);

//Returns an instance of web application
var app = builder.Build();


//Defines a route for HTTP GET requests to the root URL ("/") that responds with "Hello World! HTTP method + URL" 
app.MapGet("/", (HttpContext context) =>
    {
        context.Response.Headers["Content-Type"] = "text/html";
        context.Response.Headers["MyHeader"] = "Hello, World";
        return "<h2>This is a text response<h2>";
    }
);


//Starts the web application and begins listening for incoming HTTP requests
app.Run();
