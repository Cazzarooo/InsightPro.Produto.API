using InsightPro.Produto.Domain.Entities;
using InsightPro.Produto.Domain.Interfaces.Dtos;

namespace InsightPro.Produto.Domain.Interfaces
{
    public interface IProdutoApplicationService
    {
        IEnumerable<ProdutoEntity> ObterTodosProdutos();
        ProdutoEntity? ObterProdutoPorId(int id);
        ProdutoEntity? SalvarDadosProduto(IProdutoDto entity);
        ProdutoEntity? EditarDadosProduto(int id, IProdutoDto entity);
        ProdutoEntity? DeletarDadosProduto(int id);
        Task<Endereco?> ObterEnderecoPorCepAsync(string cep);

    }
}