using System;
using System.Linq;
using Estrutura.Biblioteca;

namespace Estrutura
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              estruturas (struct são muito semelhantes a classes)
              a diferença está no armazenamento por valor X por referência
              estruturas = valor
              classes = referência
              struct costuma ser mais rápido que classes
              a maneira de instanciar é idêntica a da classe
            */
            Console.Write("Digite um valor em polegadas para ser convertido em cm: ");
            double polegadas =  double.Parse(Console.ReadLine());
            Polegada polegada = new Polegada(polegadas);
            Console.WriteLine("Valor em cm das polegadas: " + polegada.getPolegadaCentimetros());

            /*
              passagem de parâmetro por valor: a variável valor que tem atribuída a si 25
              é passada por parâmetro e ao ser impressa novamente nota-se que a mesma não
              tem vínculo algum com a variável valor que está dentro do método Alterar por valor
            */
            double valor = 25;
            AlterarPorValor(valor);
            Console.WriteLine("Valor alterado por valor: " + valor);

            /*
              passagem de parâmetro por referência: a variável valor que tem atribuída a si 25
              é passada por parâmetro e ao ser impressa novamente nota-se que a mesma tem vínculo
              com a variável valor que está dentro do método Alterar por Referência (irá ser 35)
            */
            AlterarPorReferencia(ref valor);
            Console.WriteLine("Valor alterado por referência: " + valor);

            /*
              quando se utiliza o out para passar um valor por referência, DENTRO do método existente
              o valor passado como referência não pode ser lido em hipótese alguma
            */
            AlterarPorReferenciaComOut(out valor);
            Console.WriteLine("Valor alterado por referência com out: " + valor);

            /*
              utilizar a palavra reservada params permite com que você possa passar quantos parâmetros 
              quiser de valores string sequencia transformando o mesmo no final das contas em um array
              similar ao *args do python
              o valor marcado como params deve estar localizado no último parâmetro do método
            */
            string[] nomes = VariosParametros("yuri", "reis");

            Console.WriteLine("Nomes: ");
            foreach (string nome in nomes) { Console.WriteLine(nome); }
        }

        static void AlterarPorValor(double valor)
        {
            Console.WriteLine("Valor atual: " + valor);
            valor += 10;
            Console.WriteLine("Valor alterado: " + valor);
        }

        static void AlterarPorReferencia(ref double valor)
        {
            Console.WriteLine("Valor atual: " + valor);
            valor += 10;
            Console.WriteLine("Valor alterado: " + valor);
        }

        static void AlterarPorReferenciaComOut(out double valor) => valor = 10;

        static string[] VariosParametros(params string[] parametros)
        {
            return parametros.Select(parametro => parametro.ToUpper()).ToArray();
        }
    }
}
