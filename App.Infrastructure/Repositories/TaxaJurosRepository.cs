using App.Domain.Repositories;

namespace App.Infrastructure.Repositories
{
    public class TaxaJurosRepository : ITaxaJurosRepository
    {
        public double ObterTaxaJuros()
        {
            return 0.01;

        }
    }
}
