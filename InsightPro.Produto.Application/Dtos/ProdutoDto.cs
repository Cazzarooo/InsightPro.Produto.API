using FluentValidation;
using InsightPro.Produto.Domain.Interfaces.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightPro.Produto.Application.Dtos
{
    public class ProdutoDto : IProdutoDto
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;

        public void Validation()
        {
            //FluentValidation

            var validateResult = new ProdutoDtoValidation().Validate(this);
                      
            if(!validateResult.IsValid)
                throw new Exception(string.Join(" e ", validateResult.Errors.Select(e => e.ErrorMessage)));
        }
    }

    internal class ProdutoDtoValidation : AbstractValidator<ProdutoDto>
    {
        public ProdutoDtoValidation()
        {
            RuleFor(x => x.Nome)
                .MinimumLength(5).WithMessage(x => $"O campo {nameof(x.Nome)} deve ter no mínimo 5 caracteres")
                .NotEmpty().WithMessage(x => $"O campo {nameof(x.Nome)} não pode ser vazio");

            RuleFor(x => x.Descricao)
                .NotEmpty().WithMessage(x => $"O campo {nameof(x.Descricao)} não pode ser vazio");

        }
    }
}
