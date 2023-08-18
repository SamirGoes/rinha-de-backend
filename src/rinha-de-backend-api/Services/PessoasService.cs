using System.Linq.Expressions;
using MongoDB.Driver;

namespace rinha_de_backend_api.Controllers;

public class PessoasService : IPessoasService
{
    private readonly IMongoCollection<Pessoa> _pessoasCollection;

    public Task<Pessoa> AddAsync(Pessoa pessoa)
    {
        throw new NotImplementedException();
    }

    public Task<Pessoa> GetAsync(Expression<Func<Pessoa, Pessoa>> filter)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Pessoa>> ListAsync(Expression<Func<Pessoa, Pessoa>> filter)
    {
        throw new NotImplementedException();
    }
}