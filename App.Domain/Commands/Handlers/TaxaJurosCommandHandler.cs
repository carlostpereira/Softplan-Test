using App.Domain.Commands.Results;
using App.Domain.Entities;
using App.Domain.Repositories;
using App.Shared.Commands;

namespace App.Domain.Commands.Handlers
{
    public class TaxaJurosCommandHandler
    {
        private readonly ITaxaJurosRepository _repository;
        public TaxaJurosCommandHandler(ITaxaJurosRepository repository)
        {
            _repository = repository;
        }


        public ICommandResult Handle()
        {
            var taxaJuros = _repository.ObterTaxaJuros();
            var commandObject = new TaxaJuro(taxaJuros);

            return new TaxaJurosCommandResult(commandObject.ValorTaxaJuros);

        }

    }
}
