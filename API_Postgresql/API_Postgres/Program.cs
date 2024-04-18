using API_Postgres.Business.Interfaces.Repositorios;
using API_Postgres.Data.Contexto;
using API_Postgres.Data.Repositorios;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(Program));


string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<APIContext>(options =>
{
    options.UseNpgsql(connection, builder => builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null)
    .CommandTimeout(10));
});

builder.Services.AddControllers();
builder.Services.AddScoped<IPessoaRepository, PessoaRepository>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
