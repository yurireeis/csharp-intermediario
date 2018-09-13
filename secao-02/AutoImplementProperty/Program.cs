using System;
using AutoImplementProperty.Biblioteca;

namespace AutoImplementProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            // o exemplo abaixo é o padrão para setar getter and setter
            pessoa.SetNome("Yuri");
            Console.WriteLine("Nome: " + pessoa.Nome);

            // o exemplo abaixo é a implementação personalizada de telefone na classe
            pessoa.Telefone = "998294414";
            Console.WriteLine("Meu telefone é: " + pessoa.Telefone);

            // o exemplo abaixo é a implementação personalizada utilizando arrow function
            pessoa.Endereco = "Rua Domingos Pedro Hermes";
            Console.WriteLine("Meu endereço é: " + pessoa.Endereco);
        }
    }
}
