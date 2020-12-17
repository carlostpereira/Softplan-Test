using App.Domain.Commands.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace TaxaJuros.Api
{
    public static class DependenceResolver
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<TaxaJurosCommandHandler, TaxaJurosCommandHandler>();
        }
    }
}
