using InsightPro.Produto.Application.Services;
using InsightPro.Produto.Domain.Entities;
using InsightPro.Produto.Domain.Interfaces;
using InsightPro.Produto.Domain.Interfaces.Dtos;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightPro.Produto.Tests
{
    public class ProdutoApplicationServiceTests
    {
        private readonly Mock<IEnderecoService> _enderecoServiceMock;
        private readonly Mock<IProdutoRepository> _repositoryMock;
        private readonly ProdutoApplicationService _produtoService;

        public ProdutoApplicationServiceTests()
        {
            _repositoryMock = new Mock<IProdutoRepository>();
            _enderecoServiceMock = new Mock<IEnderecoService>();
            _produtoService = new ProdutoApplicationService(_repositoryMock.Object, _enderecoServiceMock.Object);
        }

        [Fact]
        public void AdicionarProduto_DeveRetornarProdutoEntity_QuandoAdicionarComSucesso()
        {
            // Arrange
            var produtoDtoMock = new Mock<IProdutoDto>();
            produtoDtoMock.Setup(c => c.Nome).Returns("Celular");
            produtoDtoMock.Setup(c => c.Descricao).Returns("Preto");


            var produtoEsperado = new ProdutoEntity { Nome = "Celular", Descricao = "Preto"};

           _repositoryMock.Setup(r => r.SalvarDados(It.IsAny<ProdutoEntity>())).Returns(produtoEsperado);

            // Act
            var resultado = _produtoService.SalvarDadosProduto(produtoDtoMock.Object);

            // Assert
            Assert.NotNull(resultado);
            Assert.Equal(produtoEsperado.Nome, resultado.Nome);
            Assert.Equal(produtoEsperado.Descricao, resultado.Descricao);

        }

    }
}
