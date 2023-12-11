using Microsoft.EntityFrameworkCore;
using FleetManager.EntityFrameworkDAL.Repositories.Implementations;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.BLL.Managers.Interfaces;
using FleetManager.BLL.Managers.Implementations;
using FleetManager.BLL.Validators;
using FluentValidation;
using FleetManager.EntityFrameworkDAL.Context;
using Shared;
using FleetManager.BLL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddDbContext<FleetManagerContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection"))
);
builder.Services.AddScoped<IValidator<Driver>, DriverValidator>(); 
builder.Services.AddScoped<IDriverRepository, DriverRepository>();
builder.Services.AddScoped<IDriverManager, DriverManager>();
builder.Services.AddAutoMapper(typeof(Profiles).Assembly);
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AssemblyMarkerClass).Assembly));
//The AddMediatR extension method needs an assembly to scan so it can register all the handlers and mediator types. 

builder.Services.AddControllers(); 

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
