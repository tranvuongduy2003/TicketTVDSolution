using TicketTVD.GatewaySolution.Extensions;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var AppCors = "AppCors";

var builder = WebApplication.CreateBuilder(args);

builder.AddAppAuthetication();

builder.Services.AddCors(p =>
    p.AddPolicy(AppCors, build => { build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader(); }));


if (builder.Environment.EnvironmentName.ToString().ToLower().Equals("production"))
{
    builder.Configuration.AddJsonFile("ocelot.Production.json", optional: false, reloadOnChange: true);
}
else
{
    builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
}
builder.Services.AddOcelot(builder.Configuration);

var app = builder.Build();

app.UseCors(AppCors);

app.UseOcelot().GetAwaiter().GetResult();
app.Run();