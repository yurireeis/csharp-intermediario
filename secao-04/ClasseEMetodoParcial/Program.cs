using System;
using ClasseEMetodoParcial.Biblioteca;

namespace ClasseEMetodoParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              - uma class do tipo partial é uma classe que se baseia em dois arquivos
              - você pode por exemplo, criar propriedades em uma e métodos em outra, 
              ou propriedades e métodos em ambas, etc.
              - no exemplo abaixo, foram criadas duas classes com o mesmo nome em um mesmo 
              arquivo: Pessoa. Cada uma com uma propriedade (para fins de teste)
              - Essas classes poderiam estar em arquivos distintos que ocorreria o mesmo efeito
            */
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Yuri";
            pessoa.Endereco = "Rua Domingos Pedro Hermes";
            Console.WriteLine(String.Format(
                "O nome {0} está na partial e o endereço {1} na outra partial.",
                pessoa.Nome,
                pessoa.Endereco
            ));

            /*
              - com o mesmo objetivo de validação, será criado em um arquivo a parte
              dois partial da classe Pessoa com métodos
              - o método partial SEMPRE será void/privado
            */
        }
    }
}
