using System.Linq.Expressions;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using rinha_de_backend_api.Models;

namespace rinha_de_backend_api.Controllers;

public class PessoasService : IPessoasService
{
    private readonly IMongoCollection<Pessoa> _pessoasCollection;

    public PessoasService(IOptions<CadastroDatabaseSettings> cadastroDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            cadastroDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            cadastroDatabaseSettings.Value.DatabaseName);

        _pessoasCollection = mongoDatabase.GetCollection<Pessoa>(
            cadastroDatabaseSettings.Value.PessoasCollectionName);
    }

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