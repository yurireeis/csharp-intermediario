using System;
// foi utilizado o comando: dotnet add reference <path do csproj>
using Biblioteca;

namespace Referencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O resultado é: " + CalculoJuros.Soma(1, 3));
        }
    }
}
