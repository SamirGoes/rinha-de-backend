namespace RinhaDeBackEnd.API.DTO;

public record TransacaoRequestDTO(decimal valor, char tipo, string descricao);