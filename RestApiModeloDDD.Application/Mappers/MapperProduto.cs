﻿

using RestApiModeloDDD.Application.ProdutoDtos;
using RestApiModeloDDD.Domain.Entitys;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Mapper
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Valor = produtoDto.Valor
            };
            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };
            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos)
        {
            var result = produtos.Select(p => new ProdutoDto
            {
                Id = p.Id,
                Nome = p.Nome,
                Valor = p.Valor
            });
            return result;
        }
    }
}