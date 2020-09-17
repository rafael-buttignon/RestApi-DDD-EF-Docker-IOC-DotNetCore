using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlcontext;

        public RepositoryCliente(SqlContext sqlcontext)
            : base(sqlcontext)
        {
            this.sqlcontext = sqlcontext;
        }
    }
}