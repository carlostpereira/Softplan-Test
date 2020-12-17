using App.Domain.Commands.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace CalculaJuros.Api
{
    public static class DependenceResolver
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<CalculaJurosCommandHandler, CalculaJurosCommandHandler>();
        }
    }
}
