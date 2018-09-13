using System;
using ClasseSealed.Biblioteca;

namespace ClasseSealed
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              - uma classe Sealed não pode ser herdada (não possui classes derivadas)
              - essa classe poderá herdar uma outra classe sem problemas
              - no exemplo abaixo, a classe Carro herda da classe abstrata Veiculo que possui
              uma propriedade abstrata implementada. Porém, como ela é selada, nenhuma outra 
              poderá herdá-la.
            */
            Carro carro = new Carro();
            carro.Marca = "Peugeot";
            Console.WriteLine("A marca do carro é: " + carro.Marca);

        }
    }
}
