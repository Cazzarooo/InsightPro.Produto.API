using InsightPro.Produto.Application.Dtos;
using InsightPro.Produto.Domain.Entities;
using InsightPro.Produto.Domain.Interfaces;
using InsightPro.Produto.Domain.Interfaces.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightPro.Produto.Application.Services
{
    public class ProdutoApplicationService: IProdutoApplicationService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IEnderecoService _enderecoService;

        public ProdutoApplicationService(IProdutoRepository produtoRepository, IEnderecoService enderecoService)
        {
            _produtoRepository = produtoRepository;
            _enderecoService = enderecoService;
        }


        public ProdutoEntity? DeletarDadosProduto(int id)
        {
            return _produtoRepository.DeletarDados(id);
        }

        public ProdutoEntity? EditarDadosProduto(int id, IProdutoDto entity)
        {
            entity.Validation();

            return _produtoRepository.EditarDados(new ProdutoEntity {
                Id = id,
                Nome = entity.Nome,
                Descricao = entity.Descricao,
            });
        }

        public ProdutoEntity? ObterProdutoPorId(int id)
        {
            return _produtoRepository.ObterPorId(id);
        }

        public IEnumerable<ProdutoEntity> ObterTodosProdutos()
        {
            return _produtoRepository.ObterTodos();
        }

        public ProdutoEntity? SalvarDadosProduto(IProdutoDto entity)
        {
            entity.Validation();

            return _produtoRepository.SalvarDados(new ProdutoEntity
            {
                Nome = entity.Nome,
                Descricao = entity.Descricao,
            });
        }
        public async Task<Endereco?> ObterEnderecoPorCepAsync(string cep)
        {
            var endereco = await _enderecoService.ObterEnderecoPorCepAsync(cep);

            if (endereco is not null)
                return endereco;

            return null;
        }
    }
}
