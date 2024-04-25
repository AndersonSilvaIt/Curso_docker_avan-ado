using Microsoft.EntityFrameworkCore;
using TesteDocker_Business.Interfaces;
using TesteDocker_Data;
using TesteDocker_Data.Repositorios;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(Program));
// Add services to the container.

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<Contexto>(options =>
{
    options.UseNpgsql(connection, builder => builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null)
    .CommandTimeout(10));
});

builder.Services.AddControllers();
builder.Services.AddScoped<IPessoaRepository, PessoaRepository>();

builder.Services.AddControllers();
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
