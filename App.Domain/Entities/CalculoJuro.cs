using System;

namespace App.Domain.Entities
{
    public class CalculaJuro
    {
        public CalculaJuro()
        {
        }

        public CalculaJuro(double valorInicial, double juros, int meses)
        {
            this.ValorJurosComposto = CalcularJurosCompostos(valorInicial, juros, meses);
        }

        public double ValorJurosComposto { get; private set; }

        private double CalcularJurosCompostos(double valorInicial, double juros, int meses)
        {
            double result = valorInicial * Math.Pow((1 + juros), meses);
            result = Math.Truncate(100 * result) / 100;
            return result;
        }
    }
}
