using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RinhaDeBackEnd.API.Context;
using RinhaDeBackEnd.API.DTO;
using RinhaDeBackEnd.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/clientes/{id}/transacoes", async (int id, [FromBody] TransacaoRequestDTO body) =>
{
    if(id < 1 || id > 5) return Results.NotFound();

    return Results.Ok(new TransacaoResponseDTO(100m, -100.87m));
})
.WithName("GetTransactions");

app.MapGet("/clientes/{id}/extrato", async (int id) => {

    if(id < 1 || id > 5) return Results.NotFound();

    return Results.Ok(new ExtratoResponseDTO(100.0m, DateTime.Now, 100.50m, Enumerable.Empty<Transacao>()));
})
.WithName("GetExtract");

app.Run();