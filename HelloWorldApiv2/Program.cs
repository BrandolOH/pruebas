using DotNetEnv;
using HelloWorldApiv2.BLL;
using HelloWorldApiv2.BLL.Interface;
using HelloWorldApiv2.BLL.Interfaces;
using HelloWorldApiv2.DAL;
using HelloWorldApiv2.DAL.Interface;
using HelloWorldApiv2.DAL.Interfaces;
using HelloWorldApiv2.DTO;
using HelloWorldApiv2.Models;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.ModelBuilder;

var builder = WebApplication.CreateBuilder(args);

Env.Load();

var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbPort = Environment.GetEnvironmentVariable("DB_PORT");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var dbUser = Environment.GetEnvironmentVariable("DB_USER");
var dbPass = Environment.GetEnvironmentVariable("DB_PASS");

var connectionString =
    $"Host={dbHost};Port={dbPort};Database={dbName};Username={dbUser};Password={dbPass}";



builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseNpgsql(connectionString));




// Add services
var modelBuilder = new ODataConventionModelBuilder();
modelBuilder.EntitySet<OrderWithUserNameDto>("Orders");

builder.Services.AddControllers()
    .AddOData(options =>
        options.Select()
               .Filter()
               .OrderBy()
               .Expand()
               .Count()
               .SetMaxTop(100)
               .AddRouteComponents("odata", modelBuilder.GetEdmModel())
    );

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();


var app = builder.Build();

// Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
