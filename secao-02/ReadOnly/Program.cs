using System;
using ReadOnly.Biblioteca;

namespace ReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            // propriedades readOnly não permite escrita
            // similar ao set privado
            // não pode ser sobrescrita nem mesmo dentro da própria classe
            Pessoa pessoa = new Pessoa();
            pessoa.Name = "Yuri";
            Console.WriteLine("O valor de PI é: {0} e o nome do usuário é: {1}", pessoa.Pi, pessoa.Name);
        }
    }
}
