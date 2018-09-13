using System;
using ClasseMetodoEPropriedadeAbstrata.Biblioteca;

namespace ClasseMetodoEPropriedadeAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              - classe abstrata: não pode ser instanciada, porém pode ser herdada
              - é necessário utilizar o nome abstract
              - no exemplo abaixo a classe veículo será abstrata
              
            */
            // Veiculo veiculo = new Veiculo(); = não irá funcionar
            // abaixo implementações concretas derivadas da classe abstrata
            Carro carro = new Carro();
            Caminhao caminhao = new Caminhao();

            /*
              - o objetivo do método abstrato é que ele seja finalizado na classe filha
              - o método abstrato deverá estar sempre situado em uma classe abstrata
            */
            carro.Montadora = "Ponto 1";
            caminhao.Montadora = "BMW Show";

            /*
              - a propriedade abstrata deverá ser implementada nas classes filhas
              - por questões óbvias uma propriedade que é estática não pode ser abstrata
            */
            carro.MudarMarcha(5);
            caminhao.MudarMarcha(3);
        }
    }
}
