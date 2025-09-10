//Returns an instances of WebApplicationBuilder class
var builder = WebApplication.CreateBuilder(args);

//Returns an instance of web application
var app = builder.Build();


//Defines a route for HTTP GET requests to the root URL ("/") that responds with "Hello World! HTTP method + URL" 
app.MapGet("/", (HttpContext context) =>
    {
        var UserAgent = "";

        if (context.Request.Headers.ContainsKey("User-Agent"))
        {
            UserAgent = context.Request.Headers["User-Agent"];
        }

        context.Response.StatusCode = 200;
        return "User Agent: " + UserAgent;
    }
);


//Starts the web application and begins listening for incoming HTTP requests
app.Run();
