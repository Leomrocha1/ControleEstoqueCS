using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly DataContext _context;
        public ProdutoController(DataContext context)
        {
            _context = context;
        }

        //POST: api/produto/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Produto produto)
        {
            Produto produtoEncontrado = _context.Produtos.FirstOrDefault(p => p.NomeProduto == produto.NomeProduto);
            if(produtoEncontrado == null)
            {
                produto.Estoque = _context.Estoques.Find(produto.Estoque.Id);
                produto.Fornecedor = _context.Fornecedores.Find(produto.Fornecedor.Id);
                if(produto.Estoque == null && produto.Fornecedor == null){
                    return NotFound();
                }else{
                _context.Produtos.Add(produto);
                _context.SaveChanges();
                return Created("", produto);
                }
            }else{
                    produto.Estoque = _context.Estoques.Find(produto.Estoque.Id);
                    produto.Fornecedor = _context.Fornecedores.Find(produto.Fornecedor.Id);
                    //produtoEncontrado.Quantidade = produtoEncontrado.Quantidade + produtoEncontrado.Quantidade
                    produtoEncontrado.Quantidade += produto.Quantidade;
                    Update(produtoEncontrado);
                    _context.SaveChanges();
                    return Ok(produtoEncontrado);
            }
        }

        //GET: api/produto/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Produtos.Include(p => p.Estoque).Include(p => p.Fornecedor).ToList());

        //GET: api/produto/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Produto produto = _context.Produtos.Find(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        //DELETE: /api/produto/delete/name
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult Delete([FromRoute] string name)
        {

            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.NomeProduto == name);

            if (produto == null)
            {
                return NotFound();
            }
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return Ok(_context.Produtos.ToList());
        }

        //DELETE: /api/produto/saida
        [HttpDelete]
        [Route("saida")]
        public IActionResult Saida([FromBody] Produto produto)
        {

            Produto produtoEncontrado = _context.Produtos.FirstOrDefault(produto => produto.NomeProduto == produto.NomeProduto);

            if (produtoEncontrado == null)
            {
                return NotFound();
            }else if(produtoEncontrado.Quantidade >= 1){
            produtoEncontrado.Quantidade -= produto.Quantidade;
            Update(produtoEncontrado);
            _context.SaveChanges();
            return Ok(produtoEncontrado);
            }else{
                return NotFound();
            }
        }




        //PUT: api/produto/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
            return Ok(produto);
        }



    }
}