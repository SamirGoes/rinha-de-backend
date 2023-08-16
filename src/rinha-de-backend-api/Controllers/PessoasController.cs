using Microsoft.AspNetCore.Mvc;

namespace rinha_de_backend_api.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoasController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult> GetById([FromServices] PessoasService pessoasService, Guid id)
    {
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult> GetByTerm(string termo)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Pessoa pessoa)
    {
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult> Count()
        => Ok();
}