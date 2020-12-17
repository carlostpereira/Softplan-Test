using App.Domain.Commands.Inputs;
using App.Domain.Commands.Results;
using App.Domain.Entities;
using App.Shared.Commands;

namespace App.Domain.Commands.Handlers
{
    public class CalculaJurosCommandHandler : ICommandHandler<CalculaJurosCommand>
    {
        public CalculaJurosCommandHandler()
        {
        }


        public ICommandResult Handle(CalculaJurosCommand command)
        {
            var commandObject = new CalculaJuro(command.ValorInicial, command.Juros, command.Meses);
            return new CalculaJurosCommandResult(commandObject.ValorJurosComposto);

        }

    }
}
