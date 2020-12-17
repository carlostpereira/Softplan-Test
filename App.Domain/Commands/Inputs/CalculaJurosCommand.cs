using App.Shared.Commands;
using System.Text.Json.Serialization;

namespace App.Domain.Commands.Inputs
{
    public class CalculaJurosCommand : ICommand
    {
        public double ValorInicial { get; set; }
        [JsonIgnore]
        public double Juros { get; set; }
        public int Meses { get; set; }
    }

}
