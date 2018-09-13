using System;
using ManipulandoException.Biblioteca;

namespace ManipulandoException
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              - lançando exceptions
              - Exception é a classe base para lançar erros
              - para tratar exceptions devemos setar o try~catch
              - podem ser tratadas múltiplas exceptions
            */
            Console.Write("Digite um número: ");
            string digitado = Console.ReadLine();

            try
            {
                if (digitado == "1") {
                    Console.WriteLine("Correto");
                } else {
                    throw new Exception("Errado");
                }
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep.Message);
            }

            /*
              - para criar a sua própria exception, basta criar uma classe
              e herdar da classe Exception
            */
            try
            {
                throw new MinhaException();
            }
            catch (MinhaException mExcep)
            {
                Console.WriteLine(mExcep.Message);
            }
        }
    }
}
