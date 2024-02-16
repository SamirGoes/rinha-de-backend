namespace RinhaDeBackEnd.API.Models;

public record Transacao(decimal valor, char tipo, string descricao, DateTime data);