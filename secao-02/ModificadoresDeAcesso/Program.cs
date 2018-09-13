using System;
using ModificadoresDeAcesso.Biblioteca;

namespace ModificadoresDeAcesso
{
    class Program
    {
        static void Main(string[] args)
        {
            // tipos: public, private, protected, internal, protected internal
            // tudo que é publico está disponível para todos
            // protected é para a classe e para classes derivadas
            // private é acessível apenas para a classe
            // internal é acessível apenas para a classe do projeto original (private só pro projeto)
            // protected internal é valido apenas para classes filhas do mesmo projeto (protected só pro projeto)

            Caminhao caminhao = new Caminhao("Mercedes", "0505", new DateTime());
            Carro carro = new Carro("VW", "Gol", new DateTime(1986, 12, 12));
            Console.WriteLine(carro.InfoVeiculo());
            Console.WriteLine(caminhao.InfoVeiculo());
        }
    }
}
