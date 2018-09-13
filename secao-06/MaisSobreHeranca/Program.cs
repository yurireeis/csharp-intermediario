using System;
using MaisSobreHeranca.Biblioteca;

namespace MaisSobreHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.InfoFabricacao();

            /*
              - casting: conversão de um tipo
              - trunca o valor caso o valor seja "incompatível"
              - é uma forma mais rápida de se realizar uma conversão
            */
            double preco = 3125.10;
            float preco2 = (float)preco;

            /*
              - boxing: transformar um tipo que é armazenado por valor e transformar por referência
              - unboxing: transformar um tipo que é armazenado por referência e transformar por valor
            */
            int a = 10;

            // object é por referência por ser um objeto, além de receber qualquer coisa
            // quando eu passei o a que é uma referência por valor para um objeto, passou a ser por referência
            // neste caso abaixo ocorreu o boxing
            object b = a;

            // neste caso abaixo ocorreu o unboxing
            int c = a;

            /*
              - interface e polimorfismo
              - assim como com classes, ao se implementar uma interface é possível
              implementar o conceito de polimorfismo
              - também é possível assinar o método com uma interface, assim permitindo
              com que ele se torne polimórfico a partir das classes que implementam
              esta interface
            */
            Onibus onibus = new Onibus();
            Andar(onibus);
            Andar(carro);
        }

        static void Andar(ITransporte transporte) => transporte.Andar();
    }
}
