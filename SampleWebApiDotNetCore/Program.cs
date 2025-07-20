using Microsoft.EntityFrameworkCore;
using SampleWebApiDotNetCore.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FirstAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), options =>
    options.EnableRetryOnFailure(
                maxRetryCount: 5, // Maximum number of retry attempts
                maxRetryDelay: TimeSpan.FromSeconds(10), // Maximum delay between retries
                errorNumbersToAdd: null)),
optionsLifetime: ServiceLifetime.Transient);

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
