var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.MapGet("/", () => "Dang");

app.Run();