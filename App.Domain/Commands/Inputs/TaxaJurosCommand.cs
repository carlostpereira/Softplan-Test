using App.Shared.Commands;

namespace App.Domain.Commands.Inputs
{
    public class TaxaJurosCommand : ICommand
    {
     public double BaseCalculo { get; set; }
    }

}

