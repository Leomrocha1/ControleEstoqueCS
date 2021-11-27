using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/estoque")]
    public class EstoqueController : ControllerBase
    {
        private readonly DataContext _context;
        public EstoqueController(DataContext context)
        {
            _context = context;
        }

        //POST: api/estoque/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Estoque estoque)
        {
            Estoque estoqueEncontrado = _context.Estoques.FirstOrDefault(e => e.TipoEstoque == estoque.TipoEstoque);

            if(estoqueEncontrado == null)
            {
            _context.Estoques.Add(estoque);
            _context.SaveChanges();
            return Created("", estoque);
            }
            return NotFound();
        }

        //GET: api/estoque/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Estoques.ToList());

    }
}