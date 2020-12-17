namespace App.Domain.Repositories
{
    public interface ICalculaJurosRepository
    {
        double CalcularJuros(double valorInicial, double juros, int meses);
    }
}
