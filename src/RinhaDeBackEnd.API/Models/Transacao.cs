namespace RinhaDeBackEnd.API.Models;

public record Transacao(int id, int usuario, decimal valor, char tipo, string descricao, DateTime data);