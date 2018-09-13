using System;
using Interface.Biblioteca;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              - interfaces nao sao classes, mas elas definem o que uma classe
              deve conter para que ela se adeque
              - interfaces não devem conter nenhuma implementação
              - interface é como um contrato
            */
            Carro carro = new Carro();
            carro.Mover(10);
        }
    }
}
