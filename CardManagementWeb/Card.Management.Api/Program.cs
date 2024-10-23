using Card.Management.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<CardManagementContext>(x =>
{
    x.UseSqlServer(@"Server=localhost,1430;Database=CardManagementWebApi;User Id=sa;Password=abhi@123;TrustServerCertificate=true");
});
builder.Services.AddScoped<CardManagementContext>();



builder.Services.AddMediatR(x => {
    x.RegisterServicesFromAssembly(Assembly.Load("Card.Management.Application"));

});
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
