using App.Domain.Commands.Handlers;
using App.Domain.Repositories;
using App.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CalculaJuros.Api
{
    public static class DependenceResolver
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ICalculaJurosRepository, CalculaJurosRepository>();
            services.AddTransient<CalculaJurosCommandHandler, CalculaJurosCommandHandler>();
        }
    }
}
