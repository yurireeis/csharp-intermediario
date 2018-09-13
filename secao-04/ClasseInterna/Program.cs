using System;
using ClasseInterna.Biblioteca;

namespace ClasseInterna
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              - para criar uma classe interna basta criar uma classe dentro de uma classe
              classes internas só são acessíveis dentro da própria classe
              - se a classe interna for pública, ela poderá ser chamada através da classe ao
              qual está aninhada
              - classes internas podem oferecer uma organização maior
              - classes internas também podem chamar as classes ao qual estão sendo aninhadas
            */
            Console.WriteLine("Chamando uma propriedade estática de uma classe interna/pública: " + Pessoa.Olho.Iris);
        }
    }
}
