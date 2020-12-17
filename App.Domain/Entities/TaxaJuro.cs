namespace App.Domain.Entities
{
    public class TaxaJuro
    {
        public TaxaJuro()
        {
        }

        public TaxaJuro(double valorTaxaJuros = 1)
        {
            valorTaxaJuros = (valorTaxaJuros <= 0 ? 1 : valorTaxaJuros);
            this.ValorTaxaJuros = (valorTaxaJuros /100);
        }

        public double ValorTaxaJuros { get; set; }
    }
}
