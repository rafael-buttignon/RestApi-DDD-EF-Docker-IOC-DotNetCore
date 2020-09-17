using RestApiModeloDDD.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDto clitenDto);

        void Update(ClienteDto clienteDto);

        void Remove(ClienteDto clienteDto);

        IEnumerable<ClienteDto> GetAll();

        ClienteDto GetById(int id);
    }
}