using App.Domain.Commands.Handlers;
using App.Domain.Repositories;
using App.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace TaxaJuros.Api
{
    public static class DependenceResolver
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ITaxaJurosRepository, TaxaJurosRepository>();
            services.AddTransient<TaxaJurosCommandHandler, TaxaJurosCommandHandler>();
        }
    }
}
