using App.Domain.Repositories;
using System;

namespace App.Infrastructure.Repositories
{
    public class CalculaJurosRepository : ICalculaJurosRepository
    {
        public double CalcularJuros(double valorInicial, double juros, int meses)
        {
            double result = valorInicial * Math.Pow((1 + juros), meses);
            result = Math.Truncate(100 * result) / 100;
            return result;
        }
    }
}
