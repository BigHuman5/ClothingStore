using ClothingStore.BLL.Interfaces;
using ClothingStore.BLL.Services;
using ClothingStore.DAL.EF;
using ClothingStore.DAL.Interfaces;
using ClothingStore.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ClothingStoreDbContext>(options =>
    options.UseSqlServer(connectionString));



builder.Services
    .AddTransient<IUnitOfWork, EFUnitOfWork>()
    .AddTransient<IBrandsServices, BrandServices>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();



// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
