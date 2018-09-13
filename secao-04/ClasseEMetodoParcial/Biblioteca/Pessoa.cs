namespace ClasseEMetodoParcial.Biblioteca
{
    partial class Pessoa
    {
        public string Nome { get; set; }

        partial void ImprimirNome(string nome);
    }

    partial class Pessoa
    {
        public string Endereco { get; set; }

        partial void ImprimirEndereco(string endereco);
    }
}
