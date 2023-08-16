using System.Runtime.CompilerServices;
using MongoDB.Driver;

namespace rinha_de_backend_api.Controllers;

public class PessoasService
(
    private readonly IMongoCollection<Pessoa> _pessoasCollection;
)