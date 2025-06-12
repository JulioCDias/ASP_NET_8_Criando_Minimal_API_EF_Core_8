using Microsoft.EntityFrameworkCore;
using RangoAgil.API.DbContexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(
    op => op.UseSqlite(builder.Configuration["ConnectionStrings:RangoAgilDb"])
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
