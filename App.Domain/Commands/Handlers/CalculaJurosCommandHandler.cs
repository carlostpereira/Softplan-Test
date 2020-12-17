using App.Domain.Commands.Inputs;
using App.Domain.Commands.Results;
using App.Domain.Entities;
using App.Domain.Repositories;
using App.Shared.Commands;

namespace App.Domain.Commands.Handlers
{
    public class CalculaJurosCommandHandler : ICommandHandler<CalculaJurosCommand>
    {
        private readonly ICalculaJurosRepository _repository;
        public CalculaJurosCommandHandler(ICalculaJurosRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CalculaJurosCommand command)
        {
            var calculoJuros = _repository.CalcularJuros(command.ValorInicial, command.Juros, command.Meses);
            var commandObject = new CalculaJuro(calculoJuros);

            return new CalculaJurosCommandResult(commandObject.ValorJurosComposto);

        }

    }
}
