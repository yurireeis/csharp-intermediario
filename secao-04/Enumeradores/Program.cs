using System;
using Enumeradores.Biblioteca;

namespace Enumeradores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              - é uma lista de constantes
            */
            Console.WriteLine(String.Format(
                "O valor do estado civil {0} é {1}.",
                EstadoCivil.Casado,
                (int)EstadoCivil.Casado
            ));
        }
    }
}
