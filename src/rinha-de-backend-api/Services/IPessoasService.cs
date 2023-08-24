using rinha_de_backend_api.Models;
using System.Linq.Expressions;

namespace rinha_de_backend_api;

interface IPessoasService
{
    Task<Pessoa> GetAsync(Expression<Func<Pessoa, Pessoa>> filter);
    Task<Pessoa> AddAsync(Pessoa pessoa);
    Task<IEnumerable<Pessoa>> ListAsync(Expression<Func<Pessoa, Pessoa>> filter);
}