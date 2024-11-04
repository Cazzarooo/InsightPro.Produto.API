namespace InsightPro.Produto.Domain.Interfaces.Dtos
{
    public interface IProdutoDto
    {
        string Nome { get; set; }
        string Descricao { get; set; }

        void Validation();
    }
}
