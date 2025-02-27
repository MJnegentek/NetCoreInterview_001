using Microsoft.EntityFrameworkCore;
using TestNexsus.Business;
using TestNexsus.Data;
using TestNexsus.Data.Models;
using TestNexsus.Repository.Legacy;
using TestNexsus.Services.Legacy;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<TestContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("TestDbConnection"));
});

var mypolicy = "MyPolicy";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: mypolicy,
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            
        });
});

builder.Services.AddScoped<ITestBusiness_cls, TestBusiness_cls>();
builder.Services.AddScoped<ITestData_cls, TestData_cls>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(mypolicy);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
