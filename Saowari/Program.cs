using Microsoft.EntityFrameworkCore;
using Saowari.Data;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddOpenApi();
builder.Services.AddDbContext<SaowariDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("appCon")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
