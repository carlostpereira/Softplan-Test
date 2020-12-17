using System;

namespace App.Domain.Entities
{
    public class CalculaJuro
    {
        public CalculaJuro()
        {
        }

        public CalculaJuro(double valorJurosComposto)
        {
            this.ValorJurosComposto = valorJurosComposto;
        }

        public double ValorJurosComposto { get; private set; }

    }
}
