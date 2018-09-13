using System;

namespace ClasseEMetodoParcial.Biblioteca
{
    partial class Pessoa
    {
        partial void ImprimirNome(string nome) => Console.WriteLine(nome);
    }

    partial class Pessoa
    {
        partial void ImprimirEndereco(string endereco) => Console.WriteLine(endereco);
    }
}
