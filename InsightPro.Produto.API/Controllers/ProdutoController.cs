using InsightPro.Produto.Application.Services;
using InsightPro.Produto.Domain.Entities;
using InsightPro.Produto.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsightPro.Produto.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoApplicationService _produtoApplicationService;

        public ProdutoController(IProdutoApplicationService produtoApplicationService)
        {
            _produtoApplicationService = produtoApplicationService;
        }

        /// <summary>
        /// Metodo para obter todos os dados de produto
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces<IEnumerable<ProdutoEntity>>]
        public IActionResult Get()
        {
            var produtos = _produtoApplicationService.ObterTodosProdutos();

            if(produtos is not null)
                return Ok(produtos);

            return BadRequest("Não foi possível obter os dados");    
        }

        /// <summary>
        /// Método para obter um produto
        /// </summary>
        /// <param name="id">Identificador do produto</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces<ProdutoEntity>]

        public IActionResult GetPorId(int id)
        {
            var produtos = _produtoApplicationService.ObterProdutoPorId(id);

            if (produtos is not null)
                return Ok(produtos);

            return BadRequest("Não foi possível obter os dados");
        }


        /// <summary>
        /// Método para salvar o produto
        /// </summary>
        /// <param name="entity">Modelo de dados do Produto</param>
        /// <returns></returns>
        [HttpPost]
        [Produces<ProdutoEntity>]
        public IActionResult Post(ProdutoEntity entity)
        {
            var produtos = _produtoApplicationService.SalvarDadosProduto(entity);

            if (produtos is not null)
                return Ok(produtos);

            return BadRequest("Não foi possível salvar os dados");
        }

        /// <summary>
        /// Método para editar o produto
        /// </summary>
        /// <param name="entity">Modelo de dados do Produto</param>
        /// <returns></returns>
        [HttpPut]
        [Produces<ProdutoEntity>]
        public IActionResult Put(ProdutoEntity entity)
        {
            var produtos = _produtoApplicationService.EditarDadosProduto(entity);

            if (produtos is not null)
                return Ok(produtos);

            return BadRequest("Não foi possível editar os dados");
        }

        /// <summary>
        /// Método para deletar um produto
        /// </summary>
        /// <param name="id">Identificador do produto</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Produces<ProdutoEntity>]

        public IActionResult Delete(int id)
        {
            var produtos = _produtoApplicationService.DeletarDadosProduto(id);

            if (produtos is not null)
                return Ok(produtos);

            return BadRequest("Não foi possível deletar os dados");
        }
    }
}
