using System;
using System.Collections.Generic;
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

        //POST: api/estoque/entrada
        [HttpPost]
        [Route("entrada")]
        public IActionResult Create([FromBody] Estoque estoque)
        {
            
            _context.Estoques.Add(estoque);
            _context.SaveChanges();
            return Created("", estoque);
        }

    }
}