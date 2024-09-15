using InsightPro.Produto.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InsightPro.Produto.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<ProdutoEntity> Produto { get; set; }
    }

}