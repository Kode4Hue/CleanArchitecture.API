using CleanArchitecture.Application.Common.Extensions;
using CleanArchitecture.Infrastructure.Extensions;
using CleanArchitecture.SharedLibrary.Http.Filters;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplication();
builder.Services.AddInfrastructure();

builder.Services.AddControllers(options =>
    options.Filters.Add<ApiExceptionFilterAttribute>())
    .AddFluentValidation(x => x.AutomaticValidationEnabled = false);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Customise default API behaviour
builder.Services.Configure<ApiBehaviorOptions>(options =>
    options.SuppressModelStateInvalidFilter = true);

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
