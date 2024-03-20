//using EventSystemApi.Application.Service;
using EventSystemApi.Application.Services;
using EventSystemApi.Domain.Interfaces;
using EventSystemApi.Domain.Models;
using EventSystemApi.Infrastructure.Data;
using EventSystemApi.Infrastructure.Repositories;
//using EventSystemApi.Infrastructure.Repository;
using EventSystemApi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EventSystemDbContex>(options =>
   options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IRepository<Event>, EventRepository>();
builder.Services.AddScoped<IRepository<Company>, CompanyRepository>();
builder.Services.AddScoped<IRepository<PrivatePerson>, PrivatePersonRepository>();
builder.Services.AddScoped<EventService>();
builder.Services.AddScoped<CompanyService>();
builder.Services.AddScoped<PrivatePersonService>();

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
