using api.Context;
using api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class CursoController : ControllerBase
{
    private readonly AgendaContext _context;

    public CursoController(AgendaContext context)
    {
        _context = context;
    }

    [HttpPost]
    public ActionResult Create (Curso curso)
    {
        _context.Add(curso);
        _context.SaveChanges();
        return Ok(curso);
    }

    [HttpGet("{id}")]

    public ActionResult ObterPorId(int id)
    {
        var curso = _context.Cursos.Find(id);

        if (curso == null)
        return NotFound();

        return Ok(curso);
    }

    [HttpGet("ObterPorNome")]
    public ActionResult ObterPorNome(string nome)
    {
        var cursos = _context.Cursos.Where(x => x.Nome.Contains(nome));
        return Ok(cursos);
    }

    [HttpPut("{id}")]
    public ActionResult Atualizar(int id, Curso curso)  
    {
        var cursoBanco = _context.Cursos.Find(id);
        if(cursoBanco == null) 
        return NotFound();

        cursoBanco.Nome = curso.Nome;
        cursoBanco.Descricao = curso.Descricao;

        _context.Cursos.Update(cursoBanco);
        _context.SaveChanges();

        return Ok(cursoBanco);
        
    }

    [HttpDelete("{id}")]
    public IActionResult Deletar(int id)
    {
        var cursoBanco = _context.Cursos.Find(id);

        if (cursoBanco == null)
        return NotFound();

        _context.Cursos.Remove(cursoBanco);
        _context.SaveChanges();

        return Ok(cursoBanco);

    }


   
}
