using System;
using ClassePropriedadeMetodo.Biblioteca;

namespace ClassePropriedadeMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Yuri", "M", new DateTime(1986, 10, 3), 20.0, 10.3);
            Console.WriteLine(pessoa.ResumoPessoa());
            Console.WriteLine("Posição: " + pessoa.PegarPosicao());
        }
    }
}
