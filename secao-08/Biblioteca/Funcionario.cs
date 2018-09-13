using System;

namespace Biblioteca
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public DateTime DataContratacao { get; set; }
    }
}
