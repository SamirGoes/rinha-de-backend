using Microsoft.AspNetCore.Mvc;

namespace rinha_de_backend_api.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoasController : ControllerBase
{
    [HttpGet("GetById")]
    public async Task<ActionResult> GetById([FromServices] PessoasService pessoasService, Guid id)
    {
        return Ok();
    }

    [HttpGet("GetByTerm")]
    public async Task<ActionResult> GetByTerm(string termo)
    {
        return Ok();
    }

    [HttpPost("Create")]
    public async Task<ActionResult> Create(Pessoa pessoa)
    {
        return Ok();
    }

    [HttpGet("Count")]
    public async Task<ActionResult> Count()
        => Ok();
}