using InsightPro.Produto.Domain.Entities;
using InsightPro.Produto.Domain.Interfaces;
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

        public ProdutoApplicationService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public ProdutoEntity? DeletarDadosProduto(int id)
        {
            return _produtoRepository.DeletarDados(id);
        }

        public ProdutoEntity? EditarDadosProduto(ProdutoEntity entity)
        {
            return _produtoRepository.EditarDados(entity);
        }

        public ProdutoEntity? ObterProdutoPorId(int id)
        {
            return _produtoRepository.ObterPorId(id);
        }

        public IEnumerable<ProdutoEntity> ObterTodosProdutos()
        {
            return _produtoRepository.ObterTodos();
        }

        public ProdutoEntity? SalvarDadosProduto(ProdutoEntity entity)
        {
            return _produtoRepository.SalvarDados(entity);
        }
    }
}
