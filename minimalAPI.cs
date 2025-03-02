// In .NET 6/7 minimal API or in the Configure method for older versions:
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Allow maximum of 60 requests per minute per client IP
app.UseRateLimiting(60);

app.MapGet("/", () => "Hello World!");
app.Run();
