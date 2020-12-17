using App.Domain.Commands.Inputs;
using App.Domain.Commands.Results;
using App.Domain.Entities;
using App.Shared.Commands;

namespace App.Domain.Commands.Handlers
{
    public class TaxaJurosCommandHandler : ICommandHandler<TaxaJurosCommand>
    {
        public TaxaJurosCommandHandler()
        {
        }


        public ICommandResult Handle(TaxaJurosCommand command)
        {
            var commandObject = new TaxaJuro(command.BaseCalculo);
            return new TaxaJurosCommandResult(commandObject.ValorTaxaJuros);

        }

    }
}
