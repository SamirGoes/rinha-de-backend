using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RinhaDeBackEnd.API.DTO;
using RinhaDeBackEnd.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.MapPost("/clientes/{id}/transacoes", (int id, [FromBody] TransacaoRequestDTO body) =>
{
    return new TransacaoResponseDTO(100m, -100.87m);
})
.WithName("GetTransactions");

app.MapGet("/clientes/{id}/extrato", (int id) => {
    return new ExtratoResponseDTO(100.0m, DateTime.Now, 100.50m, Enumerable.Empty<Transacao>());
})
.WithName("GetExtract");

app.Run();