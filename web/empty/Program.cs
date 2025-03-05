var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Console.Title = "Empty";

app.MapGet("/", () => "Hello World!");

app.Run();
