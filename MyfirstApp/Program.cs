//Returns an instances of WebApplicationBuilder class
var builder = WebApplication.CreateBuilder(args);

//Returns an instance of web application
var app = builder.Build();


//Defines a route for HTTP GET requests to the root URL ("/") that responds with "Hello World! HTTP method + URL" 
//app.MapGet("/", (HttpContext context) =>
//    {
//        context.Response.Headers["Content-Type"] = "text/html";
//        context.Response.Headers["MyHeader"] = "Hello, World";
//        return "<h2>This is a text response<h2>";
//    }
//);

app.Run(async (HttpContext context) =>
{
    string path = context.Request.Path;

    if(path == "/" || path == "/Home")
    {
        context.Response.StatusCode = 200;
        await context.Response.WriteAsync("Your In Home Page");
    }else if (path == "/Contact")
    {
        context.Response.StatusCode = 200;
        await context.Response.WriteAsync("Your In Contact Page");
    }else
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsync("The [age your looking for is not found!");
    }
    
});


//Starts the web application and begins listening for incoming HTTP requests
app.Run();
