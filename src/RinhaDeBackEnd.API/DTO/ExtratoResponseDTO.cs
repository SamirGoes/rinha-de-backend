namespace RinhaDeBackEnd.API.DTO;
using RinhaDeBackEnd.API.Models;

public record ExtratoResponseDTO(decimal total, DateTime data, decimal limite, IEnumerable<Transacao> transacoes);