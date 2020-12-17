namespace App.Domain.Entities
{
    public class TaxaJuro
    {
        public TaxaJuro()
        {
        }

        public TaxaJuro(double valorTaxaJuros)
        {
            this.ValorTaxaJuros = valorTaxaJuros;
        }

        public double ValorTaxaJuros { get; set; }
    }
}
