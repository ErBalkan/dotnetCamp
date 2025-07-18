using Business;
using Core;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Servisleri register et
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


// Dependency Injection - Loose Coupling
builder.Services.AddScoped<IRepository<Product>, InMemoryProductRepository>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IRepository<Product>, EfProductRepository>();

// AUTOMAPPER
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// appSetting.json entgegrasyon
var connectionString = builder.Configuration.GetConnectionString("PostgreSql");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers(); // API endpointlerini aktif et.

app.Run();


