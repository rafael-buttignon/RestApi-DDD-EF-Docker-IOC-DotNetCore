using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using System.Collections.Generic;

namespace RestApiModeloDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IApplicationServiceCliente _applicationServiceCliente;

        public ClientesController(IApplicationServiceCliente applicationServiceCliente)
        {
            _applicationServiceCliente = applicationServiceCliente;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceCliente.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceCliente.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClienteDto clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _applicationServiceCliente.Add(clienteDTO);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Update(clienteDto);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Remove(clienteDto);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}