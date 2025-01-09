using Microsoft.EntityFrameworkCore;
using ProductApi.Infrastructure.Data;
using ProductApi.Infrastructure.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructureService(builder.Configuration);
//builder.Services.AddDbContext<ProductDbContext>(
//            options => options.UseSqlServer("eCommerceConnection"));

var app = builder.Build();
app.UseInfrastructurePolicy();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
