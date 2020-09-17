using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.ProdutoDtos;
using System.Collections.Generic;

namespace RestApiModeloDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;

        public ProdutosController(IApplicationServiceProduto applicationServiceProduto)
        {
            _applicationServiceProduto = applicationServiceProduto;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceProduto.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceProduto.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicationServiceProduto.Add(produtoDto);
                return Ok("Produto Cadastrado com sucesso!");
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicationServiceProduto.Update(produtoDto);
                return Ok("Produto Atualizado com sucesso!");
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicationServiceProduto.Remove(produtoDto);
                return Ok("Produto Removido com sucesso!");
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}