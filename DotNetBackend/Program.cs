using Npgsql;
using quiltekvisten.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<DatabaseService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();