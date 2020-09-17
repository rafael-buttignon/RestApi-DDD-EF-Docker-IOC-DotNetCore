using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repository;

        public ServiceCliente(IRepositoryCliente repository)
            : base(repository)
        {
            this.repository = repository;
        }
    }
}