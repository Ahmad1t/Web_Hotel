using Microsoft.Extensions.DependencyInjection.Extensions;
using AutoMapper;
using Web_Hotel.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddService();
builder.Services.AddRepository();
builder.Services.AddControllers();
builder.Services.AddAutoMapperConfig();
builder.Services.AddDb(builder.Configuration);
//builder.Services.AddControllerService();

// Add services to the container.

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