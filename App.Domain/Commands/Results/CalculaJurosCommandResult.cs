using App.Shared.Commands;

namespace App.Domain.Commands.Results
{
    public class CalculaJurosCommandResult : ICommandResult
    {
        public CalculaJurosCommandResult()
        {

        }

        public CalculaJurosCommandResult(double calculoJurosComposto)
        {
            CalculoJurosComposto = calculoJurosComposto;
        }

        public double CalculoJurosComposto { get; set; }
    }
}
