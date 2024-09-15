using InsightPro.Produto.Domain.Entities;

namespace InsightPro.Produto.Domain.Interfaces
{

    public interface IProdutoRepository
    {
        IEnumerable<ProdutoEntity> ObterTodos();
        ProdutoEntity? ObterPorId(int id);
        ProdutoEntity? SalvarDados(ProdutoEntity entity);
        ProdutoEntity? EditarDados(ProdutoEntity entity);
        ProdutoEntity? DeletarDados(int id);

    }
}