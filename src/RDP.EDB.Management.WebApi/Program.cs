using Carter;
using Serilog;
using RDP.EDB.Management.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCarter();
builder.Services.AddMediatr();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddFluentValidation();
builder.Services.AddExceptionHandlers();

builder.Host.UseSerilog();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();
app.MapCarter();
app.UseExceptionHandler();
app.UseHttpsRedirection();

app.Run();
