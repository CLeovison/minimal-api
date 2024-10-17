var builder = WebApplication.CreateBuilder(args);



var app = builder.Build();

app.MapGet("/", () => "Fucks!");

app.Run();