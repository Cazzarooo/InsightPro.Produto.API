using InsightPro.Produto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightPro.Produto.Domain.Interfaces
{
    public interface IEnderecoService
    {
        Task<Endereco?> ObterEnderecoPorCepAsync(string cep);
    }
}
