using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddScoped<IBackupRepository, BackupRepository>();
builder.Services.AddHostedService<CleanupService>();
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddDbContext<DB_Chimi>(option =>
{
    option.UseSqlServer(builder.Configuration["ConnectionStrings:MyConnection"]);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();



app.Run();

