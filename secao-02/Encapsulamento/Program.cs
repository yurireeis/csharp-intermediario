using System;
using Encapsulamento.Biblioteca;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            // basicamente criar getters and setters para as propriedades da classe
            // permite que você tenha um controle maior no que entra/sai em relação a classe
            Pessoa pessoa = new Pessoa();
            pessoa.SetNome("Yuri");
            Console.WriteLine("O nome é: " + pessoa.GetNome());
        }
    }
}
