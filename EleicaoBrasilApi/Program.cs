using Microsoft.EntityFrameworkCore;
using EleicaoBrasilApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbcontext>(
    opt => opt.UseInMemoryDatabase("EleicaoBrasilApiDb")
);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Removi AddOpenApi() porque não é padrão (a menos que você tenha pacote específico)

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    // app.MapOpenApi(); // só use se estiver usando pacote específico
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();