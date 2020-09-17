using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repository;

        public ServiceProduto(IRepositoryProduto repository)
            : base(repository)
        {
            this.repository = repository;
        }
    }
}