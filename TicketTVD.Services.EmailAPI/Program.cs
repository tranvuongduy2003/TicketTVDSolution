using TicketTVD.Services.EmailAPI.Data;
using TicketTVD.Services.EmailAPI.Extension;
using TicketTVD.Services.EmailAPI.Messaging;
using TicketTVD.Services.EmailAPI.Services;
using Microsoft.EntityFrameworkCore;
using TicketTVD.Services.EmailAPI.Models;
using TicketTVD.Services.EmailAPI.Services.IServices;

var EmailCors = "EmailCors";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors(p =>
    p.AddPolicy(EmailCors, build => { build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader(); }));

builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
optionBuilder.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
builder.Services.AddSingleton(new EmailService(optionBuilder.Options, builder.Configuration));

builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

builder.Services.AddTransient<ISendService, SendService>();

builder.Services.AddSingleton<IAzureServiceBusConsumer, AzureServiceBusConsumer>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    if (!app.Environment.IsDevelopment())
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Email API");
        c.RoutePrefix = string.Empty;
    }
});

app.UseHttpsRedirection();

app.UseCors(EmailCors);

app.UseAuthorization();

app.MapControllers();
ApplyMigration();
app.UseAzureServiceBusConsumer();
app.Run();


void ApplyMigration()
{
    using (var scope = app.Services.CreateScope())
    {
        var _db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        if (_db.Database.GetPendingMigrations().Count() > 0)
        {
            _db.Database.Migrate();
        }
    }
}