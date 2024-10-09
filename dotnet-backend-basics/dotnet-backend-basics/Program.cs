using dotnet_backend_basics.Automappers;
using dotnet_backend_basics.DTOs;
using dotnet_backend_basics.Models;
using dotnet_backend_basics.Repository;
using dotnet_backend_basics.Services;
using dotnet_backend_basics.Validators;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IPeopleService, PeopleService>();
builder.Services.AddScoped<IPostsService, PostsService>();
builder.Services.AddKeyedScoped<ICommonService<BeerDto, BeerInsertDto, BeerUpdateDto>, BeerService>("beerService");

// HttpClient Posts
builder.Services.AddHttpClient<IPostsService, PostsService>(conf =>
{
    conf.BaseAddress = new Uri(builder.Configuration["BaseUrlPosts"]);
});


// Repository
builder.Services.AddScoped<IRepository<Beer>, BeerRepository>();

// Entity Framework
builder.Services.AddDbContext<StoreContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("StoreConnection"));
});

// Mappers
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Validators
builder.Services.AddScoped<IValidator<BeerInsertDto>, BeerInsertValidator>();
builder.Services.AddScoped<IValidator<BeerUpdateDto>, BeerUpdateValidator>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
