using App.Infrastructure.Repositories;
using Xunit;

namespace App.Test
{
    public class SoftplanTest
    {
        public SoftplanTest()
        {
        }

        [Fact]
        public void ObtemTaxaJuros()
        {
            var _repositoryTaxaJuros = new TaxaJurosRepository();
            Assert.Equal(0.01, _repositoryTaxaJuros.ObterTaxaJuros());
        }

        [Fact]
        public void CalculaTaxaJuros()
        {
            var valorInicial = 100.0;
            var meses = 5;

            var _repositoryTaxaJuros = new TaxaJurosRepository();
            var _repositoryCalculaTaxaJuros = new CalculaJurosRepository();

            var juros = _repositoryTaxaJuros.ObterTaxaJuros();
            Assert.Equal(105.10, _repositoryCalculaTaxaJuros.CalcularJuros(valorInicial, juros, meses));
        }
    }
}
