using InsightPro.Produto.Application.Services;
using InsightPro.Produto.Data.AppData;
using InsightPro.Produto.Data.Repositories;
using InsightPro.Produto.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace InsightPro.Produto.IoC
{
    public static class Bootstrap
    {
        public static void Start(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options => {
                options.UseOracle(configuration["ConnectionStrings:Oracle"]);
            });


            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<IProdutoApplicationService, ProdutoApplicationService>();

        }
    }
}
