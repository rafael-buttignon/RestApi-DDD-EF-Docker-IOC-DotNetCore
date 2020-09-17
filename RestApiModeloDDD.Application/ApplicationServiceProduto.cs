using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.ProdutoDtos;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interfaces;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto serviceProduto;
        private readonly IMapperProduto mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            this.serviceProduto = serviceProduto;
            this.mapperProduto = mapperProduto;
        }

        public void Add(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = serviceProduto.GetAll();
            return mapperProduto.MapperListProdutosDto(produtos);
        }

        public ProdutoDto GetById(int id)
        {
            var produtos = serviceProduto.GetById(id);
            return mapperProduto.MapperEntityToDto(produtos);
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Update(produto);
        }
    }
}