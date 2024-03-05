using encurtador_link.Models;
using encurtador_link.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace encurtador_link.Controllers;

[ApiController]
[Route("")]
public class EncurtadorController : ControllerBase
{
    private readonly IEncurtadorService _encurtadorService;

    public EncurtadorController(IEncurtadorService encurtadorService)
    {
        _encurtadorService = encurtadorService;
    }
    
    [HttpPost("encurtar")]
    public async Task<IActionResult> Encurtador(
        [FromServices] AppDbContext context,
        [FromBody] EncurtadorViewModel encurtador
            )
    {
        if (!ModelState.IsValid)
        {
            BadRequest();
        }
        
        
        var model = _encurtadorService.EncurtarLink(encurtador);
  
        try
        {
            await context.Encurtador.AddAsync(model);
            await context.SaveChangesAsync();
            var linkEncurtado = $"http://localhost:{HttpContext.Connection.LocalPort}/{model.Codigo}";
        
            return Ok(linkEncurtado);
        }
        catch
        {
            return BadRequest();
        }
    }
    
    [HttpGet("{codigo}")]
    public async Task<IActionResult> Redirecionar(
        [FromServices] AppDbContext context,
        [FromRoute] string codigo)
    {
        var conteudoEncurtador = await context
            .Encurtador
            .AsNoTracking()
            .FirstOrDefaultAsync(o => o.Codigo == codigo);

        return conteudoEncurtador == null 
            ? NotFound() 
            : Redirect(conteudoEncurtador.LinkOriginal);
    }
}
