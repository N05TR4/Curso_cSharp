using BoletosBus.Infraestructure.Context;
using BoletosBus.Infraestructure.Exceptions;
using BoletosBus.IOC.Dependencies;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<BoletosBusDbContext>(options => 
                                                   options.UseSqlServer(builder.Configuration.GetConnectionString("BoletosBusConnection")));

builder.Services.AddAsientoDependency();
builder.Services.AddUsuarioDependecy();
builder.Services.AddBusDependency();


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
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseMiddleware<GlobalExceptionsMiddleware>();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
