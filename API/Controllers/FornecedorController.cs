using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/fornecedor")]
    public class FornecedorController : ControllerBase
    {
        private readonly DataContext _context;
        public FornecedorController(DataContext context)
        {
            _context = context;
        }

        //POST: api/fornecedor/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Fornecedor fornecedor)
        {
            Fornecedor fornecedorEncontrado = _context.Fornecedores.FirstOrDefault(f => f.NomeFornecedor == fornecedor.NomeFornecedor);

            if(fornecedorEncontrado == null)
            {
            _context.Fornecedores.Add(fornecedor);
            _context.SaveChanges();
            return Created("", fornecedor);
            }
            return NotFound();
        }

        //GET: api/fornecedor/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Fornecedores.ToList());

        //GET: api/fornecedor/getbyid/id
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Fornecedor fornecedor = _context.Fornecedores.Find(id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return Ok(fornecedor);
        }

        //DELETE: /api/fornecedor/delete/nome
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult Delete([FromRoute] string name)
        {
            //Expressão lambda
            //Buscar um objeto na tabela de produtos com base no nome
            Fornecedor fornecedor = _context.Fornecedores.FirstOrDefault(fornecedor => fornecedor.NomeFornecedor == name);

            if (fornecedor == null)
            {
                return NotFound();
            }
            _context.Fornecedores.Remove(fornecedor);
            _context.SaveChanges();
            return Ok(_context.Fornecedores.ToList());
        }

        //PUT: api/fornecedor/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] Fornecedor fornecedor)
        {
            _context.Fornecedores.Update(fornecedor);
            
            _context.SaveChanges();
            return Ok(fornecedor);
        }
    }
}