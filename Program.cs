var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString();


var app = builder.Build();

app.MapGet("/", () => "Fucks!");
app.Run();