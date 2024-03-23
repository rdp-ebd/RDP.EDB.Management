using Carter;
using Serilog;
using RDP.EDB.Management.WebApi.Extensions;
using RDP.EDB.Management.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using RDP.EDB.Management.Infra;

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
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"), sqlConf =>
    {
        sqlConf.MigrationsAssembly(typeof(InfraAssembly).Assembly.GetName().Name);
    });
});

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
