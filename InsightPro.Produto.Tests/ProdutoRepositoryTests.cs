using InsightPro.Produto.Data.AppData;
using InsightPro.Produto.Data.Repositories;
using InsightPro.Produto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightPro.Produto.Tests
{
    public class ProdutoRepositoryTests
    {
        private readonly DbContextOptions<ApplicationContext> _options;
        private readonly ApplicationContext _context;
        private readonly ProdutoRepository _produtoRepository;

        public ProdutoRepositoryTests()
        {
            _options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new ApplicationContext(_options);
            _produtoRepository = new ProdutoRepository(_context);
        }

        [Fact]
        public void Adicionar_DeveAdicionarERetornarProdutoEntity()
        {
            // Arrange
            var produto = new ProdutoEntity { Nome = "Celular", Descricao = "Preto"};

            // Act
            var resultado = _produtoRepository.SalvarDados(produto);

            // Assert
            var produtoNoDb = _context.Produto.FirstOrDefault(c => c.Id == resultado.Id);
            Assert.NotNull(produtoNoDb);
            Assert.Equal(produto.Nome, produtoNoDb.Nome);
            Assert.Equal(produto.Descricao, produtoNoDb.Descricao);
        }


    }
}
