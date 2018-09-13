using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              System.IO é a classe responsável pela leitura e escrita de arquivos 
            */
            StreamWriter arquivo = new StreamWriter("texto.txt");
            arquivo.WriteLine("Texto do Arquivo gravado!");
            arquivo.Close();

            /*
              realizando a leitura de um arquivo
            */
            string textoLido = File.ReadAllText("texto.txt");
            Console.WriteLine(textoLido + " (agora lido)");

            /*
              realizando a leitura com o dispose
              - quando usamos o using, estamos criando um escopo isolado para uma determinada
              tarefa
              - a parte boa é que, além de deixar identificado que aquela ação só ocorre naquele
              escopo, também podemos finalizar o uso dos recursos utilizadas para tal tarefa ao 
              final da execução dela
              - segue o exemplo abaixo com a utililização do using
            */
            using (StreamWriter novoArquivo = new StreamWriter("texto2.txt"))
            {
                novoArquivo.WriteLine("Escrevendo com o uso do using");
                novoArquivo.Close();
                novoArquivo.Dispose();
            }
        }
    }
}
