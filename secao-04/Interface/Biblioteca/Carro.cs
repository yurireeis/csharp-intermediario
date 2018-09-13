using System;

namespace Interface.Biblioteca
{
    // é possível herdar de uma classe e implementar quantas interfaces quiser
    public class Carro : Veiculo, ITransporte
    {
        public void Mover(byte velocidade) => Console.WriteLine(String.Format("Movendo-se a {0} KM...", velocidade));
    }
}
