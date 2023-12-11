using FleetManager.BLL;
using FluentValidation; 
using Microsoft.EntityFrameworkCore; 
using Shared;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DevConnection"); 
//SETUP 
//BUILDER
// Create the context 
builder.Services.SetupContext(connectionString, QueryTrackingBehavior.NoTracking);
// Add the repositories 
builder.Services.SetupRepositories(connectionString); 
// Add the validators 
builder.Services.AddValidatorsFromAssemblyContaining(typeof(AssemblyMarkerClass), ServiceLifetime.Scoped);

builder.Services.AddAutoMapper(typeof(Profiles).Assembly); 
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AssemblyMarkerClass).Assembly)); 

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(option => {
        option.Authority = "https://localhost:7203";
        option.Audience = "api";
        option.TokenValidationParameters.ValidTypes = new[] { "at+jwt" };
    });
    
//APP 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod()); //For Cross-Origin-Resource-Sharing 

app.UseHttpsRedirection();
app.UseAuthentication(); 

app.UseAuthorization();

app.MapControllers();

app.Run();
