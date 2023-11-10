using SilverScreenLexicon.Application;
using SilverScreenLexicon.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.UseInfrastructure();
app.Run();