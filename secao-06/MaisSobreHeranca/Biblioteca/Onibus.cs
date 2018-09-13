using System;

namespace MaisSobreHeranca.Biblioteca
{
    public class Onibus: Veiculo, ITransporte
    {
        public Onibus() : base() { }

        public void Andar() { Console.WriteLine("O onibus está andando."); }
    }
}
