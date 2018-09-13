using System;

namespace MaisSobreHeranca.Biblioteca
{
    public class Carro : Veiculo, ITransporte
    {

        public Carro() : base() { }

        public void InfoFabricacao() => Console.WriteLine("Ano de Fabricacao: " + this.AnoFabricacao);

        public void Andar() { Console.WriteLine("O carro está andando;"); }
    }
}
