using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace rinha_de_backend_api.Models
{
    public class Pessoa
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string[]? Stack { get; set; }
    }
}
//public record Pessoa(string? Id, string Apelido, string Nome, DateOnly Nascimento, string[] stack);