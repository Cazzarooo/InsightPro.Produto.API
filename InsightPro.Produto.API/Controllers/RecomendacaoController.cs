﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace InsightPro.Produto.API.Controllers
{
    public class DadosRecomendacao
    {
        [LoadColumn(0)] public string Nome { get; set; }
        [LoadColumn(1)] public string Produto { get; set; }
        [LoadColumn(2)] public float AvaliacaoProduto { get; set; }
    }
    public class RecomendacaoProduto
    {
        [ColumnName("Score")]
        public float PontuacaoRecomendacao { get; set; }

        [ColumnName("Produto")]
        public string Produto { get; set; } = string.Empty;
    }


    [Route("api/[controller]")]
    [ApiController]
    public class RecomendacaoController : ControllerBase
    {
        private readonly string caminhoModelo = Path.Combine(Environment.CurrentDirectory, "wwwroot", "MLModels", "ModeloRecomendacao.zip");
        private readonly string caminhoTreinamento = Path.Combine(Environment.CurrentDirectory, "Data", "large_random_product_reviews.csv");
        private readonly MLContext mlContext;

        public RecomendacaoController()
        {
            mlContext = new MLContext();

            if (!System.IO.File.Exists(caminhoModelo))
            {
                Console.WriteLine("Modelo não encontrado. Iniciando treinamento...");
                TreinarModelo();
            }
        }

        [HttpGet("recomendar/{nome}/{produto}")]
        public IActionResult Recomendar(string nome, string produto)
        {
            if (!System.IO.File.Exists(caminhoModelo))
            {
                return BadRequest("O modelo ainda não foi treinado.");
            }

            ITransformer modelo;
            using (var stream = new FileStream(caminhoModelo, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                modelo = mlContext.Model.Load(stream, out var modeloSchema);
            }

            var engineRecomendacao = mlContext.Model.CreatePredictionEngine<DadosRecomendacao, RecomendacaoProduto>(modelo);

            var recomendacao = engineRecomendacao.Predict(new DadosRecomendacao
            {
                Nome = nome,
                Produto = produto
            });

            return Ok(new
            {
                score = recomendacao.PontuacaoRecomendacao,
                produto = recomendacao.Produto,
                recomendacao = GetStatusRecomendacao(recomendacao.PontuacaoRecomendacao)
            });
        }


        private void TreinarModelo()
        {
            var pastaModelo = Path.GetDirectoryName(caminhoModelo);
            if (!Directory.Exists(pastaModelo))
            {
                Directory.CreateDirectory(pastaModelo);
                Console.WriteLine($"Diretório criado: {pastaModelo}");
            }

            IDataView dadosTreinamento = mlContext.Data.LoadFromTextFile<DadosRecomendacao>(
                path: caminhoTreinamento, hasHeader: true, separatorChar: ',');

            var pipeline = mlContext.Transforms.CopyColumns(outputColumnName: "Label", inputColumnName: nameof(DadosRecomendacao.AvaliacaoProduto))
                .Append(mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "NomeCodificado", inputColumnName: nameof(DadosRecomendacao.Nome)))
                .Append(mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "ProdutoCodificado", inputColumnName: nameof(DadosRecomendacao.Produto)))
                .Append(mlContext.Transforms.Concatenate("Features", "NomeCodificado", "ProdutoCodificado"))
                .Append(mlContext.Regression.Trainers.FastTree());

            var modelo = pipeline.Fit(dadosTreinamento);

            mlContext.Model.Save(modelo, dadosTreinamento.Schema, caminhoModelo);
            Console.WriteLine($"Modelo treinado e salvo em: {caminhoModelo}");
        }

        private string GetStatusRecomendacao(float pontuacao)
        {
            switch (Math.Round(pontuacao, 1))
            {
                case >= 4:
                    return "Altamente Recomendado";
                case >= 3:
                    return "Recomendado";
                default:
                    return "Não Recomendado";
            }
        }

    }

}
