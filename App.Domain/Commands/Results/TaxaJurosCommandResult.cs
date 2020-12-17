using App.Shared.Commands;

namespace App.Domain.Commands.Results
{
    public class TaxaJurosCommandResult : ICommandResult
    {
        public TaxaJurosCommandResult()
        {
        }

        public TaxaJurosCommandResult(double valorTaxaJuros)
        {
            ValorTaxaJuros = valorTaxaJuros;
        }

        public double ValorTaxaJuros { get; set; }
    }
}
